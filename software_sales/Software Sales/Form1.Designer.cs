namespace Software_Sales
{
    partial class softwareSales
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.packagesTextBox = new System.Windows.Forms.TextBox();
            this.discountDescriptionLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.costDescriptionLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(37, 24);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(267, 16);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "How many packages would you like to buy?";
            // 
            // packagesTextBox
            // 
            this.packagesTextBox.Location = new System.Drawing.Point(121, 43);
            this.packagesTextBox.Name = "packagesTextBox";
            this.packagesTextBox.Size = new System.Drawing.Size(100, 22);
            this.packagesTextBox.TabIndex = 1;
            // 
            // discountDescriptionLabel
            // 
            this.discountDescriptionLabel.AutoSize = true;
            this.discountDescriptionLabel.Location = new System.Drawing.Point(37, 86);
            this.discountDescriptionLabel.Name = "discountDescriptionLabel";
            this.discountDescriptionLabel.Size = new System.Drawing.Size(104, 16);
            this.discountDescriptionLabel.TabIndex = 2;
            this.discountDescriptionLabel.Text = "Your discount is:";
            // 
            // discountLabel
            // 
            this.discountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabel.Location = new System.Drawing.Point(147, 82);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(123, 23);
            this.discountLabel.TabIndex = 3;
            this.discountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costLabel
            // 
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(147, 117);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(123, 26);
            this.costLabel.TabIndex = 5;
            this.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costDescriptionLabel
            // 
            this.costDescriptionLabel.AutoSize = true;
            this.costDescriptionLabel.Location = new System.Drawing.Point(66, 123);
            this.costDescriptionLabel.Name = "costDescriptionLabel";
            this.costDescriptionLabel.Size = new System.Drawing.Size(75, 16);
            this.costDescriptionLabel.TabIndex = 4;
            this.costDescriptionLabel.Text = "The cost is:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(121, 164);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(90, 47);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Cost";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(40, 171);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 32);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(217, 171);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 32);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // softwareSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 233);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.costDescriptionLabel);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.discountDescriptionLabel);
            this.Controls.Add(this.packagesTextBox);
            this.Controls.Add(this.instructionLabel);
            this.Name = "softwareSales";
            this.Text = "Software Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.TextBox packagesTextBox;
        private System.Windows.Forms.Label discountDescriptionLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label costDescriptionLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

