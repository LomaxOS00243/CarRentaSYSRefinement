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
    public partial class frmYearlyRevenue : Form
    {
        public frmYearlyRevenue()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void SendBtn_Click(object sender, EventArgs e)
        {

        }

        private void frmInvoices_Load(object sender, EventArgs e)
        {

        }

        private void yearlyRevYearCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] month = new string[12]; //{ "JAN", "MAR", "TATA" };
            double[] amount = new double[12];//{ 23, 32.3, 23.4 };

            //display any year th user input
            yearRevLb.Text = " Yearly Revenue " + yearlyRevYearCmb.Text;
            yearRevLb.Visible = true;
            yearlyRevDataG.Visible = true;

            //Retrieves yearly revenue 
            DataTable dt = Invoices.getYearlyRevenue(yearlyRevYearCmb.Text.Substring(2,3));

            if(dt.Rows.Count > 0)
            {
                for (int i = 0; i < 12; i++)
                {
                    month[i] = Invoices.getMonthAsString(Convert.ToInt32(dt.Rows[i][0]));
                    amount[i] = Convert.ToDouble(dt.Rows[i][1]);
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    amount[Convert.ToInt32(dt.Rows[i][0])-1] = Convert.ToDouble(dt.Rows[i][1]);
                }
                yearlyRevDataG.Columns.Add("Month", "Month");
                yearlyRevDataG.Columns.Add("Amount", "Amount");

                for (int j = 0; j < amount.Length; j++)
                {
                    yearlyRevDataG.Rows.Add(new object[] { month[j], amount[j] });
                }
            }
            else
            {
                MessageBox.Show("Sorry! There's not revenue for this year","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMnu frmMain = new frmMainMnu();
            frmMain.Show();
        }
    }
}
