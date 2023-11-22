
namespace CarRentaSYS
{
    partial class frmReturnCar
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
            this.returnDateLb = new System.Windows.Forms.Label();
            this.collectDateLb = new System.Windows.Forms.Label();
            this.findResRetBtn = new System.Windows.Forms.Button();
            this.returnResNoTxtBox = new System.Windows.Forms.TextBox();
            this.returnBtn = new System.Windows.Forms.Button();
            this.resDetails = new System.Windows.Forms.GroupBox();
            this.regNoLb = new System.Windows.Forms.Label();
            this.reglb = new System.Windows.Forms.Label();
            this.carModelLb = new System.Windows.Forms.Label();
            this.carNameLb = new System.Windows.Forms.Label();
            this.clientNameLb = new System.Windows.Forms.Label();
            this.resNoLb = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.resDate = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.retLb = new System.Windows.Forms.Label();
            this.colLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fineTxtBox = new System.Windows.Forms.TextBox();
            this.resFineGrpBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalDue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resDetails.SuspendLayout();
            this.resDate.SuspendLayout();
            this.resFineGrpBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnDateLb
            // 
            this.returnDateLb.AutoSize = true;
            this.returnDateLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnDateLb.Location = new System.Drawing.Point(37, 107);
            this.returnDateLb.Name = "returnDateLb";
            this.returnDateLb.Size = new System.Drawing.Size(143, 29);
            this.returnDateLb.TabIndex = 29;
            this.returnDateLb.Text = "00-00-0000";
            // 
            // collectDateLb
            // 
            this.collectDateLb.AutoSize = true;
            this.collectDateLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.collectDateLb.Location = new System.Drawing.Point(37, 28);
            this.collectDateLb.Name = "collectDateLb";
            this.collectDateLb.Size = new System.Drawing.Size(129, 29);
            this.collectDateLb.TabIndex = 0;
            this.collectDateLb.Text = "00-00-000";
            // 
            // findResRetBtn
            // 
            this.findResRetBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.findResRetBtn.Location = new System.Drawing.Point(456, 152);
            this.findResRetBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.findResRetBtn.Name = "findResRetBtn";
            this.findResRetBtn.Size = new System.Drawing.Size(114, 44);
            this.findResRetBtn.TabIndex = 16;
            this.findResRetBtn.Text = "Ok";
            this.findResRetBtn.UseVisualStyleBackColor = false;
            this.findResRetBtn.Click += new System.EventHandler(this.findResRetBtn_Click);
            // 
            // returnResNoTxtBox
            // 
            this.returnResNoTxtBox.Location = new System.Drawing.Point(354, 54);
            this.returnResNoTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.returnResNoTxtBox.Name = "returnResNoTxtBox";
            this.returnResNoTxtBox.Size = new System.Drawing.Size(216, 31);
            this.returnResNoTxtBox.TabIndex = 14;
            this.returnResNoTxtBox.TextChanged += new System.EventHandler(this.returnResNoTxtBox_TextChanged);
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.returnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnBtn.Location = new System.Drawing.Point(385, 673);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(459, 56);
            this.returnBtn.TabIndex = 15;
            this.returnBtn.Text = "Ok";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Visible = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // resDetails
            // 
            this.resDetails.BackColor = System.Drawing.Color.OldLace;
            this.resDetails.Controls.Add(this.regNoLb);
            this.resDetails.Controls.Add(this.reglb);
            this.resDetails.Controls.Add(this.carModelLb);
            this.resDetails.Controls.Add(this.carNameLb);
            this.resDetails.Controls.Add(this.clientNameLb);
            this.resDetails.Controls.Add(this.resNoLb);
            this.resDetails.Controls.Add(this.label12);
            this.resDetails.Controls.Add(this.label15);
            this.resDetails.Controls.Add(this.label16);
            this.resDetails.Controls.Add(this.label17);
            this.resDetails.Location = new System.Drawing.Point(70, 232);
            this.resDetails.Name = "resDetails";
            this.resDetails.Size = new System.Drawing.Size(603, 326);
            this.resDetails.TabIndex = 23;
            this.resDetails.TabStop = false;
            this.resDetails.Visible = false;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(69, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 29);
            this.label12.TabIndex = 13;
            this.label12.Text = "Reservation No:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(69, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 29);
            this.label15.TabIndex = 16;
            this.label15.Text = "Car Model:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(69, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(158, 29);
            this.label16.TabIndex = 14;
            this.label16.Text = "Client Name: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(69, 204);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 29);
            this.label17.TabIndex = 15;
            this.label17.Text = "Car Name: ";
            // 
            // resDate
            // 
            this.resDate.BackColor = System.Drawing.Color.OldLace;
            this.resDate.Controls.Add(this.returnDateLb);
            this.resDate.Controls.Add(this.label18);
            this.resDate.Controls.Add(this.label19);
            this.resDate.Controls.Add(this.collectDateLb);
            this.resDate.Location = new System.Drawing.Point(874, 35);
            this.resDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resDate.Name = "resDate";
            this.resDate.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resDate.Size = new System.Drawing.Size(228, 161);
            this.resDate.TabIndex = 30;
            this.resDate.TabStop = false;
            this.resDate.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(-641, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(205, 34);
            this.label18.TabIndex = 28;
            this.label18.Text = "Client Name: ";
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(29, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(161, 2);
            this.label19.TabIndex = 27;
            // 
            // retLb
            // 
            this.retLb.AutoSize = true;
            this.retLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.retLb.Location = new System.Drawing.Point(710, 143);
            this.retLb.Name = "retLb";
            this.retLb.Size = new System.Drawing.Size(158, 32);
            this.retLb.TabIndex = 31;
            this.retLb.Text = "Return Date:";
            this.retLb.Visible = false;
            // 
            // colLb
            // 
            this.colLb.AutoSize = true;
            this.colLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.colLb.Location = new System.Drawing.Point(709, 63);
            this.colLb.Name = "colLb";
            this.colLb.Size = new System.Drawing.Size(159, 32);
            this.colLb.TabIndex = 30;
            this.colLb.Text = "Collect Date:";
            this.colLb.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 30);
            this.label1.TabIndex = 32;
            this.label1.Text = "Enter Reservation number: ";
            // 
            // fineTxtBox
            // 
            this.fineTxtBox.Location = new System.Drawing.Point(201, 54);
            this.fineTxtBox.Name = "fineTxtBox";
            this.fineTxtBox.Size = new System.Drawing.Size(162, 31);
            this.fineTxtBox.TabIndex = 33;
            this.fineTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resFineGrpBox
            // 
            this.resFineGrpBox.BackColor = System.Drawing.Color.OldLace;
            this.resFineGrpBox.Controls.Add(this.label2);
            this.resFineGrpBox.Controls.Add(this.totalDue);
            this.resFineGrpBox.Controls.Add(this.label3);
            this.resFineGrpBox.Controls.Add(this.fineTxtBox);
            this.resFineGrpBox.Controls.Add(this.label8);
            this.resFineGrpBox.Location = new System.Drawing.Point(721, 314);
            this.resFineGrpBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resFineGrpBox.Name = "resFineGrpBox";
            this.resFineGrpBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resFineGrpBox.Size = new System.Drawing.Size(381, 244);
            this.resFineGrpBox.TabIndex = 31;
            this.resFineGrpBox.TabStop = false;
            this.resFineGrpBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 36;
            this.label2.Text = "Enter Fine: ";
            // 
            // totalDue
            // 
            this.totalDue.AutoSize = true;
            this.totalDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalDue.Location = new System.Drawing.Point(280, 177);
            this.totalDue.Name = "totalDue";
            this.totalDue.Size = new System.Drawing.Size(83, 29);
            this.totalDue.TabIndex = 35;
            this.totalDue.Text = "€ 0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(-641, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 34);
            this.label3.TabIndex = 28;
            this.label3.Text = "Client Name: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(17, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 29);
            this.label8.TabIndex = 34;
            this.label8.Text = "Total Due: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Red;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1134, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(92, 33);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.backToolStripMenuItem.Text = "<back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click_1);
            // 
            // frmReturnCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1219, 792);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.resFineGrpBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.retLb);
            this.Controls.Add(this.resDate);
            this.Controls.Add(this.colLb);
            this.Controls.Add(this.resDetails);
            this.Controls.Add(this.findResRetBtn);
            this.Controls.Add(this.returnResNoTxtBox);
            this.Controls.Add(this.returnBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReturnCar";
            this.Text = "Return a Car";
            this.Load += new System.EventHandler(this.frmReturnCar_Load);
            this.resDetails.ResumeLayout(false);
            this.resDetails.PerformLayout();
            this.resDate.ResumeLayout(false);
            this.resDate.PerformLayout();
            this.resFineGrpBox.ResumeLayout(false);
            this.resFineGrpBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label returnDateLb;
        private System.Windows.Forms.Label collectDateLb;
        private System.Windows.Forms.Button findResRetBtn;
        private System.Windows.Forms.TextBox returnResNoTxtBox;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.GroupBox resDetails;
        private System.Windows.Forms.Label regNoLb;
        private System.Windows.Forms.Label reglb;
        private System.Windows.Forms.Label carModelLb;
        private System.Windows.Forms.Label carNameLb;
        private System.Windows.Forms.Label clientNameLb;
        private System.Windows.Forms.Label resNoLb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox resDate;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label retLb;
        private System.Windows.Forms.Label colLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fineTxtBox;
        private System.Windows.Forms.GroupBox resFineGrpBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalDue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}