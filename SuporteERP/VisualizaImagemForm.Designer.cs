namespace SuporteERPForms
{
    partial class VisualizarImagemForm
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new PictureBox();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = DockStyle.Fill;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // VisualizarImagemForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VisualizarImagemForm";
            this.Text = "Visualizar Imagem";
            this.ResumeLayout(false);
        }
    }
}
