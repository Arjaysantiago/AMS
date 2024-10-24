using System.Windows.Forms;

namespace AMSforAKF
{
    partial class MedicineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineForm));
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnsearch = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbServices = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtfrequency = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtdosage = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(783, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Controls*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(54, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Input a new Medicine*";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(45, 387);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 25;
            this.dgv1.Size = new System.Drawing.Size(598, 169);
            this.dgv1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSalmon;
            this.panel3.Controls.Add(this.btnsearch);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtid);
            this.panel3.Controls.Add(this.btndelete);
            this.panel3.Controls.Add(this.btnupdate);
            this.panel3.Location = new System.Drawing.Point(697, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 459);
            this.panel3.TabIndex = 8;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Orange;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnsearch.Location = new System.Drawing.Point(25, 281);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(193, 33);
            this.btnsearch.TabIndex = 10;
            this.btnsearch.Text = "Search Medicine";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AMSforAKF.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(25, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 143);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(30, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "medicine ID*";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtid.Location = new System.Drawing.Point(25, 225);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(193, 31);
            this.txtid.TabIndex = 8;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(25, 404);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(193, 33);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete Medicine";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Turquoise;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnupdate.Location = new System.Drawing.Point(25, 343);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(193, 33);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "Update Medicine";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cmbServices);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtprice);
            this.panel2.Controls.Add(this.txtfrequency);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtdesc);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtdosage);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Location = new System.Drawing.Point(45, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 256);
            this.panel2.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(245, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "What service it is associated?*";
            // 
            // cmbServices
            // 
            this.cmbServices.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cmbServices.FormattingEnabled = true;
            this.cmbServices.Location = new System.Drawing.Point(245, 197);
            this.cmbServices.Name = "cmbServices";
            this.cmbServices.Size = new System.Drawing.Size(173, 28);
            this.cmbServices.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(5, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Price*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(9, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 40);
            this.label8.TabIndex = 10;
            this.label8.Text = "Frequency (How many \r\ntimes a day?)*";
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtprice.Location = new System.Drawing.Point(9, 223);
            this.txtprice.Multiline = true;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(173, 30);
            this.txtprice.TabIndex = 9;
            // 
            // txtfrequency
            // 
            this.txtfrequency.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtfrequency.Location = new System.Drawing.Point(9, 167);
            this.txtfrequency.Multiline = true;
            this.txtfrequency.Name = "txtfrequency";
            this.txtfrequency.Size = new System.Drawing.Size(173, 30);
            this.txtfrequency.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(245, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Description (what was the medicine for?)*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(9, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dosage*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medicine Name*";
            // 
            // txtdesc
            // 
            this.txtdesc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtdesc.Location = new System.Drawing.Point(245, 33);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(323, 135);
            this.txtdesc.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(463, 181);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 33);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Medicine";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtdosage
            // 
            this.txtdosage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtdosage.Location = new System.Drawing.Point(9, 91);
            this.txtdosage.Multiline = true;
            this.txtdosage.Name = "txtdosage";
            this.txtdosage.Size = new System.Drawing.Size(173, 30);
            this.txtdosage.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtname.Location = new System.Drawing.Point(9, 33);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(173, 28);
            this.txtname.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 62);
            this.panel1.TabIndex = 6;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnback.Location = new System.Drawing.Point(883, 22);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(72, 29);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(84, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Management";
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(965, 586);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicineForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private Label label2;
        private DataGridView dgv1;
        private Panel panel3;
        private Button btnsearch;
        private PictureBox pictureBox2;
        private Label label7;
        private TextBox txtid;
        private Button btndelete;
        private Button btnupdate;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtdesc;
        private Button btnAdd;
        private TextBox txtdosage;
        private TextBox txtname;
        private Panel panel1;
        private Button btnback;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label9;
        private Label label8;
        private TextBox txtprice;
        private TextBox txtfrequency;
        private Label label10;
        private ComboBox cmbServices;
    }
}