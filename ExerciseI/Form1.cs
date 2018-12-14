using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Introducir un botón, cada vez que el ratón se acerque al botón. Este debe desplazarse por la pantalla alejándose del puntero del ratón.*/
namespace ExerciseI
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

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            int x = (int)(this.ClientRectangle.Right * r.NextDouble()) - 30;
            int y = (int)(this.ClientRectangle.Bottom * r.NextDouble()) - 10;
            button1.Location = new Point(x, y);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LO HAS LOGRADO!!!","!ENHORABUENA¡",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
