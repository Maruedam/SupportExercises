using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Crear una clase persona, con nombre, apellido, edad y dni.
 * Crear un formulario con cuatro cuadros de texto en los cuales introducir distintas personas.
 * Verificar que no se repiten los dni al introducir el mismo.*/
namespace ExerciseJ
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

        public class Persona
        {
            private uint v1;
            private uint v2;

            public String  nombre{ get; set; }
            public String  apellido { get; set; }
            public int edad { get; set; }
            public int dni { get; set; }

            public Persona(string text, string text1, string text2, object text3)
            {
            }

            public Persona(string nombre, string apellido, int edad, int dni)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.edad = edad;
                this.dni = dni;
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                 Persona p1 = new Persona(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            if (Convert.ToInt32(textBox4.Text)==p1.dni)
            {
                MessageBox.Show("El DNI esta reprtido","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Persona p2 = new Persona(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            }
               
        }
    }
}
