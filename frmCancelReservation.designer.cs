
namespace CarRentaSYS
{
    partial class frmCancelReservation
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
            this.findResBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.findResTxtBox = new System.Windows.Forms.TextBox();
            this.resSumGrBox = new System.Windows.Forms.GroupBox();
            this.regNoLb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalCostLbl = new System.Windows.Forms.Label();
            this.returnLbl = new System.Windows.Forms.Label();
            this.collectLbl = new System.Windows.Forms.Label();
            this.carInfoLbl = new System.Windows.Forms.Label();
            this.clientNamLbl = new System.Windows.Forms.Label();
            this.resNoLb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.retDateLb = new System.Windows.Forms.Label();
            this.cancelFeeLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.separator = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resSumGrBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // findResBtn
            // 
            this.findResBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.findResBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.findResBtn.Location = new System.Drawing.Point(860, 64);
            this.findResBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.findResBtn.Name = "findResBtn";
            this.findResBtn.Size = new System.Drawing.Size(219, 59);
            this.findResBtn.TabIndex = 7;
            this.findResBtn.Text = "Search Reservation";
            this.findResBtn.UseVisualStyleBackColor = false;
            this.findResBtn.Click += new System.EventHandler(this.findResBtn_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(109, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Reservation number:";
            // 
            // findResTxtBox
            // 
            this.findResTxtBox.Location = new System.Drawing.Point(352, 64);
            this.findResTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.findResTxtBox.Name = "findResTxtBox";
            this.findResTxtBox.Size = new System.Drawing.Size(202, 31);
            this.findResTxtBox.TabIndex = 5;
            // 
            // resSumGrBox
            // 
            this.resSumGrBox.BackColor = System.Drawing.Color.OldLace;
            this.resSumGrBox.Controls.Add(this.regNoLb);
            this.resSumGrBox.Controls.Add(this.label7);
            this.resSumGrBox.Controls.Add(this.label6);
            this.resSumGrBox.Controls.Add(this.totalCostLbl);
            this.resSumGrBox.Controls.Add(this.returnLbl);
            this.resSumGrBox.Controls.Add(this.collectLbl);
            this.resSumGrBox.Controls.Add(this.carInfoLbl);
            this.resSumGrBox.Controls.Add(this.clientNamLbl);
            this.resSumGrBox.Controls.Add(this.resNoLb);
            this.resSumGrBox.Controls.Add(this.label5);
            this.resSumGrBox.Controls.Add(this.retDateLb);
            this.resSumGrBox.Controls.Add(this.cancelFeeLbl);
            this.resSumGrBox.Controls.Add(this.label11);
            this.resSumGrBox.Controls.Add(this.label18);
            this.resSumGrBox.Controls.Add(this.label12);
            this.resSumGrBox.Controls.Add(this.label17);
            this.resSumGrBox.Controls.Add(this.label16);
            this.resSumGrBox.Controls.Add(this.label15);
            this.resSumGrBox.Controls.Add(this.label14);
            this.resSumGrBox.Controls.Add(this.label13);
            this.resSumGrBox.Controls.Add(this.cancelBtn);
            this.resSumGrBox.Controls.Add(this.label4);
            this.resSumGrBox.Controls.Add(this.label3);
            this.resSumGrBox.Controls.Add(this.label2);
            this.resSumGrBox.Controls.Add(this.separator);
            this.resSumGrBox.Location = new System.Drawing.Point(71, 161);
            this.resSumGrBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resSumGrBox.Name = "resSumGrBox";
            this.resSumGrBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resSumGrBox.Size = new System.Drawing.Size(1293, 682);
            this.resSumGrBox.TabIndex = 20;
            this.resSumGrBox.TabStop = false;
            this.resSumGrBox.Visible = false;
            // 
            // regNoLb
            // 
            this.regNoLb.AutoSize = true;
            this.regNoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.regNoLb.Location = new System.Drawing.Point(869, 167);
            this.regNoLb.Name = "regNoLb";
            this.regNoLb.Size = new System.Drawing.Size(159, 32);
            this.regNoLb.TabIndex = 51;
            this.regNoLb.Text = "00-AA-000";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(104, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(319, 42);
            this.label7.TabIndex = 50;
            this.label7.Text = "Registration Number:";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(74, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1114, 2);
            this.label6.TabIndex = 49;
            this.label6.Text = "------------------";
            // 
            // totalCostLbl
            // 
            this.totalCostLbl.AutoSize = true;
            this.totalCostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalCostLbl.Location = new System.Drawing.Point(924, 596);
            this.totalCostLbl.Name = "totalCostLbl";
            this.totalCostLbl.Size = new System.Drawing.Size(99, 32);
            this.totalCostLbl.TabIndex = 48;
            this.totalCostLbl.Text = "€ 0.00";
            // 
            // returnLbl
            // 
            this.returnLbl.AutoSize = true;
            this.returnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnLbl.Location = new System.Drawing.Point(869, 370);
            this.returnLbl.Name = "returnLbl";
            this.returnLbl.Size = new System.Drawing.Size(169, 32);
            this.returnLbl.TabIndex = 47;
            this.returnLbl.Text = "ReturnDate";
            // 
            // collectLbl
            // 
            this.collectLbl.AutoSize = true;
            this.collectLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.collectLbl.Location = new System.Drawing.Point(869, 298);
            this.collectLbl.Name = "collectLbl";
            this.collectLbl.Size = new System.Drawing.Size(173, 32);
            this.collectLbl.TabIndex = 45;
            this.collectLbl.Text = "CollectDate";
            // 
            // carInfoLbl
            // 
            this.carInfoLbl.AutoSize = true;
            this.carInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.carInfoLbl.Location = new System.Drawing.Point(869, 228);
            this.carInfoLbl.Name = "carInfoLbl";
            this.carInfoLbl.Size = new System.Drawing.Size(65, 32);
            this.carInfoLbl.TabIndex = 44;
            this.carInfoLbl.Text = "Info";
            // 
            // clientNamLbl
            // 
            this.clientNamLbl.AutoSize = true;
            this.clientNamLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clientNamLbl.Location = new System.Drawing.Point(869, 92);
            this.clientNamLbl.Name = "clientNamLbl";
            this.clientNamLbl.Size = new System.Drawing.Size(93, 32);
            this.clientNamLbl.TabIndex = 43;
            this.clientNamLbl.Text = "Name";
            // 
            // resNoLb
            // 
            this.resNoLb.AutoSize = true;
            this.resNoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resNoLb.Location = new System.Drawing.Point(482, 28);
            this.resNoLb.Name = "resNoLb";
            this.resNoLb.Size = new System.Drawing.Size(82, 32);
            this.resNoLb.TabIndex = 42;
            this.resNoLb.Text = "0000";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(104, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(319, 42);
            this.label5.TabIndex = 41;
            this.label5.Text = "Reservation Number:";
            // 
            // retDateLb
            // 
            this.retDateLb.AutoSize = true;
            this.retDateLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.retDateLb.Location = new System.Drawing.Point(953, 328);
            this.retDateLb.Name = "retDateLb";
            this.retDateLb.Size = new System.Drawing.Size(0, 32);
            this.retDateLb.TabIndex = 40;
            // 
            // cancelFeeLbl
            // 
            this.cancelFeeLbl.AutoSize = true;
            this.cancelFeeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelFeeLbl.Location = new System.Drawing.Point(869, 443);
            this.cancelFeeLbl.Name = "cancelFeeLbl";
            this.cancelFeeLbl.Size = new System.Drawing.Size(99, 32);
            this.cancelFeeLbl.TabIndex = 39;
            this.cancelFeeLbl.Text = "€ 0.00";
            this.cancelFeeLbl.Click += new System.EventHandler(this.canclCostLb_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(139, 596);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 34);
            this.label11.TabIndex = 33;
            this.label11.Text = "Total Cost: ";
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(74, 642);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(1114, 2);
            this.label18.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(104, 441);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(284, 42);
            this.label12.TabIndex = 31;
            this.label12.Text = "Cancellation Fee:";
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(74, 490);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(1114, 2);
            this.label17.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(104, 368);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(209, 42);
            this.label16.TabIndex = 29;
            this.label16.Text = "Return Date";
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(107, 296);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(206, 42);
            this.label15.TabIndex = 28;
            this.label15.Text = "Collect Date:";
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(104, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 42);
            this.label14.TabIndex = 27;
            this.label14.Text = "Car Info:";
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(104, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(228, 42);
            this.label13.TabIndex = 26;
            this.label13.Text = "Client Name: ";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.Location = new System.Drawing.Point(441, 511);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(377, 78);
            this.cancelBtn.TabIndex = 25;
            this.cancelBtn.Text = "Cancel Reservation";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(74, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1114, 2);
            this.label4.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(74, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1114, 2);
            this.label3.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(74, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1114, 2);
            this.label2.TabIndex = 21;
            // 
            // separator
            // 
            this.separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator.Location = new System.Drawing.Point(74, 212);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(1114, 2);
            this.separator.TabIndex = 20;
            this.separator.Text = "------------------";
            this.separator.Click += new System.EventHandler(this.separator_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Red;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1334, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(93, 36);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(86, 32);
            this.backToolStripMenuItem.Text = "<back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click_1);
            // 
            // frmCancelReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1423, 867);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.resSumGrBox);
            this.Controls.Add(this.findResBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findResTxtBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCancelReservation";
            this.Text = "Cancel Reservation";
            this.Load += new System.EventHandler(this.frmCancelReservation_Load);
            this.resSumGrBox.ResumeLayout(false);
            this.resSumGrBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findResBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox findResTxtBox;
        private System.Windows.Forms.GroupBox resSumGrBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label separator;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label retDateLb;
        private System.Windows.Forms.Label cancelFeeLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label clientNamLbl;
        private System.Windows.Forms.Label resNoLb;
        private System.Windows.Forms.Label returnLbl;
        private System.Windows.Forms.Label collectLbl;
        private System.Windows.Forms.Label carInfoLbl;
        private System.Windows.Forms.Label totalCostLbl;
        private System.Windows.Forms.Label regNoLb;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}