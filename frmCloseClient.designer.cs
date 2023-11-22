
namespace CarRentaSYS
{
    partial class frmCloseClient
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
            this.findClientTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.findClientBtn = new System.Windows.Forms.Button();
            this.closeClientGrp = new System.Windows.Forms.GroupBox();
            this.closeClientBtn = new System.Windows.Forms.Button();
            this.closeClientGrd = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeClientGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeClientGrd)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // findClientTxt
            // 
            this.findClientTxt.Location = new System.Drawing.Point(183, 29);
            this.findClientTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.findClientTxt.Name = "findClientTxt";
            this.findClientTxt.Size = new System.Drawing.Size(123, 20);
            this.findClientTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter client ID number:";
            // 
            // findClientBtn
            // 
            this.findClientBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.findClientBtn.Location = new System.Drawing.Point(448, 29);
            this.findClientBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.findClientBtn.Name = "findClientBtn";
            this.findClientBtn.Size = new System.Drawing.Size(109, 31);
            this.findClientBtn.TabIndex = 4;
            this.findClientBtn.Text = "Search Client";
            this.findClientBtn.UseVisualStyleBackColor = false;
            this.findClientBtn.Click += new System.EventHandler(this.findClientBtn_Click);
            // 
            // closeClientGrp
            // 
            this.closeClientGrp.BackColor = System.Drawing.Color.OldLace;
            this.closeClientGrp.Controls.Add(this.closeClientBtn);
            this.closeClientGrp.Controls.Add(this.closeClientGrd);
            this.closeClientGrp.Location = new System.Drawing.Point(16, 77);
            this.closeClientGrp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeClientGrp.Name = "closeClientGrp";
            this.closeClientGrp.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeClientGrp.Size = new System.Drawing.Size(658, 319);
            this.closeClientGrp.TabIndex = 6;
            this.closeClientGrp.TabStop = false;
            this.closeClientGrp.Text = "Client Details";
            this.closeClientGrp.Visible = false;
            // 
            // closeClientBtn
            // 
            this.closeClientBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeClientBtn.Location = new System.Drawing.Point(130, 282);
            this.closeClientBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeClientBtn.Name = "closeClientBtn";
            this.closeClientBtn.Size = new System.Drawing.Size(383, 33);
            this.closeClientBtn.TabIndex = 1;
            this.closeClientBtn.Text = "Close Account";
            this.closeClientBtn.UseVisualStyleBackColor = false;
            this.closeClientBtn.Click += new System.EventHandler(this.closeClientBtn_Click);
            // 
            // closeClientGrd
            // 
            this.closeClientGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.closeClientGrd.Location = new System.Drawing.Point(19, 22);
            this.closeClientGrd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeClientGrd.Name = "closeClientGrd";
            this.closeClientGrd.RowHeadersWidth = 62;
            this.closeClientGrd.RowTemplate.Height = 33;
            this.closeClientGrd.Size = new System.Drawing.Size(625, 250);
            this.closeClientGrd.TabIndex = 0;
            this.closeClientGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.closeClientGrd_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Red;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(634, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(55, 17);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(56, 15);
            this.backToolStripMenuItem.Text = "<back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click_1);
            // 
            // frmCloseClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(690, 438);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.closeClientGrp);
            this.Controls.Add(this.findClientBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findClientTxt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCloseClient";
            this.Text = "Close Client";
            this.Load += new System.EventHandler(this.frmCloseClient_Load);
            this.closeClientGrp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeClientGrd)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox findClientTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findClientBtn;
        private System.Windows.Forms.GroupBox closeClientGrp;
        private System.Windows.Forms.Button closeClientBtn;
        private System.Windows.Forms.DataGridView closeClientGrd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}