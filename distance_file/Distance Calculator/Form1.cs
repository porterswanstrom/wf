using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Distance_Calculator
{
    public partial class distanceCalculator : Form
    {
        public distanceCalculator()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try {
                int hours = int.Parse(hoursTextBox.Text);
                int mph = int.Parse(mphTextBox.Text);

                if (saveFile.ShowDialog() == DialogResult.OK) {
                    StreamWriter output = File.CreateText(saveFile.FileName);

                    for (int i = 1; i <= hours; i++) {
                        output.WriteLine("After hour " + i +
                            " the distance is " + i * mph);
                    }

                    output.Close();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
