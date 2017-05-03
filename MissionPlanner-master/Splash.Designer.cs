﻿namespace MissionPlanner
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.transparent_Panel1 = new MissionPlanner.Controls.TransparentPanel.Transparent_Panel();
            this.TXT_version = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.transparent_Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // transparent_Panel1
            // 
            this.transparent_Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(113)))), ((int)(((byte)(159)))));
            this.transparent_Panel1.Controls.Add(this.TXT_version);
            this.transparent_Panel1.Controls.Add(this.label1);
            this.transparent_Panel1.Location = new System.Drawing.Point(410, 255);
            this.transparent_Panel1.Name = "transparent_Panel1";
            this.transparent_Panel1.Size = new System.Drawing.Size(166, 75);
            this.transparent_Panel1.TabIndex = 4;
            // 
            // TXT_version
            // 
            this.TXT_version.BackColor = System.Drawing.Color.Transparent;
            this.TXT_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_version.ForeColor = System.Drawing.Color.White;
            this.TXT_version.Location = new System.Drawing.Point(10, 14);
            this.TXT_version.Name = "TXT_version";
            this.TXT_version.Size = new System.Drawing.Size(145, 25);
            this.TXT_version.TabIndex = 1;
            this.TXT_version.Text = "Version: ";
            this.TXT_version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "by Michael Oborne and\r\nBruno Lucas dos Santos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Splash
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::MissionPlanner.Properties.Resources.splash_new;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 336);
            this.ControlBox = false;
            this.Controls.Add(this.transparent_Panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 375);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 375);
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mission Planner";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.transparent_Panel1.ResumeLayout(false);
            this.transparent_Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TXT_version;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.TransparentPanel.Transparent_Panel transparent_Panel1;
    }
}