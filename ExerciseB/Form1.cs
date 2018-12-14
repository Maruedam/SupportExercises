using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Introducir un cuadro de texto, un listbox y dos botones.
 * En el texto se deben poder introducir números, 
 * un botón agregarlos a la lista y
 * otro debe indicar cual es el número mayor y cual es el número menor.*/
namespace ExerciseB
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

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = listBox1.Items.Cast<string>().Min(x => Convert.ToInt32(x)).ToString();
            textBox2.Text = listBox1.Items.Cast<string>().Max(x => Convert.ToInt32(x)).ToString();
        }
    }
}
