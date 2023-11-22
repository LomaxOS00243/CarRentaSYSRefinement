
namespace CarRentaSYS
{
    partial class frmPrintStatement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintStatement));
            this.printClientBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printClientTxtBox = new System.Windows.Forms.TextBox();
            this.stateGrpBox = new System.Windows.Forms.GroupBox();
            this.printPreviewBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.backmnuStrip = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.stateGrpBox.SuspendLayout();
            this.backmnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // printClientBtn
            // 
            this.printClientBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.printClientBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printClientBtn.Location = new System.Drawing.Point(271, 127);
            this.printClientBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printClientBtn.Name = "printClientBtn";
            this.printClientBtn.Size = new System.Drawing.Size(202, 74);
            this.printClientBtn.TabIndex = 8;
            this.printClientBtn.Text = "Search";
            this.printClientBtn.UseVisualStyleBackColor = false;
            this.printClientBtn.Click += new System.EventHandler(this.printClientBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(110, 268);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 429);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter client ID number:";
            // 
            // printClientTxtBox
            // 
            this.printClientTxtBox.Location = new System.Drawing.Point(271, 44);
            this.printClientTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printClientTxtBox.Name = "printClientTxtBox";
            this.printClientTxtBox.Size = new System.Drawing.Size(202, 31);
            this.printClientTxtBox.TabIndex = 5;
            // 
            // stateGrpBox
            // 
            this.stateGrpBox.Controls.Add(this.printPreviewBtn);
            this.stateGrpBox.Controls.Add(this.printBtn);
            this.stateGrpBox.Controls.Add(this.richTextBox1);
            this.stateGrpBox.Location = new System.Drawing.Point(630, 70);
            this.stateGrpBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stateGrpBox.Name = "stateGrpBox";
            this.stateGrpBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stateGrpBox.Size = new System.Drawing.Size(622, 786);
            this.stateGrpBox.TabIndex = 9;
            this.stateGrpBox.TabStop = false;
            this.stateGrpBox.Text = "Statement";
            this.stateGrpBox.Visible = false;
            // 
            // printPreviewBtn
            // 
            this.printPreviewBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.printPreviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printPreviewBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printPreviewBtn.Location = new System.Drawing.Point(359, 660);
            this.printPreviewBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printPreviewBtn.Name = "printPreviewBtn";
            this.printPreviewBtn.Size = new System.Drawing.Size(211, 78);
            this.printPreviewBtn.TabIndex = 2;
            this.printPreviewBtn.Text = "Print Preview";
            this.printPreviewBtn.UseVisualStyleBackColor = false;
            this.printPreviewBtn.Click += new System.EventHandler(this.printPreviewBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printBtn.Location = new System.Drawing.Point(56, 660);
            this.printBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(211, 78);
            this.printBtn.TabIndex = 1;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 41);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(571, 603);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // backmnuStrip
            // 
            this.backmnuStrip.BackColor = System.Drawing.Color.Red;
            this.backmnuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.backmnuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.backmnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.backmnuStrip.Location = new System.Drawing.Point(1213, 0);
            this.backmnuStrip.Name = "backmnuStrip";
            this.backmnuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.backmnuStrip.Size = new System.Drawing.Size(95, 33);
            this.backmnuStrip.TabIndex = 10;
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
            // frmPrintStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1303, 884);
            this.Controls.Add(this.backmnuStrip);
            this.Controls.Add(this.stateGrpBox);
            this.Controls.Add(this.printClientBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printClientTxtBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPrintStatement";
            this.Text = "frmPrintStatement";
            this.Load += new System.EventHandler(this.frmPrintStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.stateGrpBox.ResumeLayout(false);
            this.backmnuStrip.ResumeLayout(false);
            this.backmnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printClientBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox printClientTxtBox;
        private System.Windows.Forms.GroupBox stateGrpBox;
        private System.Windows.Forms.Button printPreviewBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.MenuStrip backmnuStrip;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}