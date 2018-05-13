using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace copiar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Ubicacion, NombreImg, Ruta;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Title = "Abrir";
            Open.Filter = "Jpg files (*.jpg)|*.jpg|Gif files (*.gif)|*.gif|Bitmap files (*.Bmp)|*.bmp|PNG files (*.png)|*.png*";

            if (Open.ShowDialog() == DialogResult.OK)
            {
                Ubicacion = Open.FileName;
                textBox2.Text = Ubicacion;
                NombreImg = Open.SafeFileName;
                textBox1.Text = NombreImg;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Copy(Ubicacion, Environment.CurrentDirectory + @"\Prueba\"+NombreImg, true);
            string final = Environment.CurrentDirectory + @"\Prueba\" + NombreImg;
            MessageBox.Show(final);
        }
    }
}
