using System.Windows.Forms;

namespace AMSforAKF
{
    partial class WelcomeAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNotif = new System.Windows.Forms.Label();
            this.panelpopulation = new System.Windows.Forms.Panel();
            this.btnAnimals = new System.Windows.Forms.Button();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.btnGoToAccounts = new System.Windows.Forms.Button();
            this.lblChangePass = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelchangepass = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGoToOverview = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAnimalIntakeNotification = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelpopulation.SuspendLayout();
            this.panelUsers.SuspendLayout();
            this.panelchangepass.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 71);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 48F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, -7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(485, 90);
            this.label5.TabIndex = 0;
            this.label5.Text = "DASHBOARD";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(204)))), ((int)(((byte)(111)))));
            this.panel2.Controls.Add(this.btnReports);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(23, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 139);
            this.panel2.TabIndex = 3;
            // 
            // btnReports
            // 
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(0, 99);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(255, 40);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Go to reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 26.25F);
            this.label11.Location = new System.Drawing.Point(166, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 47);
            this.label11.TabIndex = 2;
            this.label11.Text = "000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "******";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Notification:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "No notifications at the moment*";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(0, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Move to Report ----->";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notifications:";
            // 
            // lblNotif
            // 
            this.lblNotif.AutoSize = true;
            this.lblNotif.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.lblNotif.Location = new System.Drawing.Point(211, 26);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(47, 37);
            this.lblNotif.TabIndex = 0;
            this.lblNotif.Text = "00";
            // 
            // panelpopulation
            // 
            this.panelpopulation.BackColor = System.Drawing.Color.DarkOrange;
            this.panelpopulation.Controls.Add(this.btnAnimals);
            this.panelpopulation.Controls.Add(this.lblPopulation);
            this.panelpopulation.Controls.Add(this.label3);
            this.panelpopulation.Location = new System.Drawing.Point(308, 89);
            this.panelpopulation.Name = "panelpopulation";
            this.panelpopulation.Size = new System.Drawing.Size(266, 139);
            this.panelpopulation.TabIndex = 4;
            // 
            // btnAnimals
            // 
            this.btnAnimals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimals.Location = new System.Drawing.Point(0, 101);
            this.btnAnimals.Name = "btnAnimals";
            this.btnAnimals.Size = new System.Drawing.Size(266, 38);
            this.btnAnimals.TabIndex = 2;
            this.btnAnimals.Text = "Go to Archive";
            this.btnAnimals.UseVisualStyleBackColor = true;
            this.btnAnimals.Click += new System.EventHandler(this.btnAnimals_Click);
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopulation.Location = new System.Drawing.Point(174, 37);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(80, 55);
            this.lblPopulation.TabIndex = 1;
            this.lblPopulation.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkOrange;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Population of \r\nAnimals\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelUsers
            // 
            this.panelUsers.BackColor = System.Drawing.Color.Cyan;
            this.panelUsers.Controls.Add(this.btnGoToAccounts);
            this.panelUsers.Controls.Add(this.lblChangePass);
            this.panelUsers.Controls.Add(this.label7);
            this.panelUsers.Location = new System.Drawing.Point(23, 251);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(255, 139);
            this.panelUsers.TabIndex = 5;
            // 
            // btnGoToAccounts
            // 
            this.btnGoToAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoToAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToAccounts.Location = new System.Drawing.Point(0, 101);
            this.btnGoToAccounts.Name = "btnGoToAccounts";
            this.btnGoToAccounts.Size = new System.Drawing.Size(255, 38);
            this.btnGoToAccounts.TabIndex = 4;
            this.btnGoToAccounts.Text = "Go to Accounts";
            this.btnGoToAccounts.UseVisualStyleBackColor = true;
            this.btnGoToAccounts.Click += new System.EventHandler(this.btnGoToAccounts_Click);
            // 
            // lblChangePass
            // 
            this.lblChangePass.AutoSize = true;
            this.lblChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePass.Location = new System.Drawing.Point(181, 35);
            this.lblChangePass.Name = "lblChangePass";
            this.lblChangePass.Size = new System.Drawing.Size(62, 42);
            this.lblChangePass.TabIndex = 3;
            this.lblChangePass.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 40);
            this.label7.TabIndex = 3;
            this.label7.Text = "Change Password\r\nUser\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelchangepass
            // 
            this.panelchangepass.BackColor = System.Drawing.Color.LightGreen;
            this.panelchangepass.Controls.Add(this.label4);
            this.panelchangepass.Controls.Add(this.lblTotalUsers);
            this.panelchangepass.Location = new System.Drawing.Point(602, 89);
            this.panelchangepass.Name = "panelchangepass";
            this.panelchangepass.Size = new System.Drawing.Size(218, 139);
            this.panelchangepass.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Users:";
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsers.Location = new System.Drawing.Point(89, 51);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(80, 55);
            this.lblTotalUsers.TabIndex = 2;
            this.lblTotalUsers.Text = "00";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.Controls.Add(this.lblAnimalIntakeNotification);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnGoToOverview);
            this.panel3.Location = new System.Drawing.Point(308, 251);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 139);
            this.panel3.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(602, 251);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 139);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // btnGoToOverview
            // 
            this.btnGoToOverview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoToOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToOverview.Location = new System.Drawing.Point(0, 101);
            this.btnGoToOverview.Name = "btnGoToOverview";
            this.btnGoToOverview.Size = new System.Drawing.Size(266, 38);
            this.btnGoToOverview.TabIndex = 0;
            this.btnGoToOverview.Text = "Go To Overview";
            this.btnGoToOverview.UseVisualStyleBackColor = true;
            this.btnGoToOverview.Click += new System.EventHandler(this.btnGoToOverview_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 40);
            this.label6.TabIndex = 5;
            this.label6.Text = "Animals Intake Overview\r\n\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnimalIntakeNotification
            // 
            this.lblAnimalIntakeNotification.AutoSize = true;
            this.lblAnimalIntakeNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimalIntakeNotification.Location = new System.Drawing.Point(13, 49);
            this.lblAnimalIntakeNotification.Name = "lblAnimalIntakeNotification";
            this.lblAnimalIntakeNotification.Size = new System.Drawing.Size(79, 20);
            this.lblAnimalIntakeNotification.TabIndex = 6;
            this.lblAnimalIntakeNotification.Text = "**********";
            // 
            // WelcomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(925, 640);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelchangepass);
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.panelpopulation);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WelcomeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.WelcomeAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelpopulation.ResumeLayout(false);
            this.panelpopulation.PerformLayout();
            this.panelUsers.ResumeLayout(false);
            this.panelUsers.PerformLayout();
            this.panelchangepass.ResumeLayout(false);
            this.panelchangepass.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private Label lblNotif;
        private Label label2;
        private Label label5;
        private Button btnReports;
        private Label label11;
        private Label label10;
        private Label label9;
        private Panel panelpopulation;
        private Label label3;
        private Panel panelUsers;
        private Panel panelchangepass;
        private Button btnAnimals;
        private Label lblPopulation;
        private Label lblChangePass;
        private Label label7;
        private Label label4;
        private Label lblTotalUsers;
        private Button btnGoToAccounts;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblAnimalIntakeNotification;
        private Label label6;
        private Button btnGoToOverview;
    }
}