using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SuporteERPForms
{
    public partial class Form1 : Form
    {
        private CaseRecommender recommender;
        private MySqlRepository repo;
        private readonly string _usuarioLogado;

        public Form1(string usuarioLogado)
        {
            _usuarioLogado = usuarioLogado;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string connStr = "Server=localhost;Database=suporte_erp;Uid=root;Pwd=424596;";
                repo = new MySqlRepository(connStr); // ✅ instanciado corretamente no escopo da classe

                var casos = repo.CarregarCasos();
                recommender = new CaseRecommender(casos);

                MessageBox.Show("Conectado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (recommender == null)
            {
                MessageBox.Show("Sistema ainda não está pronto para recomendar.");
                return;
            }

            var entrada = txtProblema.Text.Trim();
            if (string.IsNullOrWhiteSpace(entrada)) return;

            var solucao = recommender.GetBestMatch(entrada, out float sim);
            txtResultado.Text = $"Solução sugerida:\n{solucao}\n\nSimilaridade: {sim:F2}";

            // Limpar imagens anteriores
            flowImagens.Controls.Clear();

            // Buscar caso com imagens
            var caso = repo.CarregarCasos().FirstOrDefault(c => c.Solution == solucao);

            if (caso?.ImagensBase64 != null)
            {
                foreach (var base64 in caso.ImagensBase64)
                {
                    var bytes = Convert.FromBase64String(base64);
                    using var ms = new MemoryStream(bytes);
                    var img = Image.FromStream(ms);

                    var pic = new PictureBox
                    {
                        Image = img,
                        Width = 100,
                        Height = 100,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Margin = new Padding(5),
                        Cursor = Cursors.Hand
                    };
                    pic.Click += (s, ev) =>
                    {
                        using var zoom = new VisualizarImagemForm(pic.Image);
                        zoom.ShowDialog();
                    };
                    flowImagens.Controls.Add(pic);
                }
            }

            // Registrar no log
            repo.RegistrarLog(_usuarioLogado, entrada, solucao, sim);
        }
    }
}
