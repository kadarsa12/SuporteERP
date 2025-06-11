namespace SuporteERPForms
{
    partial class MenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnVerLogs;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCadastrarCaso;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnUsuarios = new Button();
            btnVerLogs = new Button();
            btnSair = new Button();
            lblTitulo = new Label();
            btnCadastrarCaso = new Button();
            SuspendLayout();
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.MidnightBlue;
            btnUsuarios.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(50, 90);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(140, 80);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "👥\nUsuários";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnVerLogs
            // 
            btnVerLogs.BackColor = Color.MidnightBlue;
            btnVerLogs.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVerLogs.ForeColor = Color.White;
            btnVerLogs.Location = new Point(210, 90);
            btnVerLogs.Name = "btnVerLogs";
            btnVerLogs.Size = new Size(140, 80);
            btnVerLogs.TabIndex = 3;
            btnVerLogs.Text = "📄\nVer Logs";
            btnVerLogs.UseVisualStyleBackColor = false;
            btnVerLogs.Click += btnVerLogs_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.DarkRed;
            btnSair.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(210, 190);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(140, 80);
            btnSair.TabIndex = 4;
            btnSair.Text = "\u23fb\nSair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.Location = new Point(40, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(210, 37);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Menu Principal";
            // 
            // btnCadastrarCaso
            // 
            btnCadastrarCaso.BackColor = Color.MidnightBlue;
            btnCadastrarCaso.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCadastrarCaso.ForeColor = Color.White;
            btnCadastrarCaso.Location = new Point(50, 190);
            btnCadastrarCaso.Name = "btnCadastrarCaso";
            btnCadastrarCaso.Size = new Size(140, 80);
            btnCadastrarCaso.TabIndex = 0;
            btnCadastrarCaso.Text = "➕\nCadastrar Caso";
            btnCadastrarCaso.UseVisualStyleBackColor = false;
            btnCadastrarCaso.Click += btnCadastrarCaso_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 284);
            Controls.Add(btnCadastrarCaso);
            Controls.Add(lblTitulo);
            Controls.Add(btnUsuarios);
            Controls.Add(btnVerLogs);
            Controls.Add(btnSair);
            Name = "MenuPrincipal";
            Text = "Menu Principal";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
