using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Sales_Analysis
{
    public partial class salesAnalysis : Form
    {
        public salesAnalysis()
        {
            InitializeComponent();
        }

        private double Total(double[] dArray)
        {
            double total = 0;

            for (int i = 0; i < dArray.Length; i++)
                total += dArray[i];

            return total;
        }

        private double Average(double[] dArray)
        {
            double total = 0;

            for (int i = 0; i < dArray.Length; i++)
                total += dArray[i];

            return total / dArray.Length;
        }

        private double Largest(double[] dArray)
        {
            double highest = dArray[0];

            for (int i = 0; i < dArray.Length; i++)
                if (dArray[i] > highest)
                    highest = dArray[i];

            return highest;
        }

        private double Smallest(double[] dArray)
        {
            double lowest = dArray[0];

            for (int i = 0; i < dArray.Length; i++)
                if (dArray[i] < lowest)
                    lowest = dArray[i];

            return lowest;
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            try {
                double[] sales = new double[7];

                StreamReader input = File.OpenText("Sales.txt");

                for (int i = 0; !input.EndOfStream && i < sales.Length; i++)
                    sales[i] = double.Parse(input.ReadLine());

                input.Close();

                salesListBox.Items.Clear();

                foreach (double i in sales)
                    salesListBox.Items.Add(i);

                totalLabel.Text = Total(sales).ToString("c");
                averageLabel.Text = Average(sales).ToString("c");
                largestLabel.Text = Largest(sales).ToString("c");
                smallestLabel.Text = Smallest(sales).ToString("c");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            salesListBox.Items.Clear();

            totalLabel.Text = "?";
            averageLabel.Text = "?";
            largestLabel.Text = "?";
            smallestLabel.Text = "?";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
