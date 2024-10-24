﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AMSforAKF
{
    partial class VetHome : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // VetHome
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.ButtonShadow;
            this.ClientSize = new Size(975, 620);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "VetHome";
            this.Text = "Veterinarian Home";
            this.ResumeLayout(false);
        }

        #endregion
    }
}