using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sentence_Capitalization
{
    public partial class sentenceCapitalization : Form
    {
        public sentenceCapitalization()
        {
            InitializeComponent();
        }

        private string Capitalized(string str)
        {
            char[] ch = str.ToCharArray();
            bool makeUpper = true;

            for (int i = 0; i < ch.Length; i++)
                if (makeUpper && char.IsLetter(ch[i])) {
                    ch[i] = char.ToUpper(ch[i]);
                    makeUpper = false;
                }
                else if (ch[i] == '.' || ch[i] == '?' || ch[i] == '!')
                    makeUpper = true;

            return new string(ch);
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            outputLbl.Text = Capitalized(inputTxtBox.Text);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            inputTxtBox.Text = "";
            outputLbl.Text = "?";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
