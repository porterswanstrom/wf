namespace Pet_Info
{
    partial class petInfo
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
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.typeTxtBox = new System.Windows.Forms.TextBox();
            this.ageTxtBox = new System.Windows.Forms.TextBox();
            this.helpLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.outputLbl = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(12, 68);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.nameTxtBox.TabIndex = 0;
            this.nameTxtBox.Text = "Clark";
            // 
            // typeTxtBox
            // 
            this.typeTxtBox.Location = new System.Drawing.Point(118, 68);
            this.typeTxtBox.Name = "typeTxtBox";
            this.typeTxtBox.Size = new System.Drawing.Size(100, 20);
            this.typeTxtBox.TabIndex = 1;
            this.typeTxtBox.Text = "ferret";
            // 
            // ageTxtBox
            // 
            this.ageTxtBox.Location = new System.Drawing.Point(224, 68);
            this.ageTxtBox.Name = "ageTxtBox";
            this.ageTxtBox.Size = new System.Drawing.Size(100, 20);
            this.ageTxtBox.TabIndex = 2;
            this.ageTxtBox.Text = "3";
            // 
            // helpLbl
            // 
            this.helpLbl.AutoSize = true;
            this.helpLbl.Location = new System.Drawing.Point(70, 27);
            this.helpLbl.Name = "helpLbl";
            this.helpLbl.Size = new System.Drawing.Size(208, 13);
            this.helpLbl.TabIndex = 3;
            this.helpLbl.Text = "Please enter some information about a pet.";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(43, 52);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(38, 13);
            this.nameLbl.TabIndex = 4;
            this.nameLbl.Text = "Name:";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(151, 52);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(34, 13);
            this.typeLbl.TabIndex = 5;
            this.typeLbl.Text = "Type:";
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(262, 52);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(29, 13);
            this.ageLbl.TabIndex = 6;
            this.ageLbl.Text = "Age:";
            // 
            // outputLbl
            // 
            this.outputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLbl.Location = new System.Drawing.Point(39, 101);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(252, 28);
            this.outputLbl.TabIndex = 7;
            this.outputLbl.Text = "? is a ? year old ?.";
            this.outputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(128, 145);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(78, 35);
            this.calculateBtn.TabIndex = 8;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(47, 149);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 27);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(212, 149);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 27);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // petInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.helpLbl);
            this.Controls.Add(this.ageTxtBox);
            this.Controls.Add(this.typeTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Name = "petInfo";
            this.Text = "Pet Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox typeTxtBox;
        private System.Windows.Forms.TextBox ageTxtBox;
        private System.Windows.Forms.Label helpLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

