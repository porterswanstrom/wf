using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookie_Calories
{
    public partial class cookieCalories : Form
    {
        public cookieCalories()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try {
                double calories = double.Parse(cookiesTextBox.Text) * 75;
                caloriesLabel.Text = calories.ToString("n0");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            cookiesTextBox.Text = "";
            caloriesLabel.Text = "?";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
