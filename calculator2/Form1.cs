using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculator2
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            Operation = "+";
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            Operation = "-";
        }

        private void button_multiple_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            Operation = "*";
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            Operation = "/";
        }

        private void button_equal_Click(object sender, EventArgs e)
        {

            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(richTextBox1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                richTextBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                richTextBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                richTextBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    richTextBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    richTextBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "8";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "8";
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "1";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "1";
            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "0";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "2";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "2";
            }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "3";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "3";
            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "4";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "4";
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "5";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "5";
            }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "6";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "6";
            }
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "7";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "7";
            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "9";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "9";
            }
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + ".";
        }

    }
}