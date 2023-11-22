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
    public partial class frmCancelReservation : Form
    {
        public frmCancelReservation()
        {
            InitializeComponent();
        }

        private void cancelResBtn_Click(object sender, EventArgs e)
        {

        }

        private void frmCancelReservation_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void findResBtn_Click(object sender, EventArgs e)
        {
            bool isValidChar;
            int checkTextBox;
            isValidChar = int.TryParse(findResTxtBox.Text, out checkTextBox);
            




            if (findResTxtBox.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Reservation Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                findResTxtBox.Focus();

            }
            else if (!isValidChar)
            {
                MessageBox.Show("Please Enter The Correct Reservation Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                findResTxtBox.Focus();
            }
            else if (!Reservation.isValidReservationNo(Convert.ToInt32(findResTxtBox.Text)))
            {
             
                MessageBox.Show("Sorry This Reservation Is No Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DialogResult make = MessageBox.Show("Would you like to make a new reservation", "Confrimation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (make == DialogResult.Yes)
                {
                    this.Hide();
                    frmMakeReservation makeRes = new frmMakeReservation();
                    makeRes.Show();
                }
                else
                {
                    findResTxtBox.Focus();
                }


                //findResTxtBox.Focus();
            }
            else
            {
                //Retrieve reservation datails from the system
                 DataSet da = Reservation.getReservationDetails(Convert.ToInt32(findResTxtBox.Text));

                 for (int i = 0; i < da.Tables[0].Rows.Count; i++)
                 {

                     resNoLb.Text = String.Concat("0000")+findResTxtBox.Text;
                     clientNamLbl.Text = Convert.ToString(da.Tables[0].Rows[i][0]);
                     regNoLb.Text = Convert.ToString(da.Tables[0].Rows[i][1]);
                     carInfoLbl.Text = Convert.ToString(da.Tables[0].Rows[i][2]) + " " + Convert.ToString(da.Tables[0].Rows[i][3]); 
                     collectLbl.Text = String.Format("{0:dd-MMM-yy}",da.Tables[0].Rows[i][4]);
                     returnLbl.Text = String.Format("{0:dd-MMM-yy}",da.Tables[0].Rows[i][5]);
                 }
                 totalCostLbl.Text = cancelFeeLbl.Text;
                 resSumGrBox.Visible = true;
            }
                
            
                
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult cancel = MessageBox.Show("Are you sure you want to cancel this reservation", "Confrimation", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Information);

            if (cancel == DialogResult.Yes)
            {
                Reservation.cancelReservation(Convert.ToInt32(findResTxtBox.Text));
                MessageBox.Show("Your reservation has been cancel", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);

                findResTxtBox.Focus();
                findResTxtBox.Clear();
                resSumGrBox.Visible = false;
            }
        }

        
        private void canclCostLb_Click(object sender, EventArgs e)
        {

        }

        private void separator_Click(object sender, EventArgs e)
        {


        }

        private void backToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
                this.Hide();
                frmMainMnu backMainMnu = new frmMainMnu();
                backMainMnu.Show();
            
        }
    }
}
