namespace Joke_and_Punch_Line
{
    partial class jokeAndPunchLine
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
            this.jokeLabel = new System.Windows.Forms.Label();
            this.setupButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.punchLineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(58, 38);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(194, 16);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Click the buttons to show a joke.";
            // 
            // jokeLabel
            // 
            this.jokeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jokeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jokeLabel.Location = new System.Drawing.Point(63, 64);
            this.jokeLabel.Name = "jokeLabel";
            this.jokeLabel.Size = new System.Drawing.Size(191, 45);
            this.jokeLabel.TabIndex = 1;
            this.jokeLabel.Text = "?";
            this.jokeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setupButton
            // 
            this.setupButton.Location = new System.Drawing.Point(114, 119);
            this.setupButton.Name = "setupButton";
            this.setupButton.Size = new System.Drawing.Size(90, 46);
            this.setupButton.TabIndex = 2;
            this.setupButton.Text = "Setup";
            this.setupButton.UseVisualStyleBackColor = true;
            this.setupButton.Click += new System.EventHandler(this.setupButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(33, 129);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 27);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(210, 129);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 27);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // punchLineButton
            // 
            this.punchLineButton.Location = new System.Drawing.Point(114, 119);
            this.punchLineButton.Name = "punchLineButton";
            this.punchLineButton.Size = new System.Drawing.Size(90, 46);
            this.punchLineButton.TabIndex = 3;
            this.punchLineButton.Text = "Punch Line";
            this.punchLineButton.UseVisualStyleBackColor = true;
            this.punchLineButton.Visible = false;
            this.punchLineButton.Click += new System.EventHandler(this.punchLineButton_Click);
            // 
            // jokeAndPunchLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 193);
            this.Controls.Add(this.punchLineButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.setupButton);
            this.Controls.Add(this.jokeLabel);
            this.Controls.Add(this.instructionLabel);
            this.Name = "jokeAndPunchLine";
            this.Text = "Joke and Punch Line";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label jokeLabel;
        private System.Windows.Forms.Button setupButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button punchLineButton;
    }
}

