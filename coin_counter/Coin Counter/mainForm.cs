using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Counter
{
    public partial class coinCounter : Form
    {
        public coinCounter()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            try {
                int cents = int.Parse(penniesTxtBox.Text) +
                    int.Parse(nickelsTxtBox.Text) * 5 +
                    int.Parse(dimesTxtBox.Text) * 10 +
                    int.Parse(quartersTxtBox.Text) * 25;

                if (cents < 100)
                    MessageBox.Show("That's less than a dollar. Try again.");
                else if (cents > 100)
                    MessageBox.Show("That's more than a dollar. Try again.");
                else
                    MessageBox.Show("Congratulations! That's exactly one dollar.");
            }
            catch {
                MessageBox.Show("Enter a whole number in each box.");
            }
        }
 

        private void clearBtn_Click(object sender, EventArgs e)
        {
            penniesTxtBox.Text = "0";
            nickelsTxtBox.Text = "0";
            dimesTxtBox.Text = "0";
            quartersTxtBox.Text = "0";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
