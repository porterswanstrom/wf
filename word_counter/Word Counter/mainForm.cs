using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Counter
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private int Words(string str)
        {
            return str.Trim().Split().Length;
        }

        private double AvgLetters(string str)
        {
            double letters = str.Trim().Count(char.IsLetter);

            return letters / Words(str);
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (inputTxtBox.Text.Trim() == "")
                wordsLbl.Text = "0";
            else
                wordsLbl.Text = Words(inputTxtBox.Text).ToString();
            
            avgLettersLbl.Text = AvgLetters(inputTxtBox.Text).ToString("n2");
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            inputTxtBox.Text = "";
            wordsLbl.Text = "?";
            avgLettersLbl.Text = "?";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
