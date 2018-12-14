using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Introducir dos textbox y un label, en uno solo se podrá introducir una letra
 * y en el segundo se podrá escribir todo lo que se quiera.
 * El label se debe actualizar cada vez que aparezca
 * la letra introducida en el primer textbox, en el texto del segundo recuadro*/
namespace ExerciseD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.MaxLength = 1;

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            label1.Text = textBox1.Text +" "+ textBox2.Text;
        }

    }
}
