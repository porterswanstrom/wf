using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial_Calculator
{
    public partial class factorialCalc : Form
    {
        public factorialCalc()
        {
            InitializeComponent();
        }

        private void calcBtn_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(inputTxtBox.Text, out int input) && input > -1) {
                long factorial = 1;

                for (int i = 1; i <= input; i++)
                    factorial *= i;

                outputLbl.Text = factorial.ToString();
            }
            else
                MessageBox.Show("Enter a nonnegative whole number.");
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            inputTxtBox.Text = "";
            outputLbl.Text = "?";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
