using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Introducir un image y un botón en pantalla.
 * Mediante el botón debe mostrarnos el selector de ficheros
 * (FileOpenDialog) se debe cargar la imagen en el control de Image.*/
namespace ExerciseC
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
        OpenFileDialog fil = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            fil.InitialDirectory = "c:\\";

            fil.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (fil.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = fil.FileName;

            }

        }
    }
}
