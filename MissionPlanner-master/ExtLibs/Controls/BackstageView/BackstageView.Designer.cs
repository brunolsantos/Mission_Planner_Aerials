namespace MissionPlanner.Controls.BackstageView
{
    partial class BackstageView
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
            this.pnlPages = new System.Windows.Forms.Panel();
            //this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flightPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu = new MissionPlanner.Controls.BackstageView.BackStageViewMenuPanel();
            //this.menuStrip1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPages
            // 
            this.pnlPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPages.AutoScroll = true;
            this.pnlPages.Location = new System.Drawing.Point(203, 0);
            this.pnlPages.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPages.MinimumSize = new System.Drawing.Size(133, 0);
            this.pnlPages.Name = "pnlPages";
            this.pnlPages.Size = new System.Drawing.Size(450, 422);
            this.pnlPages.TabIndex = 0;
            // 
            // menuStrip1
            // 
            //this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            //this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            //this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            //this.flightPlanToolStripMenuItem});
            //this.menuStrip1.Location = new System.Drawing.Point(0, 364);
            //this.menuStrip1.Name = "menuStrip1";
            //this.menuStrip1.Size = new System.Drawing.Size(59, 58);
            //this.menuStrip1.TabIndex = 0;
            //this.menuStrip1.Text = "menuStrip1";
            //this.menuStrip1.Visible = false;
            // 
            // flightPlanToolStripMenuItem
            // 
            this.flightPlanToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.flightPlanToolStripMenuItem.Image = global::MissionPlanner.Controls.Properties.Resources.flight_data;
            this.flightPlanToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.flightPlanToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.flightPlanToolStripMenuItem.Name = "flightPlanToolStripMenuItem";
            this.flightPlanToolStripMenuItem.Size = new System.Drawing.Size(51, 54);
            this.flightPlanToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.flightPlanToolStripMenuItem.Click += new System.EventHandler(this.flightPlanToolStripMenuItem_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            //this.pnlMenu.Controls.Add(this.menuStrip1);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(203, 422);
            this.pnlMenu.TabIndex = 1;
            // 
            // BackstageView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlPages);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BackstageView";
            this.Size = new System.Drawing.Size(657, 422);
            this.Load += new System.EventHandler(this.BackstageView_Load);
            //this.menuStrip1.ResumeLayout(false);
            //this.menuStrip1.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPages;
        private BackStageViewMenuPanel pnlMenu;
        //private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem flightPlanToolStripMenuItem;
    }
}
