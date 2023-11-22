
namespace CarRentaSYS
{
    partial class frmCollectCar
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
            this.label1 = new System.Windows.Forms.Label();
            this.collectResNoTxtBox = new System.Windows.Forms.TextBox();
            this.findResColBtn = new System.Windows.Forms.Button();
            this.collectBtn = new System.Windows.Forms.Button();
            this.colLb = new System.Windows.Forms.Label();
            this.resDate = new System.Windows.Forms.GroupBox();
            this.returnDateLb = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.separator = new System.Windows.Forms.Label();
            this.collectDateLb = new System.Windows.Forms.Label();
            this.retLb = new System.Windows.Forms.Label();
            this.visaRadioBtn = new System.Windows.Forms.RadioButton();
            this.payMethod = new System.Windows.Forms.GroupBox();
            this.cashRadioBtn = new System.Windows.Forms.RadioButton();
            this.paypalRadioBtn = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resDetails = new System.Windows.Forms.GroupBox();
            this.costLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.regNoLb = new System.Windows.Forms.Label();
            this.reglb = new System.Windows.Forms.Label();
            this.carModelLb = new System.Windows.Forms.Label();
            this.carNameLb = new System.Windows.Forms.Label();
            this.clientNameLb = new System.Windows.Forms.Label();
            this.resNoLb = new System.Windows.Forms.Label();
            this.resCost = new System.Windows.Forms.GroupBox();
            this.totalDueLb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.resDate.SuspendLayout();
            this.payMethod.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.resDetails.SuspendLayout();
            this.resCost.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Reservation number: ";
            // 
            // collectResNoTxtBox
            // 
            this.collectResNoTxtBox.Location = new System.Drawing.Point(386, 55);
            this.collectResNoTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.collectResNoTxtBox.Name = "collectResNoTxtBox";
            this.collectResNoTxtBox.Size = new System.Drawing.Size(216, 31);
            this.collectResNoTxtBox.TabIndex = 1;
            // 
            // findResColBtn
            // 
            this.findResColBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.findResColBtn.Location = new System.Drawing.Point(488, 151);
            this.findResColBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.findResColBtn.Name = "findResColBtn";
            this.findResColBtn.Size = new System.Drawing.Size(114, 44);
            this.findResColBtn.TabIndex = 2;
            this.findResColBtn.Text = "Ok";
            this.findResColBtn.UseVisualStyleBackColor = false;
            this.findResColBtn.Click += new System.EventHandler(this.findResColBtn_Click);
            // 
            // collectBtn
            // 
            this.collectBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.collectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.collectBtn.Location = new System.Drawing.Point(386, 655);
            this.collectBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.collectBtn.Name = "collectBtn";
            this.collectBtn.Size = new System.Drawing.Size(497, 56);
            this.collectBtn.TabIndex = 1;
            this.collectBtn.Text = "Ok";
            this.collectBtn.UseVisualStyleBackColor = false;
            this.collectBtn.Visible = false;
            this.collectBtn.Click += new System.EventHandler(this.collectBtn_Click);
            // 
            // colLb
            // 
            this.colLb.AutoSize = true;
            this.colLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.colLb.Location = new System.Drawing.Point(724, 60);
            this.colLb.Name = "colLb";
            this.colLb.Size = new System.Drawing.Size(159, 32);
            this.colLb.TabIndex = 6;
            this.colLb.Text = "Collect Date:";
            this.colLb.Visible = false;
            // 
            // resDate
            // 
            this.resDate.BackColor = System.Drawing.Color.OldLace;
            this.resDate.Controls.Add(this.returnDateLb);
            this.resDate.Controls.Add(this.label13);
            this.resDate.Controls.Add(this.separator);
            this.resDate.Controls.Add(this.collectDateLb);
            this.resDate.Location = new System.Drawing.Point(912, 34);
            this.resDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resDate.Name = "resDate";
            this.resDate.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resDate.Size = new System.Drawing.Size(228, 161);
            this.resDate.TabIndex = 8;
            this.resDate.TabStop = false;
            this.resDate.Visible = false;
            // 
            // returnDateLb
            // 
            this.returnDateLb.AutoSize = true;
            this.returnDateLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnDateLb.Location = new System.Drawing.Point(39, 106);
            this.returnDateLb.Name = "returnDateLb";
            this.returnDateLb.Size = new System.Drawing.Size(143, 29);
            this.returnDateLb.TabIndex = 29;
            this.returnDateLb.Text = "00-00-0000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(-641, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(205, 34);
            this.label13.TabIndex = 28;
            this.label13.Text = "Client Name: ";
            // 
            // separator
            // 
            this.separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator.Location = new System.Drawing.Point(29, 84);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(161, 2);
            this.separator.TabIndex = 27;
            // 
            // collectDateLb
            // 
            this.collectDateLb.AutoSize = true;
            this.collectDateLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.collectDateLb.Location = new System.Drawing.Point(39, 28);
            this.collectDateLb.Name = "collectDateLb";
            this.collectDateLb.Size = new System.Drawing.Size(143, 29);
            this.collectDateLb.TabIndex = 0;
            this.collectDateLb.Text = "00-00-0000";
            // 
            // retLb
            // 
            this.retLb.AutoSize = true;
            this.retLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.retLb.Location = new System.Drawing.Point(725, 140);
            this.retLb.Name = "retLb";
            this.retLb.Size = new System.Drawing.Size(158, 32);
            this.retLb.TabIndex = 9;
            this.retLb.Text = "Return Date:";
            this.retLb.Visible = false;
            // 
            // visaRadioBtn
            // 
            this.visaRadioBtn.AutoSize = true;
            this.visaRadioBtn.Location = new System.Drawing.Point(7, 36);
            this.visaRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.visaRadioBtn.Name = "visaRadioBtn";
            this.visaRadioBtn.Size = new System.Drawing.Size(84, 29);
            this.visaRadioBtn.TabIndex = 10;
            this.visaRadioBtn.Text = "VISA";
            this.visaRadioBtn.UseVisualStyleBackColor = true;
            // 
            // payMethod
            // 
            this.payMethod.BackColor = System.Drawing.Color.OldLace;
            this.payMethod.Controls.Add(this.cashRadioBtn);
            this.payMethod.Controls.Add(this.paypalRadioBtn);
            this.payMethod.Controls.Add(this.visaRadioBtn);
            this.payMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.payMethod.Location = new System.Drawing.Point(753, 217);
            this.payMethod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.payMethod.Name = "payMethod";
            this.payMethod.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.payMethod.Size = new System.Drawing.Size(387, 163);
            this.payMethod.TabIndex = 11;
            this.payMethod.TabStop = false;
            this.payMethod.Text = "Payment Methods";
            this.payMethod.Visible = false;
            // 
            // cashRadioBtn
            // 
            this.cashRadioBtn.AutoSize = true;
            this.cashRadioBtn.Location = new System.Drawing.Point(7, 126);
            this.cashRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cashRadioBtn.Name = "cashRadioBtn";
            this.cashRadioBtn.Size = new System.Drawing.Size(94, 29);
            this.cashRadioBtn.TabIndex = 12;
            this.cashRadioBtn.Text = "CASH";
            this.cashRadioBtn.UseVisualStyleBackColor = true;
            // 
            // paypalRadioBtn
            // 
            this.paypalRadioBtn.AutoSize = true;
            this.paypalRadioBtn.Location = new System.Drawing.Point(7, 80);
            this.paypalRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.paypalRadioBtn.Name = "paypalRadioBtn";
            this.paypalRadioBtn.Size = new System.Drawing.Size(115, 29);
            this.paypalRadioBtn.TabIndex = 11;
            this.paypalRadioBtn.Text = "PAYPAL";
            this.paypalRadioBtn.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Red;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1153, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(92, 33);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.backToolStripMenuItem.Text = "<back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(69, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Reservation No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(69, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Client Name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(69, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Car Name: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(69, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Car Model:";
            // 
            // resDetails
            // 
            this.resDetails.BackColor = System.Drawing.Color.OldLace;
            this.resDetails.Controls.Add(this.costLb);
            this.resDetails.Controls.Add(this.label2);
            this.resDetails.Controls.Add(this.regNoLb);
            this.resDetails.Controls.Add(this.reglb);
            this.resDetails.Controls.Add(this.carModelLb);
            this.resDetails.Controls.Add(this.carNameLb);
            this.resDetails.Controls.Add(this.clientNameLb);
            this.resDetails.Controls.Add(this.resNoLb);
            this.resDetails.Controls.Add(this.label4);
            this.resDetails.Controls.Add(this.label7);
            this.resDetails.Controls.Add(this.label5);
            this.resDetails.Controls.Add(this.label6);
            this.resDetails.Location = new System.Drawing.Point(93, 217);
            this.resDetails.Name = "resDetails";
            this.resDetails.Size = new System.Drawing.Size(603, 388);
            this.resDetails.TabIndex = 17;
            this.resDetails.TabStop = false;
            this.resDetails.Visible = false;
            // 
            // costLb
            // 
            this.costLb.AutoSize = true;
            this.costLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.costLb.Location = new System.Drawing.Point(419, 320);
            this.costLb.Name = "costLb";
            this.costLb.Size = new System.Drawing.Size(62, 29);
            this.costLb.TabIndex = 37;
            this.costLb.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(69, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 36;
            this.label2.Text = "Cost:";
            // 
            // regNoLb
            // 
            this.regNoLb.AutoSize = true;
            this.regNoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.regNoLb.Location = new System.Drawing.Point(419, 147);
            this.regNoLb.Name = "regNoLb";
            this.regNoLb.Size = new System.Drawing.Size(95, 29);
            this.regNoLb.TabIndex = 35;
            this.regNoLb.Text = "RegNo";
            // 
            // reglb
            // 
            this.reglb.AutoSize = true;
            this.reglb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reglb.Location = new System.Drawing.Point(69, 147);
            this.reglb.Name = "reglb";
            this.reglb.Size = new System.Drawing.Size(192, 29);
            this.reglb.TabIndex = 34;
            this.reglb.Text = "Registration No: ";
            // 
            // carModelLb
            // 
            this.carModelLb.AutoSize = true;
            this.carModelLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.carModelLb.Location = new System.Drawing.Point(419, 263);
            this.carModelLb.Name = "carModelLb";
            this.carModelLb.Size = new System.Drawing.Size(86, 29);
            this.carModelLb.TabIndex = 33;
            this.carModelLb.Text = "Model";
            // 
            // carNameLb
            // 
            this.carNameLb.AutoSize = true;
            this.carNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.carNameLb.Location = new System.Drawing.Point(419, 204);
            this.carNameLb.Name = "carNameLb";
            this.carNameLb.Size = new System.Drawing.Size(54, 29);
            this.carNameLb.TabIndex = 32;
            this.carNameLb.Text = "Car";
            // 
            // clientNameLb
            // 
            this.clientNameLb.AutoSize = true;
            this.clientNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clientNameLb.Location = new System.Drawing.Point(419, 89);
            this.clientNameLb.Name = "clientNameLb";
            this.clientNameLb.Size = new System.Drawing.Size(81, 29);
            this.clientNameLb.TabIndex = 31;
            this.clientNameLb.Text = "Client";
            // 
            // resNoLb
            // 
            this.resNoLb.AutoSize = true;
            this.resNoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resNoLb.Location = new System.Drawing.Point(419, 27);
            this.resNoLb.Name = "resNoLb";
            this.resNoLb.Size = new System.Drawing.Size(69, 29);
            this.resNoLb.TabIndex = 30;
            this.resNoLb.Text = "0000";
            // 
            // resCost
            // 
            this.resCost.BackColor = System.Drawing.Color.OldLace;
            this.resCost.Controls.Add(this.totalDueLb);
            this.resCost.Controls.Add(this.label8);
            this.resCost.Location = new System.Drawing.Point(753, 519);
            this.resCost.Name = "resCost";
            this.resCost.Size = new System.Drawing.Size(387, 86);
            this.resCost.TabIndex = 18;
            this.resCost.TabStop = false;
            this.resCost.Visible = false;
            // 
            // totalDueLb
            // 
            this.totalDueLb.AutoSize = true;
            this.totalDueLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalDueLb.Location = new System.Drawing.Point(276, 27);
            this.totalDueLb.Name = "totalDueLb";
            this.totalDueLb.Size = new System.Drawing.Size(62, 29);
            this.totalDueLb.TabIndex = 30;
            this.totalDueLb.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(19, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total Due: ";
            // 
            // frmCollectCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1241, 759);
            this.Controls.Add(this.resCost);
            this.Controls.Add(this.resDetails);
            this.Controls.Add(this.payMethod);
            this.Controls.Add(this.retLb);
            this.Controls.Add(this.resDate);
            this.Controls.Add(this.colLb);
            this.Controls.Add(this.findResColBtn);
            this.Controls.Add(this.collectResNoTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.collectBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCollectCar";
            this.Text = "Collect a Car";
            this.Load += new System.EventHandler(this.frmCollectCar_Load);
            this.resDate.ResumeLayout(false);
            this.resDate.PerformLayout();
            this.payMethod.ResumeLayout(false);
            this.payMethod.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.resDetails.ResumeLayout(false);
            this.resDetails.PerformLayout();
            this.resCost.ResumeLayout(false);
            this.resCost.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox collectResNoTxtBox;
        private System.Windows.Forms.Button findResColBtn;
        private System.Windows.Forms.Button collectBtn;
        private System.Windows.Forms.Label colLb;
        private System.Windows.Forms.GroupBox resDate;
        private System.Windows.Forms.Label collectDateLb;
        private System.Windows.Forms.Label retLb;
        private System.Windows.Forms.Label returnDateLb;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label separator;
        private System.Windows.Forms.RadioButton visaRadioBtn;
        private System.Windows.Forms.GroupBox payMethod;
        private System.Windows.Forms.RadioButton paypalRadioBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox resDetails;
        private System.Windows.Forms.Label carModelLb;
        private System.Windows.Forms.Label carNameLb;
        private System.Windows.Forms.Label clientNameLb;
        private System.Windows.Forms.Label resNoLb;
        private System.Windows.Forms.GroupBox resCost;
        private System.Windows.Forms.Label totalDueLb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton cashRadioBtn;
        private System.Windows.Forms.Label regNoLb;
        private System.Windows.Forms.Label reglb;
        private System.Windows.Forms.Label costLb;
        private System.Windows.Forms.Label label2;
    }
}