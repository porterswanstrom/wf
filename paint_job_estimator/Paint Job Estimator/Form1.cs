using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Job_Estimator
{
    public partial class paintJobEstimator : Form
    {
        public paintJobEstimator()
        {
            InitializeComponent();
        }

        private void EstimateButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal gallons = Math.Ceiling(Decimal.Divide(decimal.Parse(wallSpaceTextBox.Text), 115));
                decimal paintCost = gallons * decimal.Parse(gallonCostTextBox.Text);
                decimal labor = gallons * 8;
                decimal laborCost = labor * 20;
                decimal totalCost = paintCost + laborCost;

                gallonsLabel.Text = gallons.ToString();
                paintCostLabel.Text = paintCost.ToString("c");
                laborLabel.Text = labor.ToString();
                laborCostLabel.Text = laborCost.ToString("c");
                totalCostLabel.Text = totalCost.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            wallSpaceTextBox.Text = "";
            gallonCostTextBox.Text = "";
            gallonsLabel.Text = "";
            paintCostLabel.Text = "";
            laborLabel.Text = "";
            laborCostLabel.Text = "";
            totalCostLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
