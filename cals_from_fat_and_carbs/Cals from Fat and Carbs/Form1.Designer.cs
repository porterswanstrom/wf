namespace Cals_from_Fat_and_Carbs
{
    partial class calsFromFatAndCarbs
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
            this.label1 = new System.Windows.Forms.Label();
            this.fatTextBox = new System.Windows.Forms.TextBox();
            this.carbsTextBox = new System.Windows.Forms.TextBox();
            this.fatLabel = new System.Windows.Forms.Label();
            this.carbsLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.calsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter grams of fat and carbohydrates to see the total calories.";
            // 
            // fatTextBox
            // 
            this.fatTextBox.Location = new System.Drawing.Point(103, 74);
            this.fatTextBox.Name = "fatTextBox";
            this.fatTextBox.Size = new System.Drawing.Size(100, 22);
            this.fatTextBox.TabIndex = 2;
            // 
            // carbsTextBox
            // 
            this.carbsTextBox.Location = new System.Drawing.Point(209, 74);
            this.carbsTextBox.Name = "carbsTextBox";
            this.carbsTextBox.Size = new System.Drawing.Size(100, 22);
            this.carbsTextBox.TabIndex = 4;
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Location = new System.Drawing.Point(116, 55);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(70, 16);
            this.fatLabel.TabIndex = 1;
            this.fatLabel.Text = "Fat grams:";
            // 
            // carbsLabel
            // 
            this.carbsLabel.AutoSize = true;
            this.carbsLabel.Location = new System.Drawing.Point(220, 55);
            this.carbsLabel.Name = "carbsLabel";
            this.carbsLabel.Size = new System.Drawing.Size(80, 16);
            this.carbsLabel.TabIndex = 3;
            this.carbsLabel.Text = "Carb grams:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(159, 157);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(84, 49);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate Cals";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(78, 165);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 32);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(249, 165);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 32);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(140, 110);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(127, 34);
            this.outputLabel.TabIndex = 8;
            this.outputLabel.Text = "?";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calsLabel
            // 
            this.calsLabel.AutoSize = true;
            this.calsLabel.Location = new System.Drawing.Point(98, 119);
            this.calsLabel.Name = "calsLabel";
            this.calsLabel.Size = new System.Drawing.Size(37, 16);
            this.calsLabel.TabIndex = 9;
            this.calsLabel.Text = "Cals:";
            // 
            // calsFromFatAndCarbs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 233);
            this.Controls.Add(this.calsLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.carbsLabel);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.carbsTextBox);
            this.Controls.Add(this.fatTextBox);
            this.Controls.Add(this.label1);
            this.Name = "calsFromFatAndCarbs";
            this.Text = "Cals from Fat and Carbs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fatTextBox;
        private System.Windows.Forms.TextBox carbsTextBox;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.Label carbsLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label calsLabel;
    }
}

