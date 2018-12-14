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

        }
    }
}
