namespace SuporteERPForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblProblema;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtProblema;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RichTextBox txtResultado;
        private System.Windows.Forms.FlowLayoutPanel flowImagens;


        private void InitializeComponent()
        {
            txtProblema = new TextBox();
            btnBuscar = new Button();
            txtResultado = new RichTextBox();
            flowImagens = new FlowLayoutPanel();
            lblTitulo = new Label();
            lblProblema = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(196, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Busca de Soluções";
            //
            // lblProblema
            //
            lblProblema.AutoSize = true;
            lblProblema.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblProblema.Location = new Point(12, 50);
            lblProblema.Name = "lblProblema";
            lblProblema.Size = new Size(145, 19);
            lblProblema.TabIndex = 1;
            lblProblema.Text = "Descreva o problema:";
            //
            // txtProblema
            //
            txtProblema.Font = new Font("Segoe UI", 10F);
            txtProblema.Location = new Point(12, 72);
            txtProblema.Multiline = true;
            txtProblema.Name = "txtProblema";
            txtProblema.Size = new Size(460, 80);
            txtProblema.TabIndex = 2;
            //
            // btnBuscar
            //
            btnBuscar.BackColor = Color.MidnightBlue;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(12, 158);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 35);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar Solução";
            btnBuscar.Click += btnBuscar_Click;
            //
            // txtResultado
            //
            txtResultado.Font = new Font("Segoe UI", 10F);
            txtResultado.Location = new Point(12, 217);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(460, 110);
            txtResultado.TabIndex = 5;
            txtResultado.Text = "";
            //
            // flowImagens
            //
            flowImagens.AutoScroll = true;
            flowImagens.BackColor = Color.WhiteSmoke;
            flowImagens.Location = new Point(12, 333);
            flowImagens.Name = "flowImagens";
            flowImagens.Size = new Size(460, 120);
            flowImagens.TabIndex = 6;
            //
            // lblResultado
            //
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblResultado.Location = new Point(12, 195);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(66, 19);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado:";
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(506, 465);
            Controls.Add(lblTitulo);
            Controls.Add(lblProblema);
            Controls.Add(txtProblema);
            Controls.Add(btnBuscar);
            Controls.Add(lblResultado);
            Controls.Add(txtResultado);
            Controls.Add(flowImagens);
            Name = "Form1";
            Text = "Sugestão de Solução - Suporte ERP";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}