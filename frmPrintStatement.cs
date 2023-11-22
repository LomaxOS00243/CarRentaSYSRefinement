using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentaSYS
{
    public partial class frmPrintStatement : Form
    {
        public frmPrintStatement()
        {
            InitializeComponent();
        }

        private void printPreviewBtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // Dim font1 As New Font("arial", 16, FontStyle.Regular);
        }

        private void printClientBtn_Click(object sender, EventArgs e)
        {
            if (printClientTxtBox.Text.Equals(""))
            {
                MessageBox.Show("You must enter the client ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                printClientTxtBox.Focus();
                return;
            }
            else
                stateGrpBox.Visible = true;
        }

        

        private void frmPrintStatement_Load(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMnu backForm = new frmMainMnu();
            backForm.Show();
        }
    }
}
