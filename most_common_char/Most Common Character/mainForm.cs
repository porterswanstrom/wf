using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Most_Common_Character
{
    public partial class mostCommonCharacter : Form
    {
        public mostCommonCharacter()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            string str = inputTxtBox.Text.Replace(" ", "").ToLower();
            int commonChar = 0;
            char ch = '\0';

            for (int i = 0; i < str.Length; i++) {
                int chars = 0;

                for (int j = 0; j < str.Length; j++)
                    if (str[i] == str[j])
                        chars++;

                if (chars > commonChar) {
                    commonChar = chars;
                    ch = str[i];
                }
            }

            outputLbl.Text = ch.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inputTxtBox.Text = "";
            outputLbl.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
