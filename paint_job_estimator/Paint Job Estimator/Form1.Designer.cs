namespace Paint_Job_Estimator
{
    partial class paintJobEstimator
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
            this.wallSpaceLabel = new System.Windows.Forms.Label();
            this.wallSpaceTextBox = new System.Windows.Forms.TextBox();
            this.gallonCostLabel = new System.Windows.Forms.Label();
            this.gallonCostTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.EstimateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.gallonsDescriptionLabel = new System.Windows.Forms.Label();
            this.gallonsLabel = new System.Windows.Forms.Label();
            this.laborLabel = new System.Windows.Forms.Label();
            this.laborDescriptionLabel = new System.Windows.Forms.Label();
            this.paintCostLabel = new System.Windows.Forms.Label();
            this.paintCostDescriptionLabel = new System.Windows.Forms.Label();
            this.laborCostLabel = new System.Windows.Forms.Label();
            this.laborCostDescriptionLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalCostDescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wallSpaceLabel
            // 
            this.wallSpaceLabel.AutoSize = true;
            this.wallSpaceLabel.Location = new System.Drawing.Point(44, 26);
            this.wallSpaceLabel.Name = "wallSpaceLabel";
            this.wallSpaceLabel.Size = new System.Drawing.Size(315, 16);
            this.wallSpaceLabel.TabIndex = 0;
            this.wallSpaceLabel.Text = "Enter the the square feet of wall space to be painted:";
            // 
            // wallSpaceTextBox
            // 
            this.wallSpaceTextBox.Location = new System.Drawing.Point(157, 45);
            this.wallSpaceTextBox.MaxLength = 8;
            this.wallSpaceTextBox.Name = "wallSpaceTextBox";
            this.wallSpaceTextBox.Size = new System.Drawing.Size(100, 22);
            this.wallSpaceTextBox.TabIndex = 1;
            // 
            // gallonCostLabel
            // 
            this.gallonCostLabel.AutoSize = true;
            this.gallonCostLabel.Location = new System.Drawing.Point(107, 76);
            this.gallonCostLabel.Name = "gallonCostLabel";
            this.gallonCostLabel.Size = new System.Drawing.Size(206, 16);
            this.gallonCostLabel.TabIndex = 2;
            this.gallonCostLabel.Text = "Enter the price of a gallon of paint:";
            // 
            // gallonCostTextBox
            // 
            this.gallonCostTextBox.Location = new System.Drawing.Point(157, 95);
            this.gallonCostTextBox.MaxLength = 8;
            this.gallonCostTextBox.Name = "gallonCostTextBox";
            this.gallonCostTextBox.Size = new System.Drawing.Size(100, 22);
            this.gallonCostTextBox.TabIndex = 3;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(89, 296);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 31);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // EstimateButton
            // 
            this.EstimateButton.Location = new System.Drawing.Point(170, 292);
            this.EstimateButton.Name = "EstimateButton";
            this.EstimateButton.Size = new System.Drawing.Size(75, 39);
            this.EstimateButton.TabIndex = 14;
            this.EstimateButton.Text = "Estimate";
            this.EstimateButton.UseVisualStyleBackColor = true;
            this.EstimateButton.Click += new System.EventHandler(this.EstimateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(251, 296);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 31);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // gallonsDescriptionLabel
            // 
            this.gallonsDescriptionLabel.AutoSize = true;
            this.gallonsDescriptionLabel.Location = new System.Drawing.Point(58, 135);
            this.gallonsDescriptionLabel.Name = "gallonsDescriptionLabel";
            this.gallonsDescriptionLabel.Size = new System.Drawing.Size(155, 16);
            this.gallonsDescriptionLabel.TabIndex = 4;
            this.gallonsDescriptionLabel.Text = "Gallons of paint required:";
            // 
            // gallonsLabel
            // 
            this.gallonsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gallonsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gallonsLabel.Location = new System.Drawing.Point(219, 131);
            this.gallonsLabel.Name = "gallonsLabel";
            this.gallonsLabel.Size = new System.Drawing.Size(122, 23);
            this.gallonsLabel.TabIndex = 5;
            this.gallonsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laborLabel
            // 
            this.laborLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborLabel.Location = new System.Drawing.Point(219, 194);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(122, 23);
            this.laborLabel.TabIndex = 9;
            this.laborLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laborDescriptionLabel
            // 
            this.laborDescriptionLabel.AutoSize = true;
            this.laborDescriptionLabel.Location = new System.Drawing.Point(66, 194);
            this.laborDescriptionLabel.Name = "laborDescriptionLabel";
            this.laborDescriptionLabel.Size = new System.Drawing.Size(147, 16);
            this.laborDescriptionLabel.TabIndex = 8;
            this.laborDescriptionLabel.Text = "Hours of labor required:";
            // 
            // paintCostLabel
            // 
            this.paintCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paintCostLabel.Location = new System.Drawing.Point(219, 163);
            this.paintCostLabel.Name = "paintCostLabel";
            this.paintCostLabel.Size = new System.Drawing.Size(122, 23);
            this.paintCostLabel.TabIndex = 7;
            this.paintCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paintCostDescriptionLabel
            // 
            this.paintCostDescriptionLabel.AutoSize = true;
            this.paintCostDescriptionLabel.Location = new System.Drawing.Point(107, 163);
            this.paintCostDescriptionLabel.Name = "paintCostDescriptionLabel";
            this.paintCostDescriptionLabel.Size = new System.Drawing.Size(104, 16);
            this.paintCostDescriptionLabel.TabIndex = 6;
            this.paintCostDescriptionLabel.Text = "Cost of the paint:";
            // 
            // laborCostLabel
            // 
            this.laborCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborCostLabel.Location = new System.Drawing.Point(219, 224);
            this.laborCostLabel.Name = "laborCostLabel";
            this.laborCostLabel.Size = new System.Drawing.Size(122, 23);
            this.laborCostLabel.TabIndex = 11;
            this.laborCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laborCostDescriptionLabel
            // 
            this.laborCostDescriptionLabel.AutoSize = true;
            this.laborCostDescriptionLabel.Location = new System.Drawing.Point(107, 228);
            this.laborCostDescriptionLabel.Name = "laborCostDescriptionLabel";
            this.laborCostDescriptionLabel.Size = new System.Drawing.Size(106, 16);
            this.laborCostDescriptionLabel.TabIndex = 10;
            this.laborCostDescriptionLabel.Text = "Cost of the labor:";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.Location = new System.Drawing.Point(219, 256);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(122, 23);
            this.totalCostLabel.TabIndex = 13;
            this.totalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCostDescriptionLabel
            // 
            this.totalCostDescriptionLabel.AutoSize = true;
            this.totalCostDescriptionLabel.Location = new System.Drawing.Point(144, 260);
            this.totalCostDescriptionLabel.Name = "totalCostDescriptionLabel";
            this.totalCostDescriptionLabel.Size = new System.Drawing.Size(69, 16);
            this.totalCostDescriptionLabel.TabIndex = 12;
            this.totalCostDescriptionLabel.Text = "Total cost:";
            // 
            // paintJobEstimator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 353);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.totalCostDescriptionLabel);
            this.Controls.Add(this.laborCostLabel);
            this.Controls.Add(this.laborCostDescriptionLabel);
            this.Controls.Add(this.paintCostLabel);
            this.Controls.Add(this.paintCostDescriptionLabel);
            this.Controls.Add(this.laborLabel);
            this.Controls.Add(this.laborDescriptionLabel);
            this.Controls.Add(this.gallonsLabel);
            this.Controls.Add(this.gallonsDescriptionLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.EstimateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.gallonCostTextBox);
            this.Controls.Add(this.gallonCostLabel);
            this.Controls.Add(this.wallSpaceTextBox);
            this.Controls.Add(this.wallSpaceLabel);
            this.Name = "paintJobEstimator";
            this.Text = "Paint Job Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wallSpaceLabel;
        private System.Windows.Forms.TextBox wallSpaceTextBox;
        private System.Windows.Forms.Label gallonCostLabel;
        private System.Windows.Forms.TextBox gallonCostTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button EstimateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label gallonsDescriptionLabel;
        private System.Windows.Forms.Label gallonsLabel;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.Label laborDescriptionLabel;
        private System.Windows.Forms.Label paintCostLabel;
        private System.Windows.Forms.Label paintCostDescriptionLabel;
        private System.Windows.Forms.Label laborCostLabel;
        private System.Windows.Forms.Label laborCostDescriptionLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label totalCostDescriptionLabel;
    }
}

