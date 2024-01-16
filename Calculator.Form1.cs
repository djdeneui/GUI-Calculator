using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT232_DeNeui_Unit2
{
    public partial class Calc : Form
    {
        int total = 0;
        char prevOperation = ' ';
        int plusClicked = 0;
        int minusClicked = 0;
        int multiplyClicked = 0;
        int divideClicked = 0;
        int equalClicked = 0;

        public Calc()
        { 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculate()
        {

            // Display and calculation buttons (+, -, *, /)

            if (prevOperation == ' ')
            {
                total = Convert.ToInt32(lblDisplay.Text);
                lblDisplay.Text = "0";
            }
            else
            {
                if (prevOperation == '+')
                {
                    total = total + Convert.ToInt32(lblDisplay.Text);
                    lblDisplay.Text = "0";
                }
                if (prevOperation == '-')
                {
                    total = total - Convert.ToInt32(lblDisplay.Text);
                    lblDisplay.Text = "0";
                }
                if (prevOperation == '*')
                {
                    total = total * Convert.ToInt32(lblDisplay.Text);
                    lblDisplay.Text = "0";
                }
                if (prevOperation == '/')
                {
                    total = total / Convert.ToInt32(lblDisplay.Text);
                    lblDisplay.Text = "0";
                }
            }

            // Numbers (0-9) button pressing.

            if (plusClicked == 1)
            {
                prevOperation = '+';
                plusClicked = 0;
            }
            else if (minusClicked == 1)
            {
                prevOperation = '-';
                minusClicked = 0;
            }
            else if (multiplyClicked == 1)
            {
                prevOperation = '*';
                multiplyClicked = 0;
            }
            else if (divideClicked == 1)
            {
                prevOperation = '/';
                divideClicked = 0;
            }
            else
            {
                prevOperation = ' ';
                equalClicked = 0;
                lblDisplay.Text = Convert.ToString(total);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            minusClicked = 1;
            calculate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plusClicked = 1;
            calculate();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            divideClicked = 1;
            calculate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "2";
            else
                lblDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "3";
            else
                lblDisplay.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "4";
            else
                lblDisplay.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "8";
            else
                lblDisplay.Text += "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "9";
            else
                lblDisplay.Text += "9";
        }

        private void cmdClr_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            total = 0;
            prevOperation = ' ';
            plusClicked = 0;
            minusClicked = 0;
            multiplyClicked = 0;
            divideClicked = 0;
        }

        private void cmdZero_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "0";
            else
                lblDisplay.Text += "0";
        }

        private void cmdOne_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "1";
            else
                lblDisplay.Text += "1";
        }

        private void cmdFive_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "5";
            else
                lblDisplay.Text += "5";
        }

        private void cmdSix_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "6";
            else
                lblDisplay.Text += "6";
        }

        private void cmdSeven_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
                lblDisplay.Text = "7";
            else
                lblDisplay.Text += "7";
        }

        private void cmdMult_Click(object sender, EventArgs e)
        {
            multiplyClicked = 1;
            calculate();
        }

        private void cmdEqual_Click(object sender, EventArgs e)
        {
            equalClicked = 1;
            calculate();
        }
    }
}
