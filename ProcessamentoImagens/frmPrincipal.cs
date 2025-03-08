using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ProcessamentoImagens
{
    public partial class frmPrincipal : Form
    {
        private Image image;
        private Bitmap imageBitmap;

        private bool flag = true;
        private int x1, y1, x2, y2;

        public frmPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Maximiza a janela ao iniciar
            comboBoxAlgoritmos.SelectedIndex = 1;
        }

        private void btnAbrirImg_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg;*.gif;*.bmp;*.png)|*.jpg;*.gif;*.bmp;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog.FileName);
                pictBoxImg.Image = image;
                pictBoxImg.SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta a imagem para preencher o PictureBox
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pictBoxImg.Image = null;
        }

        private void pictBoxImg_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEv = (MouseEventArgs)e;
            int mouseX = mouseEv.X;
            int mouseY = mouseEv.Y;

            if (flag)//se primeiro click
            {
                x1 = mouseX;
                y1 = mouseY;
                Console.WriteLine("Primeiro click: Coord -> X = " + x1 + " Y = " + y1);
            }
            else
            {
                x2 = mouseX;
                y2 = mouseY;
                Console.WriteLine("Segundo click: Coord -> X = " + x2 + " Y = " + y2);
            }
            flag = !flag;
        }
    }
}
