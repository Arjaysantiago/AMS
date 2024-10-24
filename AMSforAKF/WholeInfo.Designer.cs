using System.Drawing;
using System;
using System.Windows.Forms;

namespace AMSforAKF
{
    partial class WholeInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtMedical = new System.Windows.Forms.TextBox();
            this.txtBackground = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.picAnimal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(167, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Animal Profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(33, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Breed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(33, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Species:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(33, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(33, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Age:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(33, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Medical Records:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(33, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Background:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtName.Location = new System.Drawing.Point(105, 42);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(145, 29);
            this.txtName.TabIndex = 8;
            // 
            // txtBreed
            // 
            this.txtBreed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBreed.Location = new System.Drawing.Point(105, 73);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.ReadOnly = true;
            this.txtBreed.Size = new System.Drawing.Size(145, 29);
            this.txtBreed.TabIndex = 9;
            // 
            // txtSpecies
            // 
            this.txtSpecies.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSpecies.Location = new System.Drawing.Point(105, 103);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.ReadOnly = true;
            this.txtSpecies.Size = new System.Drawing.Size(145, 29);
            this.txtSpecies.TabIndex = 10;
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtGender.Location = new System.Drawing.Point(105, 133);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(145, 29);
            this.txtGender.TabIndex = 11;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAge.Location = new System.Drawing.Point(105, 163);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(145, 29);
            this.txtAge.TabIndex = 12;
            // 
            // txtMedical
            // 
            this.txtMedical.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMedical.Location = new System.Drawing.Point(50, 227);
            this.txtMedical.Multiline = true;
            this.txtMedical.Name = "txtMedical";
            this.txtMedical.ReadOnly = true;
            this.txtMedical.Size = new System.Drawing.Size(361, 75);
            this.txtMedical.TabIndex = 13;
            // 
            // txtBackground
            // 
            this.txtBackground.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBackground.Location = new System.Drawing.Point(50, 325);
            this.txtBackground.Multiline = true;
            this.txtBackground.Name = "txtBackground";
            this.txtBackground.ReadOnly = true;
            this.txtBackground.Size = new System.Drawing.Size(361, 97);
            this.txtBackground.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(67, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(327, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "*Note: \"This panel is read only and can\'t edit data\"";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(339, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 27);
            this.button1.TabIndex = 15;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picAnimal
            // 
            this.picAnimal.Location = new System.Drawing.Point(271, 42);
            this.picAnimal.Name = "picAnimal";
            this.picAnimal.Size = new System.Drawing.Size(140, 159);
            this.picAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnimal.TabIndex = 17;
            this.picAnimal.TabStop = false;
            // 
            // WholeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 489);
            this.Controls.Add(this.picAnimal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBackground);
            this.Controls.Add(this.txtMedical);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtSpecies);
            this.Controls.Add(this.txtBreed);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WholeInfo";
            this.Text = "Animal Profile";
            this.Load += new System.EventHandler(this.WholeInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtName;
        private TextBox txtBreed;
        private TextBox textBox3;
        private TextBox txtGender;
        private TextBox txtAge;
        private TextBox txtMedical;
        private TextBox txtBackground;
        private TextBox txtSpecies;
        private Label label9;
        private Button button1;
        private PictureBox picAnimal;
    }
}