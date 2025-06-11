using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuporteERPForms
{
    public partial class VisualizarImagemForm : Form
    {
        public VisualizarImagemForm(Image imagem)
        {
            InitializeComponent();
            pictureBox1.Image = imagem;
        }
    }
}
