using System.Windows.Forms;

namespace AMSforAKF
{
    partial class ReportsModule
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
            this.label1 = new System.Windows.Forms.Label();
            this.Transaction = new System.Windows.Forms.Panel();
            this.Adoption = new System.Windows.Forms.Panel();
            this.TurnedInorRescue = new System.Windows.Forms.Panel();
            this.DatabaseUpdate = new System.Windows.Forms.Panel();
            this.btnRescue = new System.Windows.Forms.Button();
            this.btnTurnIn = new System.Windows.Forms.Button();
            this.btnDatabase = new System.Windows.Forms.Button();
            this.btnAnimalsUpdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdoption = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Transaction.SuspendLayout();
            this.Adoption.SuspendLayout();
            this.TurnedInorRescue.SuspendLayout();
            this.DatabaseUpdate.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 68);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(345, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports Module";
            // 
            // Transaction
            // 
            this.Transaction.Controls.Add(this.btnRescue);
            this.Transaction.Location = new System.Drawing.Point(57, 123);
            this.Transaction.Name = "Transaction";
            this.Transaction.Size = new System.Drawing.Size(179, 238);
            this.Transaction.TabIndex = 1;
            // 
            // Adoption
            // 
            this.Adoption.Controls.Add(this.btnTurnIn);
            this.Adoption.Location = new System.Drawing.Point(271, 123);
            this.Adoption.Name = "Adoption";
            this.Adoption.Size = new System.Drawing.Size(181, 238);
            this.Adoption.TabIndex = 2;
            // 
            // TurnedInorRescue
            // 
            this.TurnedInorRescue.Controls.Add(this.btnDatabase);
            this.TurnedInorRescue.Location = new System.Drawing.Point(484, 123);
            this.TurnedInorRescue.Name = "TurnedInorRescue";
            this.TurnedInorRescue.Size = new System.Drawing.Size(181, 238);
            this.TurnedInorRescue.TabIndex = 2;
            // 
            // DatabaseUpdate
            // 
            this.DatabaseUpdate.Controls.Add(this.btnAnimalsUpdate);
            this.DatabaseUpdate.Location = new System.Drawing.Point(701, 123);
            this.DatabaseUpdate.Name = "DatabaseUpdate";
            this.DatabaseUpdate.Size = new System.Drawing.Size(178, 238);
            this.DatabaseUpdate.TabIndex = 2;
            // 
            // btnRescue
            // 
            this.btnRescue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRescue.Location = new System.Drawing.Point(0, 186);
            this.btnRescue.Name = "btnRescue";
            this.btnRescue.Size = new System.Drawing.Size(179, 52);
            this.btnRescue.TabIndex = 0;
            this.btnRescue.Text = "Rescue";
            this.btnRescue.UseVisualStyleBackColor = true;
            this.btnRescue.Click += new System.EventHandler(this.btnRescue_Click);
            // 
            // btnTurnIn
            // 
            this.btnTurnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnIn.Location = new System.Drawing.Point(0, 186);
            this.btnTurnIn.Name = "btnTurnIn";
            this.btnTurnIn.Size = new System.Drawing.Size(181, 52);
            this.btnTurnIn.TabIndex = 0;
            this.btnTurnIn.Text = "Turned In";
            this.btnTurnIn.UseVisualStyleBackColor = true;
            this.btnTurnIn.Click += new System.EventHandler(this.btnTurnIn_Click);
            // 
            // btnDatabase
            // 
            this.btnDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatabase.Location = new System.Drawing.Point(0, 186);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Size = new System.Drawing.Size(181, 52);
            this.btnDatabase.TabIndex = 0;
            this.btnDatabase.Text = "Database";
            this.btnDatabase.UseVisualStyleBackColor = true;
            this.btnDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // btnAnimalsUpdate
            // 
            this.btnAnimalsUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimalsUpdate.Location = new System.Drawing.Point(0, 186);
            this.btnAnimalsUpdate.Name = "btnAnimalsUpdate";
            this.btnAnimalsUpdate.Size = new System.Drawing.Size(178, 52);
            this.btnAnimalsUpdate.TabIndex = 0;
            this.btnAnimalsUpdate.Text = "Animals Update";
            this.btnAnimalsUpdate.UseVisualStyleBackColor = true;
            this.btnAnimalsUpdate.Click += new System.EventHandler(this.btnAnimalsUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdoption);
            this.panel2.Location = new System.Drawing.Point(203, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 237);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTransaction);
            this.panel3.Location = new System.Drawing.Point(534, 380);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 237);
            this.panel3.TabIndex = 4;
            // 
            // btnAdoption
            // 
            this.btnAdoption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdoption.Location = new System.Drawing.Point(0, 185);
            this.btnAdoption.Name = "btnAdoption";
            this.btnAdoption.Size = new System.Drawing.Size(200, 52);
            this.btnAdoption.TabIndex = 0;
            this.btnAdoption.Text = "Adoption";
            this.btnAdoption.UseVisualStyleBackColor = true;
            this.btnAdoption.Click += new System.EventHandler(this.btnAdoption_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.Location = new System.Drawing.Point(0, 185);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(200, 52);
            this.btnTransaction.TabIndex = 0;
            this.btnTransaction.Text = "Vet Transaction";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // ReportsModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 640);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DatabaseUpdate);
            this.Controls.Add(this.TurnedInorRescue);
            this.Controls.Add(this.Adoption);
            this.Controls.Add(this.Transaction);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportsModule";
            this.Text = "ReportsModule";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Transaction.ResumeLayout(false);
            this.Adoption.ResumeLayout(false);
            this.TurnedInorRescue.ResumeLayout(false);
            this.DatabaseUpdate.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel Transaction;
        private Panel Adoption;
        private Panel TurnedInorRescue;
        private Panel DatabaseUpdate;
        private Button btnRescue;
        private Button btnTurnIn;
        private Button btnDatabase;
        private Button btnAnimalsUpdate;
        private Panel panel2;
        private Button btnAdoption;
        private Panel panel3;
        private Button btnTransaction;
    }
}