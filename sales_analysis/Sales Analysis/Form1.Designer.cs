namespace Sales_Analysis
{
    partial class salesAnalysis
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
            this.salesListBox = new System.Windows.Forms.ListBox();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalDescriptionlabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.averageDescriptionLabel = new System.Windows.Forms.Label();
            this.largestLabel = new System.Windows.Forms.Label();
            this.largestDescriptionLabel = new System.Windows.Forms.Label();
            this.smallestLabel = new System.Windows.Forms.Label();
            this.smallestDescriptionLabel = new System.Windows.Forms.Label();
            this.salesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salesListBox
            // 
            this.salesListBox.FormattingEnabled = true;
            this.salesListBox.ItemHeight = 16;
            this.salesListBox.Location = new System.Drawing.Point(51, 43);
            this.salesListBox.Name = "salesListBox";
            this.salesListBox.Size = new System.Drawing.Size(99, 164);
            this.salesListBox.TabIndex = 1;
            // 
            // analyzeButton
            // 
            this.analyzeButton.Location = new System.Drawing.Point(154, 230);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(83, 48);
            this.analyzeButton.TabIndex = 10;
            this.analyzeButton.Text = "Analyze Sales";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(73, 239);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 31);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(243, 239);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 31);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalDescriptionlabel
            // 
            this.totalDescriptionlabel.AutoSize = true;
            this.totalDescriptionlabel.Location = new System.Drawing.Point(185, 54);
            this.totalDescriptionlabel.Name = "totalDescriptionlabel";
            this.totalDescriptionlabel.Size = new System.Drawing.Size(41, 16);
            this.totalDescriptionlabel.TabIndex = 2;
            this.totalDescriptionlabel.Text = "Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(232, 48);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(115, 27);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "?";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageLabel.Location = new System.Drawing.Point(232, 87);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(115, 27);
            this.averageLabel.TabIndex = 5;
            this.averageLabel.Text = "?";
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageDescriptionLabel
            // 
            this.averageDescriptionLabel.AutoSize = true;
            this.averageDescriptionLabel.Location = new System.Drawing.Point(164, 93);
            this.averageDescriptionLabel.Name = "averageDescriptionLabel";
            this.averageDescriptionLabel.Size = new System.Drawing.Size(62, 16);
            this.averageDescriptionLabel.TabIndex = 4;
            this.averageDescriptionLabel.Text = "Average:";
            // 
            // largestLabel
            // 
            this.largestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.largestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largestLabel.Location = new System.Drawing.Point(232, 127);
            this.largestLabel.Name = "largestLabel";
            this.largestLabel.Size = new System.Drawing.Size(115, 27);
            this.largestLabel.TabIndex = 7;
            this.largestLabel.Text = "?";
            this.largestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // largestDescriptionLabel
            // 
            this.largestDescriptionLabel.AutoSize = true;
            this.largestDescriptionLabel.Location = new System.Drawing.Point(171, 133);
            this.largestDescriptionLabel.Name = "largestDescriptionLabel";
            this.largestDescriptionLabel.Size = new System.Drawing.Size(55, 16);
            this.largestDescriptionLabel.TabIndex = 6;
            this.largestDescriptionLabel.Text = "Largest:";
            // 
            // smallestLabel
            // 
            this.smallestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smallestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallestLabel.Location = new System.Drawing.Point(232, 167);
            this.smallestLabel.Name = "smallestLabel";
            this.smallestLabel.Size = new System.Drawing.Size(115, 27);
            this.smallestLabel.TabIndex = 9;
            this.smallestLabel.Text = "?";
            this.smallestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // smallestDescriptionLabel
            // 
            this.smallestDescriptionLabel.AutoSize = true;
            this.smallestDescriptionLabel.Location = new System.Drawing.Point(164, 173);
            this.smallestDescriptionLabel.Name = "smallestDescriptionLabel";
            this.smallestDescriptionLabel.Size = new System.Drawing.Size(62, 16);
            this.smallestDescriptionLabel.TabIndex = 8;
            this.smallestDescriptionLabel.Text = "Smallest:";
            // 
            // salesLabel
            // 
            this.salesLabel.AutoSize = true;
            this.salesLabel.Location = new System.Drawing.Point(70, 24);
            this.salesLabel.Name = "salesLabel";
            this.salesLabel.Size = new System.Drawing.Size(45, 16);
            this.salesLabel.TabIndex = 0;
            this.salesLabel.Text = "Sales:";
            // 
            // salesAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 313);
            this.Controls.Add(this.salesLabel);
            this.Controls.Add(this.smallestLabel);
            this.Controls.Add(this.smallestDescriptionLabel);
            this.Controls.Add(this.largestLabel);
            this.Controls.Add(this.largestDescriptionLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.averageDescriptionLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.analyzeButton);
            this.Controls.Add(this.totalDescriptionlabel);
            this.Controls.Add(this.salesListBox);
            this.Name = "salesAnalysis";
            this.Text = "Sales Analysis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox salesListBox;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalDescriptionlabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label averageDescriptionLabel;
        private System.Windows.Forms.Label largestLabel;
        private System.Windows.Forms.Label largestDescriptionLabel;
        private System.Windows.Forms.Label smallestLabel;
        private System.Windows.Forms.Label smallestDescriptionLabel;
        private System.Windows.Forms.Label salesLabel;
    }
}

