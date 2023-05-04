using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteOnPicture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        string picture;
        private void BtnPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picture = openFileDialog1.FileName;
        }

        Color color;
        private void BtnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            color = colorDialog1.Color;
        }

        Bitmap bmp;
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(picture);
            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawString(TxtText.Text, new Font("Segoe UI", Convert.ToInt16(TxtSize.Text),
                FontStyle.Bold), new SolidBrush(color), 20, 30);
            pictureBox1.Image = bmp; 
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            bmp.Save(saveFileDialog1.FileName);
        }
    }
}
