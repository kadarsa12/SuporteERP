using System;
using System.Windows.Forms;

namespace SuporteERPForms
{
    public partial class MenuPrincipal : Form
    {
        private readonly string _usuario;

        public MenuPrincipal(string usuario)
        {
            _usuario = usuario;
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            // Exibe o usuário logado no título da janela
            this.Text = $"Menu Principal - Usuário: {_usuario}";
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir gerenciamento de usuários (em breve)", "Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerLogs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir visualização de logs de pesquisa (em breve)", "Logs", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Encerra o aplicativo
        }
        private void btnCadastrarCaso_Click(object sender, EventArgs e)
        {
            using var form = new CadastroCasoForm();
            form.ShowDialog();
        }

    }
}
