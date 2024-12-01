using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1_mohamed_samy
{
    public partial class Form1 : Form
    {
        string operation = "";
        double result=0;
        bool use=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button b1= (Button)sender;
            if (textBox1.Text == "0" || use==true)
            {
                textBox1.Clear();
            }
            if (b1.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + b1.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + b1.Text;
            }
            use = false;

            
      
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button b1 = (Button)sender;
            operation = b1.Text;
            result=double.Parse(textBox1.Text);
            use= true;
        }

        private void button10_Click(object sender, EventArgs e)
       {
            textBox1.Clear();
            result = 0;
          }

        private void button17_Click(object sender, EventArgs e)
        {
            switch(operation)
                {
                case "+":
                    textBox1.Text=(result +double.Parse(textBox1.Text)).ToString(); break;
                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString(); break;
                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString(); break;
                case "*":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString(); break;
            }
        }
    }
}
