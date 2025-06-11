
using System;
using System.Windows.Forms;

namespace SuporteERPForms
{
    public partial class LoginForm : Form
    {
        public string UsuarioLogado { get; private set; }
        public string PerfilUsuario { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            string connStr = "Server=localhost;Database=suporte_erp;Uid=root;Pwd=424596;";
            var repo = new MySqlRepository(connStr);

            if (repo.ValidarUsuario(usuario, senha, out string nomeCompleto, out string perfil))
            {
                UsuarioLogado = nomeCompleto;
                PerfilUsuario = perfil;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");
            }
        }

    }
}
