﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MissionPlanner
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
           

            string strVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            label1.Text = "by Michael Oborne's and\n Bruno Lucas dos Santos";
            TXT_version.Text = "Version: " + Application.ProductVersion + ".1"; // +" Build " + strVersion;

            TXT_version.Size = label1.Size;

            if (Program.Logo != null)
            {
                pictureBox1.BackgroundImage = MissionPlanner.Properties.Resources.bgdark;
                pictureBox1.Image = Program.Logo;
                pictureBox1.Visible = true;
            }
        }
    }
}