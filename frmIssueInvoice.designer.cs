
namespace CarRentaSYS
{
    partial class frmIssueInvoice
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
            this.invoiceDataGr = new System.Windows.Forms.DataGridView();
            this.StartInvoiceBtn = new System.Windows.Forms.Button();
            this.proBar = new System.Windows.Forms.ProgressBar();
            this.minLb = new System.Windows.Forms.Label();
            this.maxLb = new System.Windows.Forms.Label();
            this.minNumLb = new System.Windows.Forms.Label();
            this.maxNumLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backmnuStrip = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGr)).BeginInit();
            this.backmnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // invoiceDataGr
            // 
            this.invoiceDataGr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceDataGr.Location = new System.Drawing.Point(287, 36);
            this.invoiceDataGr.Name = "invoiceDataGr";
            this.invoiceDataGr.RowHeadersWidth = 62;
            this.invoiceDataGr.RowTemplate.Height = 33;
            this.invoiceDataGr.Size = new System.Drawing.Size(801, 358);
            this.invoiceDataGr.TabIndex = 0;
            this.invoiceDataGr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceDataGr_CellContentClick);
            // 
            // StartInvoiceBtn
            // 
            this.StartInvoiceBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartInvoiceBtn.Location = new System.Drawing.Point(596, 476);
            this.StartInvoiceBtn.Name = "StartInvoiceBtn";
            this.StartInvoiceBtn.Size = new System.Drawing.Size(216, 63);
            this.StartInvoiceBtn.TabIndex = 1;
            this.StartInvoiceBtn.Text = "Start";
            this.StartInvoiceBtn.UseVisualStyleBackColor = false;
            this.StartInvoiceBtn.Click += new System.EventHandler(this.Start_Click);
            // 
            // proBar
            // 
            this.proBar.Location = new System.Drawing.Point(302, 621);
            this.proBar.Name = "proBar";
            this.proBar.Size = new System.Drawing.Size(774, 50);
            this.proBar.TabIndex = 2;
            this.proBar.Visible = false;
            // 
            // minLb
            // 
            this.minLb.AutoSize = true;
            this.minLb.Location = new System.Drawing.Point(302, 724);
            this.minLb.Name = "minLb";
            this.minLb.Size = new System.Drawing.Size(42, 25);
            this.minLb.TabIndex = 6;
            this.minLb.Text = "Min";
            // 
            // maxLb
            // 
            this.maxLb.AutoSize = true;
            this.maxLb.Location = new System.Drawing.Point(1031, 724);
            this.maxLb.Name = "maxLb";
            this.maxLb.Size = new System.Drawing.Size(45, 25);
            this.maxLb.TabIndex = 5;
            this.maxLb.Text = "Max";
            // 
            // minNumLb
            // 
            this.minNumLb.AutoSize = true;
            this.minNumLb.Location = new System.Drawing.Point(302, 699);
            this.minNumLb.Name = "minNumLb";
            this.minNumLb.Size = new System.Drawing.Size(22, 25);
            this.minNumLb.TabIndex = 7;
            this.minNumLb.Text = "0";
            this.minNumLb.Visible = false;
            // 
            // maxNumLb
            // 
            this.maxNumLb.AutoSize = true;
            this.maxNumLb.Location = new System.Drawing.Point(1034, 699);
            this.maxNumLb.Name = "maxNumLb";
            this.maxNumLb.Size = new System.Drawing.Size(32, 25);
            this.maxNumLb.TabIndex = 8;
            this.maxNumLb.Text = "00";
            this.maxNumLb.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(373, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Press the start button to issue invoices to the clients above";
            // 
            // backmnuStrip
            // 
            this.backmnuStrip.BackColor = System.Drawing.Color.Red;
            this.backmnuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.backmnuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.backmnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.backmnuStrip.Location = new System.Drawing.Point(1275, 0);
            this.backmnuStrip.Name = "backmnuStrip";
            this.backmnuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.backmnuStrip.Size = new System.Drawing.Size(95, 33);
            this.backmnuStrip.TabIndex = 11;
            this.backmnuStrip.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.backToolStripMenuItem.Text = "< back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click_1);
            // 
            // frmIssueInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1357, 769);
            this.Controls.Add(this.backmnuStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxNumLb);
            this.Controls.Add(this.minNumLb);
            this.Controls.Add(this.minLb);
            this.Controls.Add(this.maxLb);
            this.Controls.Add(this.proBar);
            this.Controls.Add(this.StartInvoiceBtn);
            this.Controls.Add(this.invoiceDataGr);
            this.Name = "frmIssueInvoice";
            this.Text = "Issue Invoice";
            this.Load += new System.EventHandler(this.frmIssueInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGr)).EndInit();
            this.backmnuStrip.ResumeLayout(false);
            this.backmnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView invoiceDataGr;
        private System.Windows.Forms.Button StartInvoiceBtn;
        private System.Windows.Forms.ProgressBar proBar;
        private System.Windows.Forms.Label minLb;
        private System.Windows.Forms.Label maxLb;
        private System.Windows.Forms.Label minNumLb;
        private System.Windows.Forms.Label maxNumLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip backmnuStrip;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}