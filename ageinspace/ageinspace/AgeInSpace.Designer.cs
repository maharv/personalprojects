
namespace ageinspace
{
    partial class AgeInSpace
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.userAge = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPlanets = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.planetValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFinalAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userAge)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your age:";
            // 
            // userAge
            // 
            this.userAge.Location = new System.Drawing.Point(317, 41);
            this.userAge.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.userAge.Name = "userAge";
            this.userAge.Size = new System.Drawing.Size(79, 39);
            this.userAge.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(558, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Which planet would you like to know your age on?";
            // 
            // cboPlanets
            // 
            this.cboPlanets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlanets.FormattingEnabled = true;
            this.cboPlanets.Items.AddRange(new object[] {
            "Mercury",
            "Venus",
            "Earth",
            "Mars",
            "Jupiter",
            "Saturn",
            "Uranus",
            "Neptune"});
            this.cboPlanets.Location = new System.Drawing.Point(50, 162);
            this.cboPlanets.Name = "cboPlanets";
            this.cboPlanets.Size = new System.Drawing.Size(242, 40);
            this.cboPlanets.TabIndex = 3;
            this.cboPlanets.SelectedIndexChanged += new System.EventHandler(this.cboPlanets_SelectedIndexChanged);
            this.cboPlanets.SelectionChangeCommitted += new System.EventHandler(this.cboPlanets_SelectionChangeCommitted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Find your age!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your age on";
            // 
            // planetValue
            // 
            this.planetValue.AutoSize = true;
            this.planetValue.Location = new System.Drawing.Point(198, 320);
            this.planetValue.Name = "planetValue";
            this.planetValue.Size = new System.Drawing.Size(25, 32);
            this.planetValue.TabIndex = 6;
            this.planetValue.Text = "?";
            this.planetValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "is:";
            // 
            // lblFinalAge
            // 
            this.lblFinalAge.AutoSize = true;
            this.lblFinalAge.Location = new System.Drawing.Point(338, 320);
            this.lblFinalAge.Name = "lblFinalAge";
            this.lblFinalAge.Size = new System.Drawing.Size(25, 32);
            this.lblFinalAge.TabIndex = 8;
            this.lblFinalAge.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFinalAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.planetValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboPlanets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userAge);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown userAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPlanets;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label planetValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFinalAge;
    }
}

