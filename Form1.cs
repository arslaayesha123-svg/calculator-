using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caculator2
{
    public partial class Form1 : Form
    {
        string value = "";
        int a = 0;
        string operation = "";
        public Form1()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "6";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "9";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "0";
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            value = txtDisplay.Text;
            a = int.Parse(value);
            operation = "+";
            txtDisplay.Clear();

        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            value = txtDisplay.Text;
            a = int.Parse(value);
            operation = "-";
            txtDisplay.Clear();
        }

        private void buttonmltply_Click(object sender, EventArgs e)
        {
            value = txtDisplay.Text;
            a = int.Parse(value);
            operation = "*";
            txtDisplay.Clear();
        }

        private void buttondivison_Click(object sender, EventArgs e)
        {
            value = txtDisplay.Text;
            a = int.Parse(value);
            operation = "/";
            txtDisplay.Clear();
        }

        private void buttoneql_Click(object sender, EventArgs e)
        {
            int  b  = int.Parse(txtDisplay.Text);
            int result = 0;
            if (operation == "+")
            {
                  result = a + b;
                
                
            }
            else if (operation == "-")
            {
                  result = a - b;
               
                
            }
            else if (operation == "*")
            {
                   result = a * b;
                
                }
            
            else if (operation == "/")
            { 
                    if (b != 0)
                        result = a / b;
                } 
            else
            {
                txtDisplay.Text = "error";
                return;
            }
               txtDisplay.Text = result.ToString();
            } 

        private void buttonclr_Click(object sender, EventArgs e)
        {
            a = 0;
            value = "";
            operation = "";
            txtDisplay.Clear();
        }
    }
}

