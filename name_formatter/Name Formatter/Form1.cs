using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name_Formatter
{
    public partial class nameFormatter : Form
    {
        public nameFormatter()
        {
            InitializeComponent();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = titleTextBox.Text + " " +
                firstNameTextBox.Text + " " +
                middleNameTextBox.Text + " " +
                lastNameTextBox.Text;
        }

        private void secondButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = firstNameTextBox.Text + " " +
                middleNameTextBox.Text + " " +
                lastNameTextBox.Text;
        }

        private void thirdButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = firstNameTextBox.Text + " " +
                lastNameTextBox.Text;
        }

        private void forthButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = lastNameTextBox.Text + ", " +
                firstNameTextBox.Text + " " +
                middleNameTextBox.Text + ", " +
                titleTextBox.Text;
        }

        private void fifthButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = lastNameTextBox.Text + ", " +
                firstNameTextBox.Text + " " +
                middleNameTextBox.Text;
        }

        private void sixthButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = lastNameTextBox.Text + ", " +
                firstNameTextBox.Text;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            firstNameTextBox.Text = "";
            middleNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            outputLabel.Text = "";
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
