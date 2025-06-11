using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SuporteERPForms
{
    public partial class CadastroCasoForm : Form
    {
        private List<string> imagensBase64 = new();

        public CadastroCasoForm()
        {
            InitializeComponent();
        }

        private void btnAdicionarImagem_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Imagens|*.png;*.jpg;*.jpeg;*.bmp"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (var file in ofd.FileNames)
                {
                    var img = Image.FromFile(file);
                    var thumb = new PictureBox
                    {
                        Image = img,
                        Width = 100,
                        Height = 100,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Margin = new Padding(5)
                    };
                    flowImagens.Controls.Add(thumb);

                    // Convert to base64
                    using var ms = new MemoryStream();
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imagensBase64.Add(Convert.ToBase64String(ms.ToArray()));
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text) || string.IsNullOrWhiteSpace(txtSolucao.Text))
            {
                MessageBox.Show("Preencha a descrição e a solução.", "Aviso");
                return;
            }

            var caso = new SupportCase
            {
                Problem = txtDescricao.Text.Trim(),
                Solution = txtSolucao.Text.Trim(),
                ImagensBase64 = imagensBase64
            };

            try
            {
                string connStr = "Server=localhost;Database=suporte_erp;Uid=root;Pwd=424596;";
                var repo = new MySqlRepository(connStr);
                repo.InserirCaso(caso);

                MessageBox.Show("Caso cadastrado com sucesso!", "Sucesso");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }
    }
}
