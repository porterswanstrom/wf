namespace Most_Common_Character
{
    partial class mostCommonCharacter
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
            this.calculateBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.inputTxtBox = new System.Windows.Forms.TextBox();
            this.outputLbl = new System.Windows.Forms.Label();
            this.outputDescLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(119, 110);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(81, 39);
            this.calculateBtn.TabIndex = 3;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(206, 115);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 29);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // inputTxtBox
            // 
            this.inputTxtBox.Location = new System.Drawing.Point(15, 22);
            this.inputTxtBox.Name = "inputTxtBox";
            this.inputTxtBox.Size = new System.Drawing.Size(306, 20);
            this.inputTxtBox.TabIndex = 2;
            this.inputTxtBox.Text = "This is an example sentence.";
            // 
            // outputLbl
            // 
            this.outputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLbl.Location = new System.Drawing.Point(142, 68);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(32, 30);
            this.outputLbl.TabIndex = 1;
            this.outputLbl.Text = "?";
            this.outputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDescLbl
            // 
            this.outputDescLbl.AutoSize = true;
            this.outputDescLbl.Location = new System.Drawing.Point(47, 50);
            this.outputDescLbl.Name = "outputDescLbl";
            this.outputDescLbl.Size = new System.Drawing.Size(234, 13);
            this.outputDescLbl.TabIndex = 0;
            this.outputDescLbl.Text = "The most common character in that sentence is:";
            // 
            // mostCommonCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.outputDescLbl);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.inputTxtBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.calculateBtn);
            this.Name = "mostCommonCharacter";
            this.Text = "Most Common Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox inputTxtBox;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.Label outputDescLbl;
    }
}

