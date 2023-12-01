
namespace CarRentaSYS
{
    partial class FrmAddCustomer
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
            this.newClientBox1 = new System.Windows.Forms.GroupBox();
            this.addClientBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.custTelTxt = new System.Windows.Forms.TextBox();
            this.custEmailTxt = new System.Windows.Forms.TextBox();
            this.custIDTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.custAddTxt = new System.Windows.Forms.TextBox();
            this.custZipTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.custCountryTxt = new System.Windows.Forms.TextBox();
            this.custTownTxt = new System.Windows.Forms.TextBox();
            this.custNameTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerLabel = new System.Windows.Forms.Label();
            this.managerIDTxt = new System.Windows.Forms.TextBox();
            this.newClientBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newClientBox1
            // 
            this.newClientBox1.Controls.Add(this.addClientBtn);
            this.newClientBox1.Controls.Add(this.label14);
            this.newClientBox1.Controls.Add(this.custTelTxt);
            this.newClientBox1.Controls.Add(this.custEmailTxt);
            this.newClientBox1.Controls.Add(this.custIDTxt);
            this.newClientBox1.Controls.Add(this.label1);
            this.newClientBox1.Controls.Add(this.custAddTxt);
            this.newClientBox1.Controls.Add(this.custZipTxt);
            this.newClientBox1.Controls.Add(this.label5);
            this.newClientBox1.Controls.Add(this.custCountryTxt);
            this.newClientBox1.Controls.Add(this.custTownTxt);
            this.newClientBox1.Controls.Add(this.custNameTxt);
            this.newClientBox1.Controls.Add(this.label10);
            this.newClientBox1.Controls.Add(this.label9);
            this.newClientBox1.Controls.Add(this.label8);
            this.newClientBox1.Controls.Add(this.label7);
            this.newClientBox1.Controls.Add(this.label6);
            this.newClientBox1.Controls.Add(this.label3);
            this.newClientBox1.Controls.Add(this.label2);
            this.newClientBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newClientBox1.Location = new System.Drawing.Point(33, 61);
            this.newClientBox1.Margin = new System.Windows.Forms.Padding(2);
            this.newClientBox1.Name = "newClientBox1";
            this.newClientBox1.Padding = new System.Windows.Forms.Padding(2);
            this.newClientBox1.Size = new System.Drawing.Size(602, 352);
            this.newClientBox1.TabIndex = 1;
            this.newClientBox1.TabStop = false;
            this.newClientBox1.Text = "Enter Client Details";
            this.newClientBox1.Enter += new System.EventHandler(this.newClientBox1_Enter);
            // 
            // addClientBtn
            // 
            this.addClientBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addClientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addClientBtn.Location = new System.Drawing.Point(476, 278);
            this.addClientBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addClientBtn.Name = "addClientBtn";
            this.addClientBtn.Size = new System.Drawing.Size(113, 24);
            this.addClientBtn.TabIndex = 2;
            this.addClientBtn.Text = "Add";
            this.addClientBtn.UseVisualStyleBackColor = false;
            this.addClientBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(23, 211);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "Zip Code";
            // 
            // custTelTxt
            // 
            this.custTelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.custTelTxt.Location = new System.Drawing.Point(170, 282);
            this.custTelTxt.Margin = new System.Windows.Forms.Padding(2);
            this.custTelTxt.Name = "custTelTxt";
            this.custTelTxt.Size = new System.Drawing.Size(162, 24);
            this.custTelTxt.TabIndex = 6;
            // 
            // custEmailTxt
            // 
            this.custEmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.custEmailTxt.Location = new System.Drawing.Point(170, 247);
            this.custEmailTxt.Margin = new System.Windows.Forms.Padding(2);
            this.custEmailTxt.Name = "custEmailTxt";
            this.custEmailTxt.Size = new System.Drawing.Size(252, 24);
            this.custEmailTxt.TabIndex = 5;
            // 
            // custIDTxt
            // 
            this.custIDTxt.Enabled = false;
            this.custIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.custIDTxt.Location = new System.Drawing.Point(170, 30);
            this.custIDTxt.Margin = new System.Windows.Forms.Padding(2);
            this.custIDTxt.Name = "custIDTxt";
            this.custIDTxt.Size = new System.Drawing.Size(98, 26);
            this.custIDTxt.TabIndex = 2;
            this.custIDTxt.TextChanged += new System.EventHandler(this.newTxtBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer  ID: ";
            // 
            // custAddTxt
            // 
            this.custAddTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.custAddTxt.Location = new System.Drawing.Point(170, 115);
            this.custAddTxt.Margin = new System.Windows.Forms.Padding(2);
            this.custAddTxt.Name = "custAddTxt";
            this.custAddTxt.Size = new System.Drawing.Size(252, 24);
            this.custAddTxt.TabIndex = 1;
            // 
            // custZipTxt
            // 
            this.custZipTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.custZipTxt.Location = new System.Drawing.Point(170, 213);
            this.custZipTxt.Margin = new System.Windows.Forms.Padding(2);
            this.custZipTxt.Name = "custZipTxt";
            this.custZipTxt.Size = new System.Drawing.Size(110, 24);
            this.custZipTxt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(23, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address:";
            // 
            // custCountryTxt
            // 
            this.custCountryTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.custCountryTxt.Location = new System.Drawing.Point(170, 179);
            this.custCountryTxt.Margin = new System.Windows.Forms.Padding(2);
            this.custCountryTxt.Name = "custCountryTxt";
            this.custCountryTxt.Size = new System.Drawing.Size(162, 24);
            this.custCountryTxt.TabIndex = 3;
            // 
            // custTownTxt
            // 
            this.custTownTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.custTownTxt.Location = new System.Drawing.Point(170, 148);
            this.custTownTxt.Margin = new System.Windows.Forms.Padding(2);
            this.custTownTxt.Name = "custTownTxt";
            this.custTownTxt.Size = new System.Drawing.Size(162, 24);
            this.custTownTxt.TabIndex = 2;
            // 
            // custNameTxt
            // 
            this.custNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.custNameTxt.Location = new System.Drawing.Point(170, 85);
            this.custNameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.custNameTxt.Name = "custNameTxt";
            this.custNameTxt.Size = new System.Drawing.Size(162, 24);
            this.custNameTxt.TabIndex = 0;
            this.custNameTxt.TextChanged += new System.EventHandler(this.custNameTxt_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(23, 282);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tel No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(23, 247);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Email Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(23, 181);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(25, 179);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(23, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Town";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(23, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Red;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(607, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(60, 17);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(56, 15);
            this.backToolStripMenuItem.Text = "<back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click_1);
            // 
            // managerLabel
            // 
            this.managerLabel.AutoSize = true;
            this.managerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.managerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.managerLabel.Location = new System.Drawing.Point(33, 9);
            this.managerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.managerLabel.Name = "managerLabel";
            this.managerLabel.Size = new System.Drawing.Size(106, 20);
            this.managerLabel.TabIndex = 14;
            this.managerLabel.Text = "Manager ID: ";
            this.managerLabel.Click += new System.EventHandler(this.managerLabel_Click);
            // 
            // managerIDTxt
            // 
            this.managerIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.managerIDTxt.Location = new System.Drawing.Point(163, 9);
            this.managerIDTxt.Margin = new System.Windows.Forms.Padding(2);
            this.managerIDTxt.Name = "managerIDTxt";
            this.managerIDTxt.Size = new System.Drawing.Size(128, 26);
            this.managerIDTxt.TabIndex = 15;
            // 
            // FrmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(660, 444);
            this.Controls.Add(this.managerLabel);
            this.Controls.Add(this.managerIDTxt);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.newClientBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAddCustomer";
            this.Text = "New Client Account";
            this.Load += new System.EventHandler(this.FrmAddClient_Load);
            this.newClientBox1.ResumeLayout(false);
            this.newClientBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox newClientBox1;
        private System.Windows.Forms.TextBox custTelTxt;
        private System.Windows.Forms.TextBox custEmailTxt;
        private System.Windows.Forms.TextBox custZipTxt;
        private System.Windows.Forms.TextBox custCountryTxt;
        private System.Windows.Forms.TextBox custTownTxt;
        private System.Windows.Forms.TextBox custAddTxt;
        private System.Windows.Forms.TextBox custNameTxt;
        private System.Windows.Forms.TextBox custIDTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addClientBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label managerLabel;
        private System.Windows.Forms.TextBox managerIDTxt;
    }
}