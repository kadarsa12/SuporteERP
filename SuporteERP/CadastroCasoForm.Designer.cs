namespace SuporteERPForms
{
    partial class CadastroCasoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtSolucao;
        private System.Windows.Forms.Button btnAdicionarImagem;
        private System.Windows.Forms.FlowLayoutPanel flowImagens;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblSolucao;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtSolucao = new System.Windows.Forms.TextBox();
            this.btnAdicionarImagem = new System.Windows.Forms.Button();
            this.flowImagens = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblSolucao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(20, 20);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 15);
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Multiline = true;
            this.txtDescricao.ScrollBars = ScrollBars.Vertical;
            this.txtDescricao.Location = new System.Drawing.Point(20, 40);
            this.txtDescricao.Size = new System.Drawing.Size(500, 80);
            // 
            // lblSolucao
            // 
            this.lblSolucao.AutoSize = true;
            this.lblSolucao.Location = new System.Drawing.Point(20, 130);
            this.lblSolucao.Name = "lblSolucao";
            this.lblSolucao.Size = new System.Drawing.Size(51, 15);
            this.lblSolucao.Text = "Solução:";
            // 
            // txtSolucao
            // 
            this.txtSolucao.Multiline = true;
            this.txtSolucao.ScrollBars = ScrollBars.Vertical;
            this.txtSolucao.Location = new System.Drawing.Point(20, 150);
            this.txtSolucao.Size = new System.Drawing.Size(500, 80);
            // 
            // btnAdicionarImagem
            // 
            this.btnAdicionarImagem.Location = new System.Drawing.Point(20, 240);
            this.btnAdicionarImagem.Size = new System.Drawing.Size(150, 30);
            this.btnAdicionarImagem.Text = "Adicionar Imagem";
            this.btnAdicionarImagem.Click += new System.EventHandler(this.btnAdicionarImagem_Click);
            // 
            // flowImagens
            // 
            this.flowImagens.Location = new System.Drawing.Point(20, 280);
            this.flowImagens.Size = new System.Drawing.Size(500, 120);
            this.flowImagens.AutoScroll = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(420, 410);
            this.btnSalvar.Size = new System.Drawing.Size(100, 30);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // CadastroCasoForm
            // 
            this.ClientSize = new System.Drawing.Size(550, 460);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblSolucao);
            this.Controls.Add(this.txtSolucao);
            this.Controls.Add(this.btnAdicionarImagem);
            this.Controls.Add(this.flowImagens);
            this.Controls.Add(this.btnSalvar);
            this.Name = "CadastroCasoForm";
            this.Text = "Cadastro de Novo Caso";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
