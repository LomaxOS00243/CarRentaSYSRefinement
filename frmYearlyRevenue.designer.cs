
namespace CarRentaSYS
{
    partial class frmYearlyRevenue
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
            this.yearlyRevYearCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yearlyRevDataG = new System.Windows.Forms.DataGridView();
            this.yearRevLb = new System.Windows.Forms.Label();
            this.backmnuStrip = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.yearlyRevDataG)).BeginInit();
            this.backmnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // yearlyRevYearCmb
            // 
            this.yearlyRevYearCmb.FormattingEnabled = true;
            this.yearlyRevYearCmb.Items.AddRange(new object[] {
            "2020 ",
            "2021 ",
            "2022 ",
            "2023 ",
            "2024 ",
            "2025 ",
            "2026 ",
            "2027 ",
            "2028 ",
            "2029 ",
            "2030 "});
            this.yearlyRevYearCmb.Location = new System.Drawing.Point(182, 58);
            this.yearlyRevYearCmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yearlyRevYearCmb.Name = "yearlyRevYearCmb";
            this.yearlyRevYearCmb.Size = new System.Drawing.Size(122, 21);
            this.yearlyRevYearCmb.TabIndex = 0;
            this.yearlyRevYearCmb.SelectedIndexChanged += new System.EventHandler(this.yearlyRevYearCmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(125, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a year to list the yearly revenue";
            // 
            // yearlyRevDataG
            // 
            this.yearlyRevDataG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yearlyRevDataG.Location = new System.Drawing.Point(133, 127);
            this.yearlyRevDataG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yearlyRevDataG.Name = "yearlyRevDataG";
            this.yearlyRevDataG.RowHeadersWidth = 62;
            this.yearlyRevDataG.RowTemplate.Height = 33;
            this.yearlyRevDataG.Size = new System.Drawing.Size(233, 213);
            this.yearlyRevDataG.TabIndex = 2;
            this.yearlyRevDataG.Visible = false;
            // 
            // yearRevLb
            // 
            this.yearRevLb.AutoSize = true;
            this.yearRevLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yearRevLb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.yearRevLb.Location = new System.Drawing.Point(182, 92);
            this.yearRevLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yearRevLb.Name = "yearRevLb";
            this.yearRevLb.Size = new System.Drawing.Size(126, 23);
            this.yearRevLb.TabIndex = 3;
            this.yearRevLb.Text = "Yearly Revenue ";
            this.yearRevLb.Visible = false;
            // 
            // backmnuStrip
            // 
            this.backmnuStrip.AutoSize = false;
            this.backmnuStrip.BackColor = System.Drawing.Color.Red;
            this.backmnuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.backmnuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.backmnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.backmnuStrip.Location = new System.Drawing.Point(441, 0);
            this.backmnuStrip.Name = "backmnuStrip";
            this.backmnuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.backmnuStrip.Size = new System.Drawing.Size(56, 17);
            this.backmnuStrip.TabIndex = 4;
            this.backmnuStrip.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(56, 15);
            this.backToolStripMenuItem.Text = "< back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // frmYearlyRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 389);
            this.Controls.Add(this.backmnuStrip);
            this.Controls.Add(this.yearRevLb);
            this.Controls.Add(this.yearlyRevDataG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearlyRevYearCmb);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmYearlyRevenue";
            this.Text = "Yearly Revenue";
            this.Load += new System.EventHandler(this.frmInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yearlyRevDataG)).EndInit();
            this.backmnuStrip.ResumeLayout(false);
            this.backmnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox yearlyRevYearCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView yearlyRevDataG;
        private System.Windows.Forms.Label yearRevLb;
        private System.Windows.Forms.MenuStrip backmnuStrip;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}