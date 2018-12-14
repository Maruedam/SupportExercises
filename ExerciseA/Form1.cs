using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        List<int> lista1 = new List<int>();
        List<int> lista2 = new List<int>();

        private void Form1_Load(object sender, EventArgs e)
        {
           int j = 0;

            for (int i = 0; i <= 10; i ++)
            {

                lista1.Add(i);
                lista2.Add(i);
                j++;
            }
            foreach (int a in lista1)
            {
                listBox1.Items.Add(a);
            }
            foreach (int a in lista2)
            {
                listBox2.Items.Add(a);
            }

        }
        private int a;
        private int b;
        private void button1_Click(object sender, EventArgs e)
        {
             int a = Convert.ToInt32(listBox1.SelectedItem);
             int b = Convert.ToInt32(listBox2.SelectedItem);

            MessageBox.Show("el resultado es"+a*b);
        }
    }
}
