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
            this.avgCharLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.avgCharDescLbl = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionLbl
            // 
            this.instructionLbl.AutoSize = true;
            this.instructionLbl.Location = new System.Drawing.Point(87, 29);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(207, 16);
            this.instructionLbl.TabIndex = 0;
            this.instructionLbl.Text = "Enter some words into the textbox.";
            // 
            // inputTxtBox
            // 
            this.inputTxtBox.Location = new System.Drawing.Point(36, 48);
            this.inputTxtBox.Name = "inputTxtBox";
            this.inputTxtBox.Size = new System.Drawing.Size(311, 22);
            this.inputTxtBox.TabIndex = 1;
            this.inputTxtBox.Text = "This is an example sentence.";
            // 
            // wordsDescLbl
            // 
            this.wordsDescLbl.AutoSize = true;
            this.wordsDescLbl.Location = new System.Drawing.Point(50, 81);
            this.wordsDescLbl.Name = "wordsDescLbl";
            this.wordsDescLbl.Size = new System.Drawing.Size(108, 16);
            this.wordsDescLbl.TabIndex = 2;
            this.wordsDescLbl.Text = "Amount of words:";
            // 
            // wordsLbl
            // 
            this.wordsLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wordsLbl.Location = new System.Drawing.Point(56, 100);
            this.wordsLbl.Name = "wordsLbl";
            this.wordsLbl.Size = new System.Drawing.Size(98, 31);
            this.wordsLbl.TabIndex = 3;
            this.wordsLbl.Text = "?";
            this.wordsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avgCharLbl
            // 
            this.avgCharLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avgCharLbl.Location = new System.Drawing.Point(225, 100);
            this.avgCharLbl.Name = "avgCharLbl";
            this.avgCharLbl.Size = new System.Drawing.Size(98, 31);
            this.avgCharLbl.TabIndex = 5;
            this.avgCharLbl.Text = "?";
            this.avgCharLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(235, 153);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 28);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // avgCharDescLbl
            // 
            this.avgCharDescLbl.AutoSize = true;
            this.avgCharDescLbl.Location = new System.Drawing.Point(187, 81);
            this.avgCharDescLbl.Name = "avgCharDescLbl";
            this.avgCharDescLbl.Size = new System.Drawing.Size(183, 16);
            this.avgCharDescLbl.TabIndex = 4;
            this.avgCharDescLbl.Text = "Average charecters per word:";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(67, 153);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 28);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(147, 147);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(82, 40);
            this.calculateBtn.TabIndex = 6;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 213);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.avgCharDescLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.avgCharLbl);
            this.Controls.Add(this.wordsLbl);
            this.Controls.Add(this.wordsDescLbl);
            this.Controls.Add(this.inputTxtBox);
            this.Controls.Add(this.instructionLbl);
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
        private System.Windows.Forms.Label avgCharLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label avgCharDescLbl;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button calculateBtn;
    }
}

