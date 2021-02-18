using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InterfaceTabuadaInfinita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tabuada = double.Parse(textBox1.Text);
            double alcance = double.Parse(textBox2.Text);
            double intervalo = double.Parse(textBox3.Text);


                this.richTextBox1.Clear();
            
                for (double i = 0; i <= alcance; i += intervalo)
                {
                richTextBox1.AppendText ($"{tabuada} X {i} = {tabuada * i} \n");
                


                }

            
        }
    }
}
