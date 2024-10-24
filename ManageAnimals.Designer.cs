namespace Animal_Management_System
{
    partial class ManageAnimals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAnimals));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddAnimals = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnimals = new System.Windows.Forms.Button();
            this.btnAdoption = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnMedic = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAnimalIntakeNotification = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIntake = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.btnAddAnimals);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1029, 64);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnAddAnimals
            // 
            this.btnAddAnimals.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAddAnimals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAnimals.Location = new System.Drawing.Point(902, 22);
            this.btnAddAnimals.Name = "btnAddAnimals";
            this.btnAddAnimals.Size = new System.Drawing.Size(99, 32);
            this.btnAddAnimals.TabIndex = 2;
            this.btnAddAnimals.Text = "Add Animals";
            this.btnAddAnimals.UseVisualStyleBackColor = false;
            this.btnAddAnimals.Click += new System.EventHandler(this.btnAddAnimals_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(104, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE ANIMALS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.btnIntake);
            this.panel1.Controls.Add(this.btnAnimals);
            this.panel1.Controls.Add(this.btnAdoption);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnMedic);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 586);
            this.panel1.TabIndex = 2;
            // 
            // btnAnimals
            // 
            this.btnAnimals.BackColor = System.Drawing.Color.Peru;
            this.btnAnimals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnimals.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAnimals.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnimals.Location = new System.Drawing.Point(0, 66);
            this.btnAnimals.Name = "btnAnimals";
            this.btnAnimals.Size = new System.Drawing.Size(189, 55);
            this.btnAnimals.TabIndex = 7;
            this.btnAnimals.Text = "Animals Library";
            this.btnAnimals.UseVisualStyleBackColor = false;
            this.btnAnimals.Click += new System.EventHandler(this.btnAnimals_Click);
            // 
            // btnAdoption
            // 
            this.btnAdoption.BackColor = System.Drawing.Color.Peru;
            this.btnAdoption.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdoption.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAdoption.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdoption.Location = new System.Drawing.Point(0, 260);
            this.btnAdoption.Name = "btnAdoption";
            this.btnAdoption.Size = new System.Drawing.Size(189, 55);
            this.btnAdoption.TabIndex = 6;
            this.btnAdoption.Text = "Adoption";
            this.btnAdoption.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Peru;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(0, 382);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(189, 55);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Peru;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReport.Location = new System.Drawing.Point(0, 321);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(189, 55);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "REPORTS";
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // btnMedic
            // 
            this.btnMedic.BackColor = System.Drawing.Color.Peru;
            this.btnMedic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMedic.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnMedic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMedic.Location = new System.Drawing.Point(0, 127);
            this.btnMedic.Name = "btnMedic";
            this.btnMedic.Size = new System.Drawing.Size(189, 55);
            this.btnMedic.TabIndex = 3;
            this.btnMedic.Text = "MEDICAL ARCHIVE";
            this.btnMedic.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Peru;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "HOME";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Animal_Management_System.Properties.Resources.animals;
            this.pictureBox2.Location = new System.Drawing.Point(252, 458);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(689, 231);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Goldenrod;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(223, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 132);
            this.panel3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 65);
            this.label4.TabIndex = 2;
            this.label4.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(25, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Population of Animals";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Goldenrod;
            this.panel5.Controls.Add(this.lblAnimalIntakeNotification);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(493, 86);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(280, 132);
            this.panel5.TabIndex = 6;
            // 
            // lblAnimalIntakeNotification
            // 
            this.lblAnimalIntakeNotification.AutoSize = true;
            this.lblAnimalIntakeNotification.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimalIntakeNotification.Location = new System.Drawing.Point(17, 62);
            this.lblAnimalIntakeNotification.Name = "lblAnimalIntakeNotification";
            this.lblAnimalIntakeNotification.Size = new System.Drawing.Size(28, 21);
            this.lblAnimalIntakeNotification.TabIndex = 4;
            this.lblAnimalIntakeNotification.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(17, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Animals Intake";
            // 
            // btnIntake
            // 
            this.btnIntake.BackColor = System.Drawing.Color.Peru;
            this.btnIntake.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIntake.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnIntake.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIntake.Location = new System.Drawing.Point(0, 188);
            this.btnIntake.Name = "btnIntake";
            this.btnIntake.Size = new System.Drawing.Size(189, 66);
            this.btnIntake.TabIndex = 8;
            this.btnIntake.Text = "Animals Intake \r\nOverview";
            this.btnIntake.UseVisualStyleBackColor = false;
            this.btnIntake.Click += new System.EventHandler(this.btnIntake_Click);
            // 
            // ManageAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1029, 650);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageAnimals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAnimals";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnReport;
        private Button btnMedic;
        private Button btnLogout;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel5;
        private Label label2;
        private Label label4;
        private Label lblAnimalIntakeNotification;
        private Label label6;
        private Button btnAddAnimals;
        private Button btnAdoption;
        private Button btnAnimals;
        private Button btnIntake;
    }
}