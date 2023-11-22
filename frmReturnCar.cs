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
    public partial class frmReturnCar : Form
    {
        public frmReturnCar()
        {
            InitializeComponent();
        }

        private void findResRetBtn_Click(object sender, EventArgs e)
        {
            int checkTextBox;
            bool isValidChar = int.TryParse(returnResNoTxtBox.Text, out checkTextBox);


            if (returnResNoTxtBox.Text.Equals(""))
            {
                MessageBox.Show("Please enter reservation number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                returnResNoTxtBox.Focus();
            }
            else if (!isValidChar)
            {
                MessageBox.Show("Please Enter The Correct Reservation Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                colLb.Visible = false;
                retLb.Visible = false;
                resDate.Visible = false;
                resDetails.Visible = false;
                returnBtn.Visible = false;
                resFineGrpBox.Visible = false;
                returnResNoTxtBox.Focus();
            }
            else if (!Reservation.isCollectedReservation(Convert.ToInt32(returnResNoTxtBox.Text)))
            {

                MessageBox.Show("Sorry! This Reservation hasn't been collected yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                colLb.Visible = false;
                retLb.Visible = false;
                resDate.Visible = false;
                resDetails.Visible = false;
                returnBtn.Visible = false;
                resFineGrpBox.Visible = false;
                returnResNoTxtBox.Focus();
            }
            else if (Reservation.isReturnedReservation(Convert.ToInt32(returnResNoTxtBox.Text)))
            {

                MessageBox.Show("Sorry! This Reservation has already been returned!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                colLb.Visible = false;
                retLb.Visible = false;
                resDate.Visible = false;
                resDetails.Visible = false;
                returnBtn.Visible = false;
                resFineGrpBox.Visible = false;
                returnResNoTxtBox.Focus();
            }

            else if (!Reservation.isValidReservationNo(Convert.ToInt32(returnResNoTxtBox.Text)))
            {
                MessageBox.Show("Sorry! This Reservation is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                colLb.Visible = false;
                retLb.Visible = false;
                resDate.Visible = false;
                resDetails.Visible = false;
                returnBtn.Visible = false;
                resFineGrpBox.Visible = false;
                returnResNoTxtBox.Focus();
            }
            else
            {
                //Retrieve reservation datails from the system
                DataSet da = Reservation.getReservationDetails(Convert.ToInt32(returnResNoTxtBox.Text));

                for (int i = 0; i < da.Tables[0].Rows.Count; i++)
                {

                    resNoLb.Text = String.Concat("0000") + returnResNoTxtBox.Text;
                    clientNameLb.Text = Convert.ToString(da.Tables[0].Rows[i][0]);
                    regNoLb.Text = Convert.ToString(da.Tables[0].Rows[i][1]);
                    carNameLb.Text = Convert.ToString(da.Tables[0].Rows[i][2]);
                    carModelLb.Text = Convert.ToString(da.Tables[0].Rows[i][3]);
                    collectDateLb.Text = String.Format("{0:dd-MMM-yy}", da.Tables[0].Rows[i][4]);
                    returnDateLb.Text = String.Format("{0:dd-MMM-yy}", da.Tables[0].Rows[i][5]);
                }
                

                colLb.Visible = true;
                retLb.Visible = true;
                resDate.Visible = true;
                resDetails.Visible = true;
                returnBtn.Visible = true;
                resFineGrpBox.Visible = true;
            }

      
    
    }

        

        private void returnBtn_Click(object sender, EventArgs e)
        {
            double checkFine;
            bool isValidFine = double.TryParse(fineTxtBox.Text,out checkFine);

            if (fineTxtBox.Text.Equals(""))
            {
                //if we are here, that means, there is not any fee payment.
                //the system check if today's the first day of the month to launch the issue invoice form 
                if (Invoices.runInvoiceForm())
                {
                    Reservation.setStatusToReturn(Convert.ToInt32(returnResNoTxtBox.Text));

                    this.Hide();
                    frmIssueInvoice issueInvoice = new frmIssueInvoice();
                    issueInvoice.Show();
                }
                else
                {

                    MessageBox.Show("Thanks! The car is returned", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("The Payment will be made on the first day of next month", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //set reservation status to return
                    Reservation.setStatusToReturn(Convert.ToInt32(returnResNoTxtBox.Text));


                    returnResNoTxtBox.Clear();
                    colLb.Visible = false;
                    retLb.Visible = false;
                    resDate.Visible = false;
                    resDetails.Visible = false;
                    returnBtn.Visible = false;
                    resFineGrpBox.Visible = false;
                }
                

                
            }
            else
            {
        
                //Check if the user enter a value amount of fine
                if (!isValidFine)
                 {
                     MessageBox.Show("Please enter the correct amount", "Invalid Fine!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     fineTxtBox.Focus();
                 }
                 else
                 {
                    //check if today's the first day of the month to launch the issue invoice form 
                    if (Invoices.runInvoiceForm())
                    {
                        
                        Reservation.setStatusToReturn(Convert.ToInt32(returnResNoTxtBox.Text));

                        this.Hide();
                        frmIssueInvoice issueInvoice = new frmIssueInvoice();
                        issueInvoice.Show();
                    }
                    else
                    {
                        Reservation.setStatusToReturn(Convert.ToInt32(returnResNoTxtBox.Text));

                        //set fine in the reservation file
                        Reservation.setFine(Convert.ToInt32(returnResNoTxtBox.Text), Convert.ToDouble(fineTxtBox.Text));


                        MessageBox.Show("Thanks! The car is returned", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MessageBox.Show("The Payment will be made on the first day of next month", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        returnResNoTxtBox.Clear();
                        colLb.Visible = false;
                        retLb.Visible = false;
                        resDate.Visible = false;
                        resDetails.Visible = false;
                        returnBtn.Visible = false;
                        resFineGrpBox.Visible = false;
                    }
                    
                                 
                 }                                 
            }          
        }
        private void totalLab_Click(object sender, EventArgs e)
        {
           
        }

        private void fine_TextChanged(object sender, EventArgs e)
        {
            /* double fineDouble=0;
            while (fine.TextLength != 0)
             {
                 fineDouble = Convert.ToDouble(fine.ToString());

                totalLab.Text = (totalLab.Text + fineDouble).ToString();
            }*/
            

        }

        private void frmReturnCar_Load(object sender, EventArgs e)
        {

        }

        private void returnResNoTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMnu frmMain = new frmMainMnu();
            frmMain.Show();
        }
    }
}
