using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Sales
{
    public partial class softwareSales : Form
    {
        public softwareSales()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try {
                const decimal PRICE = 99.00m;
                int packages = int.Parse(packagesTextBox.Text);
                decimal discount, cost;

                if (packages > 99)
                    discount = 0.5m;
                else if (packages > 49)
                    discount = 0.4m;
                else if (packages > 19)
                    discount = 0.3m;
                else if (packages > 9)
                    discount = 0.2m;
                else
                    discount = 0m;

                cost = packages * PRICE * (1 - discount);

                discountLabel.Text = discount.ToString("p0");
                costLabel.Text = cost.ToString("c");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            packagesTextBox.Text = "";
            discountLabel.Text = "";
            costLabel.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
