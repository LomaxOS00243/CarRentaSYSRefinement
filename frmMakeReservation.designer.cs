
namespace CarRentaSYS
{
    partial class frmMakeReservation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbClientId = new System.Windows.Forms.ComboBox();
            this.checkAvailCarBtn = new System.Windows.Forms.Button();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.collectDate = new System.Windows.Forms.DateTimePicker();
            this.cbCarType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectCars = new System.Windows.Forms.GroupBox();
            this.makeResGrd = new System.Windows.Forms.DataGridView();
            this.resSummary = new System.Windows.Forms.GroupBox();
            this.resCostTxtBox = new System.Windows.Forms.TextBox();
            this.returnDateTxtBox = new System.Windows.Forms.TextBox();
            this.collectDateTxtBox = new System.Windows.Forms.TextBox();
            this.regNoTxtBox = new System.Windows.Forms.TextBox();
            this.clIdTxtBox = new System.Windows.Forms.TextBox();
            this.resIdTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.resConfirmBtn = new System.Windows.Forms.Button();
            this.backmnuStrip = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.selectCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.makeResGrd)).BeginInit();
            this.resSummary.SuspendLayout();
            this.backmnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OldLace;
            this.groupBox1.Controls.Add(this.cbClientId);
            this.groupBox1.Controls.Add(this.checkAvailCarBtn);
            this.groupBox1.Controls.Add(this.returnDate);
            this.groupBox1.Controls.Add(this.collectDate);
            this.groupBox1.Controls.Add(this.cbCarType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(90, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1080, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbClientId
            // 
            this.cbClientId.FormattingEnabled = true;
            this.cbClientId.Location = new System.Drawing.Point(231, 43);
            this.cbClientId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbClientId.Name = "cbClientId";
            this.cbClientId.Size = new System.Drawing.Size(375, 33);
            this.cbClientId.TabIndex = 9;
            this.cbClientId.Text = "-select-";
            // 
            // checkAvailCarBtn
            // 
            this.checkAvailCarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkAvailCarBtn.Location = new System.Drawing.Point(889, 210);
            this.checkAvailCarBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkAvailCarBtn.Name = "checkAvailCarBtn";
            this.checkAvailCarBtn.Size = new System.Drawing.Size(118, 54);
            this.checkAvailCarBtn.TabIndex = 8;
            this.checkAvailCarBtn.Text = "Available";
            this.checkAvailCarBtn.UseVisualStyleBackColor = false;
            this.checkAvailCarBtn.Click += new System.EventHandler(this.btnavaillllability_Click);
            // 
            // returnDate
            // 
            this.returnDate.Location = new System.Drawing.Point(231, 220);
            this.returnDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(375, 31);
            this.returnDate.TabIndex = 7;
            this.returnDate.Value = new System.DateTime(2021, 12, 19, 0, 0, 0, 0);
            // 
            // collectDate
            // 
            this.collectDate.Location = new System.Drawing.Point(231, 157);
            this.collectDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.collectDate.Name = "collectDate";
            this.collectDate.Size = new System.Drawing.Size(375, 31);
            this.collectDate.TabIndex = 6;
            // 
            // cbCarType
            // 
            this.cbCarType.FormattingEnabled = true;
            this.cbCarType.Location = new System.Drawing.Point(231, 99);
            this.cbCarType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCarType.Name = "cbCarType";
            this.cbCarType.Size = new System.Drawing.Size(375, 33);
            this.cbCarType.TabIndex = 5;
            this.cbCarType.Text = "-select-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(32, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Return Date:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Collect Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Car Type:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Client Name: ";
            // 
            // selectCars
            // 
            this.selectCars.BackColor = System.Drawing.Color.OldLace;
            this.selectCars.Controls.Add(this.makeResGrd);
            this.selectCars.Location = new System.Drawing.Point(284, 354);
            this.selectCars.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectCars.Name = "selectCars";
            this.selectCars.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectCars.Size = new System.Drawing.Size(719, 329);
            this.selectCars.TabIndex = 1;
            this.selectCars.TabStop = false;
            this.selectCars.Text = "Select Car";
            this.selectCars.Visible = false;
            this.selectCars.Enter += new System.EventHandler(this.selectCars_Enter);
            // 
            // makeResGrd
            // 
            this.makeResGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.makeResGrd.Location = new System.Drawing.Point(26, 48);
            this.makeResGrd.Name = "makeResGrd";
            this.makeResGrd.RowHeadersWidth = 62;
            this.makeResGrd.RowTemplate.Height = 33;
            this.makeResGrd.Size = new System.Drawing.Size(673, 259);
            this.makeResGrd.TabIndex = 0;
            this.makeResGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.makeResGrd_CellContentClick);
            // 
            // resSummary
            // 
            this.resSummary.BackColor = System.Drawing.Color.OldLace;
            this.resSummary.Controls.Add(this.resCostTxtBox);
            this.resSummary.Controls.Add(this.returnDateTxtBox);
            this.resSummary.Controls.Add(this.collectDateTxtBox);
            this.resSummary.Controls.Add(this.regNoTxtBox);
            this.resSummary.Controls.Add(this.clIdTxtBox);
            this.resSummary.Controls.Add(this.resIdTxtBox);
            this.resSummary.Controls.Add(this.label10);
            this.resSummary.Controls.Add(this.label9);
            this.resSummary.Controls.Add(this.label8);
            this.resSummary.Controls.Add(this.label7);
            this.resSummary.Controls.Add(this.label6);
            this.resSummary.Controls.Add(this.label5);
            this.resSummary.Controls.Add(this.cancelBtn);
            this.resSummary.Controls.Add(this.resConfirmBtn);
            this.resSummary.Location = new System.Drawing.Point(145, 727);
            this.resSummary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resSummary.Name = "resSummary";
            this.resSummary.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resSummary.Size = new System.Drawing.Size(987, 346);
            this.resSummary.TabIndex = 2;
            this.resSummary.TabStop = false;
            this.resSummary.Text = "Comfirm Reservation";
            this.resSummary.Visible = false;
            // 
            // resCostTxtBox
            // 
            this.resCostTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resCostTxtBox.Enabled = false;
            this.resCostTxtBox.Location = new System.Drawing.Point(152, 284);
            this.resCostTxtBox.Name = "resCostTxtBox";
            this.resCostTxtBox.Size = new System.Drawing.Size(185, 31);
            this.resCostTxtBox.TabIndex = 17;
            // 
            // returnDateTxtBox
            // 
            this.returnDateTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.returnDateTxtBox.Enabled = false;
            this.returnDateTxtBox.Location = new System.Drawing.Point(765, 105);
            this.returnDateTxtBox.Name = "returnDateTxtBox";
            this.returnDateTxtBox.Size = new System.Drawing.Size(185, 31);
            this.returnDateTxtBox.TabIndex = 16;
            // 
            // collectDateTxtBox
            // 
            this.collectDateTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.collectDateTxtBox.Enabled = false;
            this.collectDateTxtBox.Location = new System.Drawing.Point(556, 105);
            this.collectDateTxtBox.Name = "collectDateTxtBox";
            this.collectDateTxtBox.Size = new System.Drawing.Size(185, 31);
            this.collectDateTxtBox.TabIndex = 15;
            // 
            // regNoTxtBox
            // 
            this.regNoTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.regNoTxtBox.Enabled = false;
            this.regNoTxtBox.Location = new System.Drawing.Point(232, 192);
            this.regNoTxtBox.Name = "regNoTxtBox";
            this.regNoTxtBox.Size = new System.Drawing.Size(259, 31);
            this.regNoTxtBox.TabIndex = 14;
            // 
            // clIdTxtBox
            // 
            this.clIdTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clIdTxtBox.Enabled = false;
            this.clIdTxtBox.Location = new System.Drawing.Point(190, 124);
            this.clIdTxtBox.Name = "clIdTxtBox";
            this.clIdTxtBox.Size = new System.Drawing.Size(237, 31);
            this.clIdTxtBox.TabIndex = 13;
            // 
            // resIdTxtBox
            // 
            this.resIdTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resIdTxtBox.Enabled = false;
            this.resIdTxtBox.Location = new System.Drawing.Point(190, 68);
            this.resIdTxtBox.Name = "resIdTxtBox";
            this.resIdTxtBox.Size = new System.Drawing.Size(237, 31);
            this.resIdTxtBox.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(26, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 28);
            this.label10.TabIndex = 11;
            this.label10.Text = "Cost:";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(792, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 31);
            this.label9.TabIndex = 10;
            this.label9.Text = "Return date";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(568, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 31);
            this.label8.TabIndex = 9;
            this.label8.Text = "Collection date";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(7, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 34);
            this.label7.TabIndex = 8;
            this.label7.Text = "Car Registration No:";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(7, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "Client ID:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Reservation No:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancelBtn.Location = new System.Drawing.Point(792, 271);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(124, 56);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // resConfirmBtn
            // 
            this.resConfirmBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resConfirmBtn.Location = new System.Drawing.Point(627, 271);
            this.resConfirmBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resConfirmBtn.Name = "resConfirmBtn";
            this.resConfirmBtn.Size = new System.Drawing.Size(126, 56);
            this.resConfirmBtn.TabIndex = 1;
            this.resConfirmBtn.Text = "Ok";
            this.resConfirmBtn.UseVisualStyleBackColor = false;
            this.resConfirmBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // backmnuStrip
            // 
            this.backmnuStrip.AutoSize = false;
            this.backmnuStrip.BackColor = System.Drawing.Color.Red;
            this.backmnuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.backmnuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.backmnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.backmnuStrip.Location = new System.Drawing.Point(1189, 0);
            this.backmnuStrip.Name = "backmnuStrip";
            this.backmnuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.backmnuStrip.Size = new System.Drawing.Size(95, 33);
            this.backmnuStrip.TabIndex = 3;
            this.backmnuStrip.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.backToolStripMenuItem.Text = "< back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // frmMakeReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1282, 1114);
            this.Controls.Add(this.resSummary);
            this.Controls.Add(this.selectCars);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backmnuStrip);
            this.MainMenuStrip = this.backmnuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMakeReservation";
            this.Text = "Make Reservation";
            this.Load += new System.EventHandler(this.frmMakeReservation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.selectCars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.makeResGrd)).EndInit();
            this.resSummary.ResumeLayout(false);
            this.resSummary.PerformLayout();
            this.backmnuStrip.ResumeLayout(false);
            this.backmnuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbCarType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkAvailCarBtn;
        private System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.DateTimePicker collectDate;
        private System.Windows.Forms.GroupBox selectCars;
        private System.Windows.Forms.GroupBox resSummary;
        private System.Windows.Forms.Button resConfirmBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip backmnuStrip;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridView makeResGrd;
        private System.Windows.Forms.TextBox regNoTxtBox;
        private System.Windows.Forms.TextBox clIdTxtBox;
        private System.Windows.Forms.TextBox resIdTxtBox;
        private System.Windows.Forms.TextBox resCostTxtBox;
        private System.Windows.Forms.TextBox returnDateTxtBox;
        private System.Windows.Forms.TextBox collectDateTxtBox;
        private System.Windows.Forms.ComboBox cbClientId;
    }
}