
namespace CarRentaSYS
{
    partial class FrmCloseCustomer
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
            this.custIDTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.findCustomerBtn = new System.Windows.Forms.Button();
            this.closeClientGrp = new System.Windows.Forms.GroupBox();
            this.closeClientBtn = new System.Windows.Forms.Button();
            this.closeClientGrd = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.managerIDTxt = new System.Windows.Forms.TextBox();
            this.closeClientGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeClientGrd)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // custIDTxt
            // 
            this.custIDTxt.Location = new System.Drawing.Point(185, 54);
            this.custIDTxt.Margin = new System.Windows.Forms.Padding(2);
            this.custIDTxt.Name = "custIDTxt";
            this.custIDTxt.Size = new System.Drawing.Size(123, 20);
            this.custIDTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Customer ID";
            // 
            // findCustomerBtn
            // 
            this.findCustomerBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.findCustomerBtn.Location = new System.Drawing.Point(448, 29);
            this.findCustomerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.findCustomerBtn.Name = "findCustomerBtn";
            this.findCustomerBtn.Size = new System.Drawing.Size(109, 31);
            this.findCustomerBtn.TabIndex = 4;
            this.findCustomerBtn.Text = "Search Client";
            this.findCustomerBtn.UseVisualStyleBackColor = false;
            this.findCustomerBtn.Click += new System.EventHandler(this.findClientBtn_Click);
            // 
            // closeClientGrp
            // 
            this.closeClientGrp.BackColor = System.Drawing.Color.OldLace;
            this.closeClientGrp.Controls.Add(this.closeClientBtn);
            this.closeClientGrp.Controls.Add(this.closeClientGrd);
            this.closeClientGrp.Location = new System.Drawing.Point(11, 108);
            this.closeClientGrp.Margin = new System.Windows.Forms.Padding(2);
            this.closeClientGrp.Name = "closeClientGrp";
            this.closeClientGrp.Padding = new System.Windows.Forms.Padding(2);
            this.closeClientGrp.Size = new System.Drawing.Size(658, 319);
            this.closeClientGrp.TabIndex = 6;
            this.closeClientGrp.TabStop = false;
            this.closeClientGrp.Text = "Customer Details";
            this.closeClientGrp.Visible = false;
            // 
            // closeClientBtn
            // 
            this.closeClientBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeClientBtn.Location = new System.Drawing.Point(130, 282);
            this.closeClientBtn.Margin = new System.Windows.Forms.Padding(2);
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
            this.closeClientGrd.Margin = new System.Windows.Forms.Padding(2);
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
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter Manager ID";
            // 
            // managerIDTxt
            // 
            this.managerIDTxt.Location = new System.Drawing.Point(185, 20);
            this.managerIDTxt.Margin = new System.Windows.Forms.Padding(2);
            this.managerIDTxt.Name = "managerIDTxt";
            this.managerIDTxt.Size = new System.Drawing.Size(123, 20);
            this.managerIDTxt.TabIndex = 14;
            // 
            // frmCloseClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(690, 438);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.managerIDTxt);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.closeClientGrp);
            this.Controls.Add(this.findCustomerBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.custIDTxt);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox custIDTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findCustomerBtn;
        private System.Windows.Forms.GroupBox closeClientGrp;
        private System.Windows.Forms.Button closeClientBtn;
        private System.Windows.Forms.DataGridView closeClientGrd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox managerIDTxt;
    }
}