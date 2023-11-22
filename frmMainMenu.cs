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
    public partial class frmMainMnu : Form
    {
        public frmMainMnu()
        {
            InitializeComponent();
        }

        private void nCToolStripMnu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddClient addForm = new frmAddClient();
            addForm.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

        private void closeClAccToolStripMnu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCloseClient closeClient = new frmCloseClient();
            closeClient.Show();
        }

        private void printClStatToolStripMnu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrintStatement printStatement = new frmPrintStatement();
            printStatement.Show();
        }

        private void makeResToolStripMnu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMakeReservation showForm = new frmMakeReservation();
            showForm.Show();
        }

        private void cancelResToolStripMnu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelReservation cancelRes = new frmCancelReservation();
            cancelRes.Show();
        }

        private void cCarToolStripMnu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCollectCar frmCollect = new frmCollectCar();
            frmCollect.Show();
        }

        private void rCarToolStripMnu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturnCar frmReturn = new frmReturnCar();
            frmReturn.Show();
        }

        private void picBox_Click(object sender, EventArgs e)
        {

        }

        private void issueInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Invoices.runInvoiceForm())
            {
                this.Hide();
                frmIssueInvoice frmInvoice = new frmIssueInvoice();
                frmInvoice.Show();
            }
            else
            {
                MessageBox.Show("The Issue Invoices can only be made on the first day of next month","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyRevenue frmYearlyRevenue = new frmYearlyRevenue();
            frmYearlyRevenue.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmMainMnu_Load(object sender, EventArgs e)
        {

        }

        private void clToolStripMnu_Click(object sender, EventArgs e)
        {

        }
    }
}
