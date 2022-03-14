using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_036
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            
        }                                            

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

         private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string[] decimalNumbers = textBox1.Text.Split('+', '-', '*', '/');
            string[] operators = textBox1.Text.Split('0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.');

            List<string> s = new List<string>();
            foreach (var item in operators)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    s.Add(item);
                }
            }
            decimal intSum = 0;
            for (int i = 0; i < decimalNumbers.Length; i++)
            {
                if (i == 0)
                {
                    intSum = Convert.ToDecimal(decimalNumbers[i]);
                }
                if (i > 0)
                {
                    string oprator = s[i - 1];
                    switch (oprator)
                    {
                        case "+":
                            intSum = intSum + Convert.ToDecimal(decimalNumbers[i]);
                            break;
                        case "-":
                            intSum = intSum - Convert.ToDecimal(decimalNumbers[i]);
                            break;
                        case "*":
                            intSum = intSum * Convert.ToDecimal(decimalNumbers[i]);
                            break;
                        case "/":
                            intSum = intSum / Convert.ToDecimal(decimalNumbers[i]);
                            break;
                    }
                }
            }
            textBox1.Clear();
            textBox1.Text =  Math.Round(intSum, 2).ToString();
        }
    }
}
