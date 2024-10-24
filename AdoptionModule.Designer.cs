namespace Animal_Management_System
{
    partial class AdoptionModule
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnChoose = new Button();
            label2 = new Label();
            AnimalsView = new DataGridView();
            label7 = new Label();
            btnBack = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AnimalsView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 61);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(448, 18);
            label1.Name = "label1";
            label1.Size = new Size(240, 32);
            label1.TabIndex = 0;
            label1.Text = "ADOPTION MODULE";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(34, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(515, 308);
            panel2.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(187, 211);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(262, 29);
            txtEmail.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPhone.Location = new Point(187, 158);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(262, 29);
            txtPhone.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtAddress.Location = new Point(187, 107);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(262, 29);
            txtAddress.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(187, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(262, 29);
            txtName.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(129, 214);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 3;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(56, 161);
            label5.Name = "label5";
            label5.Size = new Size(125, 21);
            label5.TabIndex = 2;
            label5.Text = "Phone Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(107, 110);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 1;
            label4.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(124, 56);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 0;
            label3.Text = "Name:";
            // 
            // btnChoose
            // 
            btnChoose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnChoose.Location = new Point(942, 418);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(173, 31);
            btnChoose.TabIndex = 8;
            btnChoose.Text = "Save and Generate";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += btnChoose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 79);
            label2.Name = "label2";
            label2.Size = new Size(178, 25);
            label2.TabIndex = 0;
            label2.Text = "Clients Information";
            // 
            // AnimalsView
            // 
            AnimalsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AnimalsView.Location = new Point(599, 122);
            AnimalsView.Name = "AnimalsView";
            AnimalsView.RowTemplate.Height = 25;
            AnimalsView.Size = new Size(516, 275);
            AnimalsView.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(599, 89);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 3;
            label7.Text = "Animals";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(37, 418);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(84, 31);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AdoptionModule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 700);
            Controls.Add(btnBack);
            Controls.Add(btnChoose);
            Controls.Add(label7);
            Controls.Add(AnimalsView);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdoptionModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdoptionModule";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AnimalsView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox txtName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private DataGridView AnimalsView;
        private Button btnChoose;
        private Label label7;
        private Button btnBack;
    }
}