namespace Word_Counter
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.instructionLbl = new System.Windows.Forms.Label();
            this.inputTxtBox = new System.Windows.Forms.TextBox();
            this.wordsDescLbl = new System.Windows.Forms.Label();
            this.wordsLbl = new System.Windows.Forms.Label();
            this.avgLettersLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.avgLetterDescLbl = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionLbl
            // 
            this.instructionLbl.AutoSize = true;
            this.instructionLbl.Location = new System.Drawing.Point(65, 24);
            this.instructionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(169, 13);
            this.instructionLbl.TabIndex = 0;
            this.instructionLbl.Text = "Enter some words into the textbox.";
            // 
            // inputTxtBox
            // 
            this.inputTxtBox.Location = new System.Drawing.Point(27, 39);
            this.inputTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputTxtBox.Name = "inputTxtBox";
            this.inputTxtBox.Size = new System.Drawing.Size(234, 20);
            this.inputTxtBox.TabIndex = 1;
            this.inputTxtBox.Text = "This is an example sentence.";
            // 
            // wordsDescLbl
            // 
            this.wordsDescLbl.AutoSize = true;
            this.wordsDescLbl.Location = new System.Drawing.Point(38, 66);
            this.wordsDescLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wordsDescLbl.Name = "wordsDescLbl";
            this.wordsDescLbl.Size = new System.Drawing.Size(89, 13);
            this.wordsDescLbl.TabIndex = 2;
            this.wordsDescLbl.Text = "Amount of words:";
            // 
            // wordsLbl
            // 
            this.wordsLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wordsLbl.Location = new System.Drawing.Point(42, 81);
            this.wordsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wordsLbl.Name = "wordsLbl";
            this.wordsLbl.Size = new System.Drawing.Size(74, 26);
            this.wordsLbl.TabIndex = 3;
            this.wordsLbl.Text = "?";
            this.wordsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avgLettersLbl
            // 
            this.avgLettersLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avgLettersLbl.Location = new System.Drawing.Point(169, 81);
            this.avgLettersLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgLettersLbl.Name = "avgLettersLbl";
            this.avgLettersLbl.Size = new System.Drawing.Size(74, 26);
            this.avgLettersLbl.TabIndex = 5;
            this.avgLettersLbl.Text = "?";
            this.avgLettersLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(176, 124);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(56, 23);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // avgLetterDescLbl
            // 
            this.avgLetterDescLbl.AutoSize = true;
            this.avgLetterDescLbl.Location = new System.Drawing.Point(146, 66);
            this.avgLetterDescLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.avgLetterDescLbl.Name = "avgLetterDescLbl";
            this.avgLetterDescLbl.Size = new System.Drawing.Size(125, 13);
            this.avgLetterDescLbl.TabIndex = 4;
            this.avgLetterDescLbl.Text = "Average letters per word:";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(50, 124);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(56, 23);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(110, 119);
            this.calculateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(62, 32);
            this.calculateBtn.TabIndex = 6;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 173);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.avgLetterDescLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.avgLettersLbl);
            this.Controls.Add(this.wordsLbl);
            this.Controls.Add(this.wordsDescLbl);
            this.Controls.Add(this.inputTxtBox);
            this.Controls.Add(this.instructionLbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mainForm";
            this.Text = "Word Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLbl;
        private System.Windows.Forms.TextBox inputTxtBox;
        private System.Windows.Forms.Label wordsDescLbl;
        private System.Windows.Forms.Label wordsLbl;
        private System.Windows.Forms.Label avgLettersLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label avgLetterDescLbl;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button calculateBtn;
    }
}

