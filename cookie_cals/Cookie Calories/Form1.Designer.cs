namespace Cookie_Calories
{
    partial class cookieCalories
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
            this.cookiesTextBox = new System.Windows.Forms.TextBox();
            this.caloriesDescriptionLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.caloriesDescriptionLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(55, 32);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(197, 16);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "How many cookies did you eat?";
            // 
            // cookiesTextBox
            // 
            this.cookiesTextBox.Location = new System.Drawing.Point(108, 51);
            this.cookiesTextBox.Name = "cookiesTextBox";
            this.cookiesTextBox.Size = new System.Drawing.Size(100, 22);
            this.cookiesTextBox.TabIndex = 1;
            // 
            // caloriesDescriptionLabel
            // 
            this.caloriesDescriptionLabel.AutoSize = true;
            this.caloriesDescriptionLabel.Location = new System.Drawing.Point(43, 95);
            this.caloriesDescriptionLabel.Name = "caloriesDescriptionLabel";
            this.caloriesDescriptionLabel.Size = new System.Drawing.Size(76, 16);
            this.caloriesDescriptionLabel.TabIndex = 2;
            this.caloriesDescriptionLabel.Text = "You gained";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caloriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesLabel.Location = new System.Drawing.Point(121, 92);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(83, 23);
            this.caloriesLabel.TabIndex = 3;
            this.caloriesLabel.Text = "?";
            this.caloriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(114, 138);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(86, 46);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate Calories";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(33, 145);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 32);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(206, 145);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 32);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // caloriesDescriptionLabel2
            // 
            this.caloriesDescriptionLabel2.AutoSize = true;
            this.caloriesDescriptionLabel2.Location = new System.Drawing.Point(206, 95);
            this.caloriesDescriptionLabel2.Name = "caloriesDescriptionLabel2";
            this.caloriesDescriptionLabel2.Size = new System.Drawing.Size(58, 16);
            this.caloriesDescriptionLabel2.TabIndex = 4;
            this.caloriesDescriptionLabel2.Text = "calories.";
            // 
            // cookieCalories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 213);
            this.Controls.Add(this.caloriesDescriptionLabel2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.caloriesDescriptionLabel);
            this.Controls.Add(this.cookiesTextBox);
            this.Controls.Add(this.instructionLabel);
            this.Name = "cookieCalories";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.TextBox cookiesTextBox;
        private System.Windows.Forms.Label caloriesDescriptionLabel;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label caloriesDescriptionLabel2;
    }
}

