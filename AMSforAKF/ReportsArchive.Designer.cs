using System.Windows.Forms;
using System.Drawing;

namespace AMSforAKF
{
    partial class ReportsArchive
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
            btnGenerate = new Button();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnBack = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnGenerate);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(975, 67);
            panel1.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = System.Drawing.Color.Yellow;
            btnGenerate.FlatStyle = FlatStyle.Popup;
            btnGenerate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerate.Location = new Point(708, 25);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(144, 30);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate Report";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new Point(69, 18);
            label1.Name = "label1";
            label1.Size = new Size(121, 37);
            label1.TabIndex = 0;
            label1.Text = "Archives";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 67);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(975, 553);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.IndianRed;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(880, 25);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(83, 30);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ReportsArchive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 620);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportsArchive";
            Text = "ReportsArchive";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnGenerate;
        private Button btnBack;
    }
}
