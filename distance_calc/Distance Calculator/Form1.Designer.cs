namespace Distance_Calculator
{
    partial class distanceCalculator
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
            this.mphLabel = new System.Windows.Forms.Label();
            this.mphTextBox = new System.Windows.Forms.TextBox();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mphLabel
            // 
            this.mphLabel.AutoSize = true;
            this.mphLabel.Location = new System.Drawing.Point(36, 21);
            this.mphLabel.Name = "mphLabel";
            this.mphLabel.Size = new System.Drawing.Size(145, 16);
            this.mphLabel.TabIndex = 0;
            this.mphLabel.Text = "Vehicle Speed in MPH:";
            // 
            // mphTextBox
            // 
            this.mphTextBox.Location = new System.Drawing.Point(193, 18);
            this.mphTextBox.Name = "mphTextBox";
            this.mphTextBox.Size = new System.Drawing.Size(100, 22);
            this.mphTextBox.TabIndex = 1;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(77, 54);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(104, 16);
            this.hoursLabel.TabIndex = 2;
            this.hoursLabel.Text = "Hours Traveled:";
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(193, 54);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(100, 22);
            this.hoursTextBox.TabIndex = 3;
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 16;
            this.outputListBox.Location = new System.Drawing.Point(36, 91);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(266, 116);
            this.outputListBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(77, 222);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(82, 40);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(184, 222);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(82, 40);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // distanceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 283);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.mphTextBox);
            this.Controls.Add(this.mphLabel);
            this.Name = "distanceCalculator";
            this.Text = "Distance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mphLabel;
        private System.Windows.Forms.TextBox mphTextBox;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

