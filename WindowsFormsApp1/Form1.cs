using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;    
            textBox1.Text += btn.Text;

        }

        private bool flagDot = false;

        private void btnd_Click(object sender, EventArgs e)
        {

            if (flagDot == false)
            {
                textBox1.Text += ".";
                flagDot = true;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            flagDot = false;
            textBox1.Text = string.Empty;   
        }

        private string mathoprator;
        private string firstNumber;
        private void btn_ops(object sender, EventArgs e)
        {
            Button button = sender as Button;
            mathoprator = button.Text;
            firstNumber = button.Text;

            textBox1.Text += "";
        }

        private void btn_Calc(object sender, EventArgs e)
        {
            switch (mathoprator)
            {
                case "+":
                    textBox1.Text = (decimal.Parse(firstNumber) + decimal.Parse(textBox1.Text)).ToString(); break;
                case "-":
                    textBox1.Text = (decimal.Parse(firstNumber) - decimal.Parse(textBox1.Text)).ToString(); break;
                case "*":
                    textBox1.Text = (decimal.Parse(firstNumber) * decimal.Parse(textBox1.Text)).ToString(); break;
                case "/":
                    textBox1.Text = (decimal.Parse(firstNumber) / decimal.Parse(textBox1.Text)).ToString(); break;
                default: 
                    break;
            }

        }
    }
}
