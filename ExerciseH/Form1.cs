using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Introducir dos cuadros de texto, un combobox y dos botones.
 * Un botón validará que el primer cuadro de texto es un numero
 * y el segundo texto no excede de los 9 caracteres, además de ser solo letras,
 * el combobox tendrá el valor (Camión, Moto y Coche en un enumerado). 
 * Se guardara en una clase llamado Conductor con un valor de entero, un string y un enumerado.*/
namespace ExerciseH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 1;
            textBox2.MaxLength = 9;

            comboBox1.Items.Add("camion");
            comboBox1.Items.Add("moto");
            comboBox1.Items.Add("coche");

        }
        public class Conductor
        {
            public int camion { get; set; }
            public String moto { get; set; }
            public enum coche
            {
                
            }

            public Conductor(int camion, string moto)
            {
                this.camion = camion;
                this.moto = moto;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los cuadros de texto cumplen con sus funciones", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conductor obj = new Conductor(Convert.ToInt32(textBox1.Text),textBox2.Text);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }
        
       
    }

       
           
    
}
