﻿namespace ControlWindows
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(88, 151);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(212, 31);
            this.textBox.TabIndex = 0;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(124, 188);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(142, 37);
            this.button.TabIndex = 1;
            this.button.Text = "Oprimeme";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // UserControl1
            // 
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(400, 400);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button;
    }
}
