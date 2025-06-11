namespace SuporteERPForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
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
            SuspendLayout();
            // 
            // txtProblema
            // 
            txtProblema.Location = new Point(12, 12);
            txtProblema.Multiline = true;
            txtProblema.Name = "txtProblema";
            txtProblema.Size = new Size(460, 100);
            txtProblema.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(12, 120);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar Solução";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 149);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(460, 116);
            txtResultado.TabIndex = 2;
            txtResultado.Text = "";
            // 
            // flowImagens
            // 
            flowImagens.AutoScroll = true;
            flowImagens.Location = new Point(12, 271);
            flowImagens.Name = "flowImagens";
            flowImagens.Size = new Size(460, 120);
            flowImagens.TabIndex = 3;
            // 
            // Form1
            // 
            ClientSize = new Size(506, 395);
            Controls.Add(txtProblema);
            Controls.Add(btnBuscar);
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