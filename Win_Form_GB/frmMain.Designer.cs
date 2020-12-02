namespace Win_Form_GB
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Screening");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Follow Up");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Forms", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dualEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userPermissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.naviBar1 = new Guifreaks.NavigationBar.NaviBar(this.components);
            this.naviBand6 = new Guifreaks.NavigationBar.NaviBand(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.naviBand1 = new Guifreaks.NavigationBar.NaviBand(this.components);
            this.naviBand3 = new Guifreaks.NavigationBar.NaviBand(this.components);
            this.naviBand5 = new Guifreaks.NavigationBar.NaviBand(this.components);
            this.naviBand2 = new Guifreaks.NavigationBar.NaviBand(this.components);
            this.naviBand4 = new Guifreaks.NavigationBar.NaviBand(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.naviBar1)).BeginInit();
            this.naviBar1.SuspendLayout();
            this.naviBand6.ClientArea.SuspendLayout();
            this.naviBand6.SuspendLayout();
            this.naviBand1.SuspendLayout();
            this.naviBand3.SuspendLayout();
            this.naviBand5.SuspendLayout();
            this.naviBand2.SuspendLayout();
            this.naviBand4.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1031);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1916, 22);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataCorrectionToolStripMenuItem,
            this.adminPanelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1916, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataCorrectionToolStripMenuItem
            // 
            this.dataCorrectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dualEntryToolStripMenuItem,
            this.errorCheckToolStripMenuItem,
            this.entryStatusToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.dataCorrectionToolStripMenuItem.Name = "dataCorrectionToolStripMenuItem";
            this.dataCorrectionToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.dataCorrectionToolStripMenuItem.Text = "Data Correction";
            // 
            // dualEntryToolStripMenuItem
            // 
            this.dualEntryToolStripMenuItem.Name = "dualEntryToolStripMenuItem";
            this.dualEntryToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.dualEntryToolStripMenuItem.Text = "Dual Entry";
            // 
            // errorCheckToolStripMenuItem
            // 
            this.errorCheckToolStripMenuItem.Name = "errorCheckToolStripMenuItem";
            this.errorCheckToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.errorCheckToolStripMenuItem.Text = "Error Check";
            // 
            // entryStatusToolStripMenuItem
            // 
            this.entryStatusToolStripMenuItem.Name = "entryStatusToolStripMenuItem";
            this.entryStatusToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.entryStatusToolStripMenuItem.Text = "Entry Status";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // adminPanelToolStripMenuItem
            // 
            this.adminPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userPermissionsToolStripMenuItem,
            this.createDictionaryToolStripMenuItem,
            this.exportDataToolStripMenuItem});
            this.adminPanelToolStripMenuItem.Name = "adminPanelToolStripMenuItem";
            this.adminPanelToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.adminPanelToolStripMenuItem.Text = "Admin Panel";
            // 
            // userPermissionsToolStripMenuItem
            // 
            this.userPermissionsToolStripMenuItem.Name = "userPermissionsToolStripMenuItem";
            this.userPermissionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userPermissionsToolStripMenuItem.Text = "User Permissions";
            this.userPermissionsToolStripMenuItem.Click += new System.EventHandler(this.userPermissionsToolStripMenuItem_Click);
            // 
            // createDictionaryToolStripMenuItem
            // 
            this.createDictionaryToolStripMenuItem.Name = "createDictionaryToolStripMenuItem";
            this.createDictionaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createDictionaryToolStripMenuItem.Text = "Create Dictionary";
            // 
            // exportDataToolStripMenuItem
            // 
            this.exportDataToolStripMenuItem.Name = "exportDataToolStripMenuItem";
            this.exportDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportDataToolStripMenuItem.Text = "Export Data";
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            // 
            // timer2
            // 
            this.timer2.Interval = 6000;
            // 
            // naviBar1
            // 
            this.naviBar1.ActiveBand = this.naviBand6;
            this.naviBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviBar1.BackgroundImage")));
            this.naviBar1.Controls.Add(this.naviBand6);
            this.naviBar1.Controls.Add(this.naviBand1);
            this.naviBar1.Controls.Add(this.naviBand3);
            this.naviBar1.Controls.Add(this.naviBand5);
            this.naviBar1.Controls.Add(this.naviBand2);
            this.naviBar1.Controls.Add(this.naviBand4);
            this.naviBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.naviBar1.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Silver;
            this.naviBar1.Location = new System.Drawing.Point(0, 24);
            this.naviBar1.Name = "naviBar1";
            this.naviBar1.Size = new System.Drawing.Size(256, 1007);
            this.naviBar1.TabIndex = 29;
            this.naviBar1.Text = "naviBar1";
            this.naviBar1.VisibleLargeButtons = 6;
            // 
            // naviBand6
            // 
            // 
            // naviBand6.ClientArea
            // 
            this.naviBand6.ClientArea.Controls.Add(this.treeView1);
            this.naviBand6.ClientArea.Location = new System.Drawing.Point(0, 0);
            this.naviBand6.ClientArea.Name = "ClientArea";
            this.naviBand6.ClientArea.Size = new System.Drawing.Size(254, 748);
            this.naviBand6.ClientArea.TabIndex = 0;
            this.naviBand6.LargeImage = ((System.Drawing.Image)(resources.GetObject("naviBand6.LargeImage")));
            this.naviBand6.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Silver;
            this.naviBand6.Location = new System.Drawing.Point(1, 27);
            this.naviBand6.Name = "naviBand6";
            this.naviBand6.Size = new System.Drawing.Size(254, 748);
            this.naviBand6.SmallImage = ((System.Drawing.Image)(resources.GetObject("naviBand6.SmallImage")));
            this.naviBand6.TabIndex = 0;
            this.naviBand6.Text = "Forms";
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.FullRowSelect = true;
            this.treeView1.LineColor = System.Drawing.Color.Blue;
            this.treeView1.Location = new System.Drawing.Point(2, 3);
            this.treeView1.Name = "treeView1";
            treeNode13.Name = "Screening";
            treeNode13.Text = "Screening";
            treeNode14.Name = "FollowUp";
            treeNode14.Text = "Follow Up";
            treeNode15.Name = "Forms";
            treeNode15.Text = "Forms";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15});
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(246, 450);
            this.treeView1.TabIndex = 30;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // naviBand1
            // 
            // 
            // naviBand1.ClientArea
            // 
            this.naviBand1.ClientArea.Location = new System.Drawing.Point(0, 0);
            this.naviBand1.ClientArea.Name = "ClientArea";
            this.naviBand1.ClientArea.Size = new System.Drawing.Size(254, 748);
            this.naviBand1.ClientArea.TabIndex = 0;
            this.naviBand1.LargeImage = ((System.Drawing.Image)(resources.GetObject("naviBand1.LargeImage")));
            this.naviBand1.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Silver;
            this.naviBand1.Location = new System.Drawing.Point(1, 27);
            this.naviBand1.Name = "naviBand1";
            this.naviBand1.Size = new System.Drawing.Size(254, 748);
            this.naviBand1.SmallImage = ((System.Drawing.Image)(resources.GetObject("naviBand1.SmallImage")));
            this.naviBand1.TabIndex = 1;
            this.naviBand1.Text = "Dual Entry";
            // 
            // naviBand3
            // 
            // 
            // naviBand3.ClientArea
            // 
            this.naviBand3.ClientArea.Location = new System.Drawing.Point(0, 0);
            this.naviBand3.ClientArea.Name = "ClientArea";
            this.naviBand3.ClientArea.Size = new System.Drawing.Size(254, 748);
            this.naviBand3.ClientArea.TabIndex = 0;
            this.naviBand3.LargeImage = ((System.Drawing.Image)(resources.GetObject("naviBand3.LargeImage")));
            this.naviBand3.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Silver;
            this.naviBand3.Location = new System.Drawing.Point(1, 27);
            this.naviBand3.Name = "naviBand3";
            this.naviBand3.Size = new System.Drawing.Size(254, 748);
            this.naviBand3.SmallImage = ((System.Drawing.Image)(resources.GetObject("naviBand3.SmallImage")));
            this.naviBand3.TabIndex = 3;
            this.naviBand3.Text = "Entry Status";
            // 
            // naviBand5
            // 
            // 
            // naviBand5.ClientArea
            // 
            this.naviBand5.ClientArea.Location = new System.Drawing.Point(0, 0);
            this.naviBand5.ClientArea.Name = "ClientArea";
            this.naviBand5.ClientArea.Size = new System.Drawing.Size(254, 748);
            this.naviBand5.ClientArea.TabIndex = 0;
            this.naviBand5.LargeImage = ((System.Drawing.Image)(resources.GetObject("naviBand5.LargeImage")));
            this.naviBand5.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Silver;
            this.naviBand5.Location = new System.Drawing.Point(1, 27);
            this.naviBand5.Name = "naviBand5";
            this.naviBand5.Size = new System.Drawing.Size(254, 748);
            this.naviBand5.SmallImage = ((System.Drawing.Image)(resources.GetObject("naviBand5.SmallImage")));
            this.naviBand5.TabIndex = 4;
            this.naviBand5.Text = "Create Dictionary";
            // 
            // naviBand2
            // 
            // 
            // naviBand2.ClientArea
            // 
            this.naviBand2.ClientArea.Location = new System.Drawing.Point(0, 0);
            this.naviBand2.ClientArea.Name = "ClientArea";
            this.naviBand2.ClientArea.Size = new System.Drawing.Size(254, 748);
            this.naviBand2.ClientArea.TabIndex = 0;
            this.naviBand2.LargeImage = ((System.Drawing.Image)(resources.GetObject("naviBand2.LargeImage")));
            this.naviBand2.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Silver;
            this.naviBand2.Location = new System.Drawing.Point(1, 27);
            this.naviBand2.Name = "naviBand2";
            this.naviBand2.Size = new System.Drawing.Size(254, 748);
            this.naviBand2.SmallImage = ((System.Drawing.Image)(resources.GetObject("naviBand2.SmallImage")));
            this.naviBand2.TabIndex = 2;
            this.naviBand2.Text = "Error Check";
            // 
            // naviBand4
            // 
            // 
            // naviBand4.ClientArea
            // 
            this.naviBand4.ClientArea.Location = new System.Drawing.Point(0, 0);
            this.naviBand4.ClientArea.Name = "ClientArea";
            this.naviBand4.ClientArea.Size = new System.Drawing.Size(254, 748);
            this.naviBand4.ClientArea.TabIndex = 0;
            this.naviBand4.LargeImage = ((System.Drawing.Image)(resources.GetObject("naviBand4.LargeImage")));
            this.naviBand4.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Silver;
            this.naviBand4.Location = new System.Drawing.Point(1, 27);
            this.naviBand4.Name = "naviBand4";
            this.naviBand4.Size = new System.Drawing.Size(254, 748);
            this.naviBand4.SmallImage = ((System.Drawing.Image)(resources.GetObject("naviBand4.SmallImage")));
            this.naviBand4.TabIndex = 5;
            this.naviBand4.Text = "User Permissions";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 1053);
            this.Controls.Add(this.naviBar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.naviBar1)).EndInit();
            this.naviBar1.ResumeLayout(false);
            this.naviBand6.ClientArea.ResumeLayout(false);
            this.naviBand6.ResumeLayout(false);
            this.naviBand1.ResumeLayout(false);
            this.naviBand3.ResumeLayout(false);
            this.naviBand5.ResumeLayout(false);
            this.naviBand2.ResumeLayout(false);
            this.naviBand4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem dataCorrectionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem dualEntryToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem errorCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entryStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userPermissionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDataToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Guifreaks.NavigationBar.NaviBar naviBar1;
        private Guifreaks.NavigationBar.NaviBand naviBand6;
        private System.Windows.Forms.TreeView treeView1;
        private Guifreaks.NavigationBar.NaviBand naviBand1;
        private Guifreaks.NavigationBar.NaviBand naviBand3;
        private Guifreaks.NavigationBar.NaviBand naviBand5;
        private Guifreaks.NavigationBar.NaviBand naviBand2;
        private Guifreaks.NavigationBar.NaviBand naviBand4;
    }
}