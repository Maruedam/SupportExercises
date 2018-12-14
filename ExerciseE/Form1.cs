using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Introducir un timer, un label y un checkbox. 
 * Cuando el checkbox este seleccionado.
 * El label debe moverse un pixel a la derecha, por cada Tick del timer.*/
namespace ExerciseE
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

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += 1;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                timer1.Enabled = true;
            }
            else
                timer1.Enabled = false;
        }
    }
}
