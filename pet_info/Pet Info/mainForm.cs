using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Info
{
    public partial class petInfo : Form
    {
        public petInfo()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();

            if (nameTxtBox.Text == "" || typeTxtBox.Text == "" ||
                ageTxtBox.Text == "") {
                outputLbl.Text = "Please fill out the information.";
                return;
            }

            pet.Name = nameTxtBox.Text;
            pet.Type = typeTxtBox.Text;
            pet.Age = ageTxtBox.Text;

            outputLbl.Text = pet.Name + " is a " + pet.Age +
                " year old " + pet.Type + ".";

        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTxtBox.Text = "";
            typeTxtBox.Text = "";
            ageTxtBox.Text = "";
            outputLbl.Text = "? is a ? year old ?.";
        }
    }
}
