using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cals_from_Fat_and_Carbs
{
    public partial class calsFromFatAndCarbs : Form
    {
        public calsFromFatAndCarbs()
        {
            InitializeComponent();
        }

        private double FatCals(double fat)
        {
            return fat * 9;
        }

        private double CarbCals(double carbs)
        {
            return carbs * 4;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(fatTextBox.Text, out double fat) ||
                !double.TryParse(carbsTextBox.Text, out double carbs))
                MessageBox.Show("The fat and carb grams must be numbers.");
            else
                outputLabel.Text = (FatCals(fat) +
                    CarbCals(carbs)).ToString("n2");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fatTextBox.Text = "";
            carbsTextBox.Text = "";
            outputLabel.Text = "?";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
