using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joke_and_Punch_Line
{
    public partial class jokeAndPunchLine : Form
    {
        public jokeAndPunchLine()
        {
            InitializeComponent();
        }

        private void setupButton_Click(object sender, EventArgs e)
        {
            jokeLabel.Text = "Why did the computer go to the doctor?";
            punchLineButton.Visible = true;
            setupButton.Visible = false;
        }
        private void punchLineButton_Click(object sender, EventArgs e)
        {
            jokeLabel.Text = "It had a virus!";
            punchLineButton.Visible = false;
            setupButton.Visible = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            jokeLabel.Text = "?";
            setupButton.Visible = true;
            punchLineButton.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
