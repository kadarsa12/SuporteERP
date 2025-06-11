using SuporteERPForms;

namespace SuporteERP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                if (loginForm.PerfilUsuario == "admin")
                {
                    Application.Run(new MenuPrincipal(loginForm.UsuarioLogado));
                }
                else
                {
                    Application.Run(new Form1(loginForm.UsuarioLogado));
                }
            }

        }
    }
}