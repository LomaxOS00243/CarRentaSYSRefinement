
namespace CarRentaSYS
{
    partial class frmMainMnu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMnu));
            this.mnuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clToolStripMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.nCToolStripMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeClAccToolStripMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.rntToolStripMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.makeResToolStripMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelResToolStripMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.cCarToolStripMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.rCarToolStripMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.bilToolStripMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.issueInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStrip1
            // 
            this.mnuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mnuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mnuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuStrip1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.mnuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clToolStripMnu,
            this.rntToolStripMnu,
            this.bilToolStripMnu,
            this.adminToolStripMnu});
            this.mnuStrip1.Location = new System.Drawing.Point(0, 1);
            this.mnuStrip1.Name = "mnuStrip1";
            this.mnuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mnuStrip1.Size = new System.Drawing.Size(530, 28);
            this.mnuStrip1.TabIndex = 0;
            this.mnuStrip1.Text = "menuStrip1";
            this.mnuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // clToolStripMnu
            // 
            this.clToolStripMnu.BackColor = System.Drawing.SystemColors.Control;
            this.clToolStripMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nCToolStripMnu,
            this.closeClAccToolStripMnu});
            this.clToolStripMnu.Name = "clToolStripMnu";
            this.clToolStripMnu.Size = new System.Drawing.Size(102, 26);
            this.clToolStripMnu.Text = "Customer";
            this.clToolStripMnu.Click += new System.EventHandler(this.clToolStripMnu_Click);
            // 
            // nCToolStripMnu
            // 
            this.nCToolStripMnu.Name = "nCToolStripMnu";
            this.nCToolStripMnu.Size = new System.Drawing.Size(207, 26);
            this.nCToolStripMnu.Text = "Create Account";
            this.nCToolStripMnu.Click += new System.EventHandler(this.nCToolStripMnu_Click);
            // 
            // closeClAccToolStripMnu
            // 
            this.closeClAccToolStripMnu.Name = "closeClAccToolStripMnu";
            this.closeClAccToolStripMnu.Size = new System.Drawing.Size(207, 26);
            this.closeClAccToolStripMnu.Text = "Close Account";
            this.closeClAccToolStripMnu.Click += new System.EventHandler(this.closeClAccToolStripMnu_Click);
            // 
            // rntToolStripMnu
            // 
            this.rntToolStripMnu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rntToolStripMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeResToolStripMnu,
            this.cancelResToolStripMnu,
            this.cCarToolStripMnu,
            this.rCarToolStripMnu});
            this.rntToolStripMnu.Name = "rntToolStripMnu";
            this.rntToolStripMnu.Size = new System.Drawing.Size(84, 26);
            this.rntToolStripMnu.Text = "Rentals";
            // 
            // makeResToolStripMnu
            // 
            this.makeResToolStripMnu.Name = "makeResToolStripMnu";
            this.makeResToolStripMnu.Size = new System.Drawing.Size(240, 26);
            this.makeResToolStripMnu.Text = "Make Reservation";
            this.makeResToolStripMnu.Click += new System.EventHandler(this.makeResToolStripMnu_Click);
            // 
            // cancelResToolStripMnu
            // 
            this.cancelResToolStripMnu.Name = "cancelResToolStripMnu";
            this.cancelResToolStripMnu.Size = new System.Drawing.Size(240, 26);
            this.cancelResToolStripMnu.Text = "Cancel Reservation";
            this.cancelResToolStripMnu.Click += new System.EventHandler(this.cancelResToolStripMnu_Click);
            // 
            // cCarToolStripMnu
            // 
            this.cCarToolStripMnu.Name = "cCarToolStripMnu";
            this.cCarToolStripMnu.Size = new System.Drawing.Size(240, 26);
            this.cCarToolStripMnu.Text = "Collect Car";
            this.cCarToolStripMnu.Click += new System.EventHandler(this.cCarToolStripMnu_Click);
            // 
            // rCarToolStripMnu
            // 
            this.rCarToolStripMnu.Name = "rCarToolStripMnu";
            this.rCarToolStripMnu.Size = new System.Drawing.Size(240, 26);
            this.rCarToolStripMnu.Text = "Return Car";
            this.rCarToolStripMnu.Click += new System.EventHandler(this.rCarToolStripMnu_Click);
            // 
            // bilToolStripMnu
            // 
            this.bilToolStripMnu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bilToolStripMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issueInvoicesToolStripMenuItem,
            this.recordClientToolStripMenuItem});
            this.bilToolStripMnu.Name = "bilToolStripMnu";
            this.bilToolStripMnu.Size = new System.Drawing.Size(75, 26);
            this.bilToolStripMnu.Text = "Billing";
            // 
            // issueInvoicesToolStripMenuItem
            // 
            this.issueInvoicesToolStripMenuItem.Name = "issueInvoicesToolStripMenuItem";
            this.issueInvoicesToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.issueInvoicesToolStripMenuItem.Text = "Issue Invoices";
            this.issueInvoicesToolStripMenuItem.Click += new System.EventHandler(this.issueInvoicesToolStripMenuItem_Click);
            // 
            // recordClientToolStripMenuItem
            // 
            this.recordClientToolStripMenuItem.Name = "recordClientToolStripMenuItem";
            this.recordClientToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.recordClientToolStripMenuItem.Text = "Record Client";
            // 
            // adminToolStripMnu
            // 
            this.adminToolStripMnu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.adminToolStripMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearlyRevenueAnalysisToolStripMenuItem});
            this.adminToolStripMnu.Name = "adminToolStripMnu";
            this.adminToolStripMnu.Size = new System.Drawing.Size(143, 26);
            this.adminToolStripMnu.Text = "Administration";
            // 
            // yearlyRevenueAnalysisToolStripMenuItem
            // 
            this.yearlyRevenueAnalysisToolStripMenuItem.Name = "yearlyRevenueAnalysisToolStripMenuItem";
            this.yearlyRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.yearlyRevenueAnalysisToolStripMenuItem.Text = "Yearly Revenue Analysis";
            this.yearlyRevenueAnalysisToolStripMenuItem.Click += new System.EventHandler(this.yearlyRevenueAnalysisToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(755, 391);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(706, 1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(83, 21);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(46, 19);
            this.backToolStripMenuItem.Text = "EXIT";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // frmMainMnu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(755, 414);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnuStrip1);
            this.MainMenuStrip = this.mnuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMainMnu";
            this.Text = "Car Rental SYS";
            this.Load += new System.EventHandler(this.frmMainMnu_Load);
            this.mnuStrip1.ResumeLayout(false);
            this.mnuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clToolStripMnu;
        private System.Windows.Forms.ToolStripMenuItem nCToolStripMnu;
        private System.Windows.Forms.ToolStripMenuItem closeClAccToolStripMnu;
        private System.Windows.Forms.ToolStripMenuItem rntToolStripMnu;
        private System.Windows.Forms.ToolStripMenuItem makeResToolStripMnu;
        private System.Windows.Forms.ToolStripMenuItem cancelResToolStripMnu;
        private System.Windows.Forms.ToolStripMenuItem cCarToolStripMnu;
        private System.Windows.Forms.ToolStripMenuItem rCarToolStripMnu;
        private System.Windows.Forms.ToolStripMenuItem bilToolStripMnu;
        private System.Windows.Forms.ToolStripMenuItem issueInvoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMnu;
        private System.Windows.Forms.ToolStripMenuItem yearlyRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}

