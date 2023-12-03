
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
            this.closeCustomerGrp = new System.Windows.Forms.GroupBox();
            this.closeClientBtn = new System.Windows.Forms.Button();
            this.closeCustomerGrd = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manIDLbl = new System.Windows.Forms.Label();
            this.managerIDTxt = new System.Windows.Forms.TextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCustomerGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeCustomerGrd)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // custIDTxt
            // 
            this.custIDTxt.Location = new System.Drawing.Point(185, 57);
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
            this.findCustomerBtn.Click += new System.EventHandler(this.FindCustomerAccountBtn_Click);
            // 
            // closeClientGrp
            // 
            this.closeCustomerGrp.BackColor = System.Drawing.Color.OldLace;
            this.closeCustomerGrp.Controls.Add(this.closeClientBtn);
            this.closeCustomerGrp.Controls.Add(this.closeCustomerGrd);
            this.closeCustomerGrp.Location = new System.Drawing.Point(11, 108);
            this.closeCustomerGrp.Margin = new System.Windows.Forms.Padding(2);
            this.closeCustomerGrp.Name = "closeClientGrp";
            this.closeCustomerGrp.Padding = new System.Windows.Forms.Padding(2);
            this.closeCustomerGrp.Size = new System.Drawing.Size(658, 319);
            this.closeCustomerGrp.TabIndex = 6;
            this.closeCustomerGrp.TabStop = false;
            this.closeCustomerGrp.Text = "Customer Details";
            this.closeCustomerGrp.Visible = false;
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
            this.closeClientBtn.Click += new System.EventHandler(this.CloseCustomerAccountBtn_Click);
            // 
            // closeClientGrd
            // 
            this.closeCustomerGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.closeCustomerGrd.Location = new System.Drawing.Point(19, 22);
            this.closeCustomerGrd.Margin = new System.Windows.Forms.Padding(2);
            this.closeCustomerGrd.Name = "closeClientGrd";
            this.closeCustomerGrd.RowHeadersWidth = 62;
            this.closeCustomerGrd.RowTemplate.Height = 33;
            this.closeCustomerGrd.Size = new System.Drawing.Size(625, 250);
            this.closeCustomerGrd.TabIndex = 0;
            this.closeCustomerGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CloseCustomerGrd_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Red;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(621, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(68, 17);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu1_ItemClicked);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(56, 15);
            this.backToolStripMenuItem.Text = "<back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.BackToMenuBtn_Click_1);
            // 
            // manIDLbl
            // 
            this.manIDLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.manIDLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.manIDLbl.Location = new System.Drawing.Point(30, 20);
            this.manIDLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manIDLbl.Name = "manIDLbl";
            this.manIDLbl.Size = new System.Drawing.Size(151, 20);
            this.manIDLbl.TabIndex = 15;
            this.manIDLbl.Text = "Enter Manager ID";
            // 
            // managerIDTxt
            // 
            this.managerIDTxt.Location = new System.Drawing.Point(185, 20);
            this.managerIDTxt.Margin = new System.Windows.Forms.Padding(2);
            this.managerIDTxt.Name = "managerIDTxt";
            this.managerIDTxt.Size = new System.Drawing.Size(123, 20);
            this.managerIDTxt.TabIndex = 14;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Red;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(56, 15);
            this.toolStripMenuItem1.Text = "<back";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.Red;
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(56, 15);
            this.toolStripMenuItem2.Text = "<back";
            // 
            // FrmCloseCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(690, 438);
            this.Controls.Add(this.manIDLbl);
            this.Controls.Add(this.managerIDTxt);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.closeCustomerGrp);
            this.Controls.Add(this.findCustomerBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.custIDTxt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCloseCustomer";
            this.Text = "Close Customer";
            this.Load += new System.EventHandler(this.FrmCloseCustomer_Load);
            this.closeCustomerGrp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeCustomerGrd)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox custIDTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findCustomerBtn;
        private System.Windows.Forms.GroupBox closeCustomerGrp;
        private System.Windows.Forms.Button closeClientBtn;
        private System.Windows.Forms.DataGridView closeCustomerGrd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label manIDLbl;
        private System.Windows.Forms.TextBox managerIDTxt;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}