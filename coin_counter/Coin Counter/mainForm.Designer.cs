namespace Coin_Counter
{
    partial class coinCounter
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
            this.helpLbl = new System.Windows.Forms.Label();
            this.penniesLbl = new System.Windows.Forms.Label();
            this.dimesLbl = new System.Windows.Forms.Label();
            this.nickelsLbl = new System.Windows.Forms.Label();
            this.quartersLbl = new System.Windows.Forms.Label();
            this.penniesTxtBox = new System.Windows.Forms.TextBox();
            this.nickelsTxtBox = new System.Windows.Forms.TextBox();
            this.dimesTxtBox = new System.Windows.Forms.TextBox();
            this.quartersTxtBox = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helpLbl
            // 
            this.helpLbl.AutoSize = true;
            this.helpLbl.Location = new System.Drawing.Point(15, 26);
            this.helpLbl.Name = "helpLbl";
            this.helpLbl.Size = new System.Drawing.Size(389, 16);
            this.helpLbl.TabIndex = 1;
            this.helpLbl.Text = "Try to enter an amount of coins that adds up to exactly one dollar.";
            // 
            // penniesLbl
            // 
            this.penniesLbl.AutoSize = true;
            this.penniesLbl.Location = new System.Drawing.Point(120, 56);
            this.penniesLbl.Name = "penniesLbl";
            this.penniesLbl.Size = new System.Drawing.Size(59, 16);
            this.penniesLbl.TabIndex = 2;
            this.penniesLbl.Text = "Pennies:";
            // 
            // dimesLbl
            // 
            this.dimesLbl.AutoSize = true;
            this.dimesLbl.Location = new System.Drawing.Point(126, 102);
            this.dimesLbl.Name = "dimesLbl";
            this.dimesLbl.Size = new System.Drawing.Size(49, 16);
            this.dimesLbl.TabIndex = 3;
            this.dimesLbl.Text = "Dimes:";
            // 
            // nickelsLbl
            // 
            this.nickelsLbl.AutoSize = true;
            this.nickelsLbl.Location = new System.Drawing.Point(259, 56);
            this.nickelsLbl.Name = "nickelsLbl";
            this.nickelsLbl.Size = new System.Drawing.Size(55, 16);
            this.nickelsLbl.TabIndex = 4;
            this.nickelsLbl.Text = "Nickels:";
            // 
            // quartersLbl
            // 
            this.quartersLbl.AutoSize = true;
            this.quartersLbl.Location = new System.Drawing.Point(255, 102);
            this.quartersLbl.Name = "quartersLbl";
            this.quartersLbl.Size = new System.Drawing.Size(61, 16);
            this.quartersLbl.TabIndex = 5;
            this.quartersLbl.Text = "Quarters:";
            // 
            // penniesTxtBox
            // 
            this.penniesTxtBox.Location = new System.Drawing.Point(101, 75);
            this.penniesTxtBox.Name = "penniesTxtBox";
            this.penniesTxtBox.Size = new System.Drawing.Size(100, 22);
            this.penniesTxtBox.TabIndex = 6;
            this.penniesTxtBox.Text = "0";
            // 
            // nickelsTxtBox
            // 
            this.nickelsTxtBox.Location = new System.Drawing.Point(236, 75);
            this.nickelsTxtBox.Name = "nickelsTxtBox";
            this.nickelsTxtBox.Size = new System.Drawing.Size(100, 22);
            this.nickelsTxtBox.TabIndex = 7;
            this.nickelsTxtBox.Text = "0";
            // 
            // dimesTxtBox
            // 
            this.dimesTxtBox.Location = new System.Drawing.Point(101, 121);
            this.dimesTxtBox.Name = "dimesTxtBox";
            this.dimesTxtBox.Size = new System.Drawing.Size(100, 22);
            this.dimesTxtBox.TabIndex = 8;
            this.dimesTxtBox.Text = "0";
            // 
            // quartersTxtBox
            // 
            this.quartersTxtBox.Location = new System.Drawing.Point(236, 121);
            this.quartersTxtBox.Name = "quartersTxtBox";
            this.quartersTxtBox.Size = new System.Drawing.Size(100, 22);
            this.quartersTxtBox.TabIndex = 9;
            this.quartersTxtBox.Text = "0";
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(171, 164);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(91, 42);
            this.calcBtn.TabIndex = 12;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(90, 169);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 33);
            this.clearBtn.TabIndex = 13;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(268, 167);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 37);
            this.exitBtn.TabIndex = 14;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // coinCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 233);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.quartersTxtBox);
            this.Controls.Add(this.dimesTxtBox);
            this.Controls.Add(this.nickelsTxtBox);
            this.Controls.Add(this.penniesTxtBox);
            this.Controls.Add(this.quartersLbl);
            this.Controls.Add(this.nickelsLbl);
            this.Controls.Add(this.dimesLbl);
            this.Controls.Add(this.penniesLbl);
            this.Controls.Add(this.helpLbl);
            this.Name = "coinCounter";
            this.Text = "Coin Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label helpLbl;
        private System.Windows.Forms.Label penniesLbl;
        private System.Windows.Forms.Label dimesLbl;
        private System.Windows.Forms.Label nickelsLbl;
        private System.Windows.Forms.Label quartersLbl;
        private System.Windows.Forms.TextBox penniesTxtBox;
        private System.Windows.Forms.TextBox nickelsTxtBox;
        private System.Windows.Forms.TextBox dimesTxtBox;
        private System.Windows.Forms.TextBox quartersTxtBox;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

