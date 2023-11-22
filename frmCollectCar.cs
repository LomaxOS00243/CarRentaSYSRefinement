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
    public partial class frmCollectCar : Form
    {
        public frmCollectCar()
        {
            InitializeComponent();
        }

        private void findResColBtn_Click(object sender, EventArgs e)
        {
            bool isValidChar;
            int checkTextBox;
            isValidChar = int.TryParse(collectResNoTxtBox.Text, out checkTextBox);

            
            //check if resNo txtBox is not empty
            if (collectResNoTxtBox.Text.Equals(""))
            {
                MessageBox.Show("Please enter reservation number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            //check if resNo txtBox has required data
            else if (!isValidChar)
            {
                MessageBox.Show("Please enter the correct Reservation number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                colLb.Visible = false;
                retLb.Visible = false;
                resDate.Visible = false;
                resDetails.Visible = false;
                resCost.Visible = false;
                payMethod.Visible = false;
                collectBtn.Visible = false;
                visaRadioBtn.Checked = false;
                paypalRadioBtn.Checked = false;
                collectResNoTxtBox.Focus();
            }
            //chek if the reservation has already been collected
            else if (Reservation.isCollectedReservation(Convert.ToInt32(collectResNoTxtBox.Text)))
            {

                MessageBox.Show("Sorry! This Reservation has been collected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                colLb.Visible = false;
                retLb.Visible = false;
                resDate.Visible = false;
                resDetails.Visible = false;
                resCost.Visible = false;
                payMethod.Visible = false;
                collectBtn.Visible = false;
                visaRadioBtn.Checked = false;
                paypalRadioBtn.Checked = false;
                collectResNoTxtBox.Focus();
            }
            else if (Reservation.isReturnedReservation(Convert.ToInt32(collectResNoTxtBox.Text)))
            {

                MessageBox.Show("Sorry! This Reservation has not yet been collected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                colLb.Visible = false;
                retLb.Visible = false;
                resDate.Visible = false;
                resDetails.Visible = false;
                resCost.Visible = false;
                payMethod.Visible = false;
                collectBtn.Visible = false;
                visaRadioBtn.Checked = false;
                paypalRadioBtn.Checked = false;
                collectResNoTxtBox.Focus();
            }
            else if (!Reservation.isValidReservationNo(Convert.ToInt32(collectResNoTxtBox.Text)))
            {
                MessageBox.Show("Sorry! This Reservation is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                colLb.Visible = false;
                retLb.Visible = false;
                resDate.Visible = false;
                resDetails.Visible = false;
                resCost.Visible = false;
                payMethod.Visible = false;
                collectBtn.Visible = false;
                visaRadioBtn.Checked = false;
                paypalRadioBtn.Checked = false;
                collectResNoTxtBox.Focus();
            }
            else
            {
                //Retrieve reservation datails from the system for car collection
                DataSet da = Reservation.getReservationDetails(Convert.ToInt32(collectResNoTxtBox.Text));

                for (int i = 0; i < da.Tables[0].Rows.Count; i++)
                {

                    resNoLb.Text = String.Concat("0000") + collectResNoTxtBox.Text;
                    clientNameLb.Text = Convert.ToString(da.Tables[0].Rows[i][0]);
                    regNoLb.Text = Convert.ToString(da.Tables[0].Rows[i][1]);
                    carNameLb.Text = Convert.ToString(da.Tables[0].Rows[i][2]); 
                    carModelLb.Text = Convert.ToString(da.Tables[0].Rows[i][3]);
                    collectDateLb.Text = String.Format("{0:dd-MMM-yy}",da.Tables[0].Rows[i][4]);
                    returnDateLb.Text = String.Format("{0:dd-MMM-yy}", da.Tables[0].Rows[i][5]);
                    costLb.Text = String.Concat("€ ")+Convert.ToString(da.Tables[0].Rows[i][6]);
                }
                totalDueLb.Text = costLb.Text;

                colLb.Visible = true;
                retLb.Visible = true;
                resDate.Visible = true;
                resCost.Visible = true;
                resDetails.Visible = true;
                payMethod.Visible = true;
                collectBtn.Visible = true;
            }
                
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMnu frmMain = new frmMainMnu();
            frmMain.Show();

        }

        private void listResSummary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void collectBtn_Click(object sender, EventArgs e)
        {


            if(visaRadioBtn.Checked == false && paypalRadioBtn.Checked == false && cashRadioBtn.Checked == false)
            {
                MessageBox.Show("Please provide a payment method", "Payment methods", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
               
               Reservation.setStatusToCollect(Convert.ToInt32(collectResNoTxtBox.Text));
                if (visaRadioBtn.Checked == true || paypalRadioBtn.Checked == true || cashRadioBtn.Checked == true)
                {
                    MessageBox.Show("Thanks! The payment will be made after the car is returned! ", "Payment Method", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    MessageBox.Show("The car is ready for collection", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    collectResNoTxtBox.Clear();
                    colLb.Visible = false;
                    retLb.Visible = false;
                    resDate.Visible = false;
                    resDetails.Visible = false;
                    resCost.Visible = false;
                    payMethod.Visible = false;
                    collectBtn.Visible = false;
                    visaRadioBtn.Checked = false;
                    paypalRadioBtn.Checked = false;
                }

            }
            


        }

        private void frmCollectCar_Load(object sender, EventArgs e)
        {

        }
    }
}
