using CarRentaSYS.BusinessLogic.CustomerLogic;
using CarRentaSYS.BusinessLogicLayer.CustomerLogic;
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
    public partial class FrmCloseCustomer : Form
    {
        private readonly CustomerController customerController = new CustomerController();
        private readonly CustomerInputsValidator inputsValidator = new CustomerInputsValidator();

        public FrmCloseCustomer()
        {
            InitializeComponent();
        }

        private void FindCustomerAccountBtn_Click(object sender, EventArgs e)
        {
            
            if (!inputsValidator.VerifyEmptyField(managerIDTxt, new ManagerIDValidationStrategy()))
            { return; }

            if (!inputsValidator.VerifyEmptyField(custIDTxt, new IDValidationStrategy()))
            { return; }


            if (!IsManagerAuthorized())
            {
                customerController.DisplayErrorMessage("Unauthorised manager ID", "Authorization Error");
                return;
            }

            if (!IsAccountOpened())
            {
                customerController.DisplayErrorMessage("Account already closed or No created yet", "Account Error");
                return;
            }

            DisplayCustomerAccount();

        }

        private bool IsManagerAuthorized()
        {
            try
            {
                int managerId = Convert.ToInt32(managerIDTxt.Text);
                return customerController.GetAuthorisation(managerId);
            }
            catch (FormatException)
            {
                customerController.DisplayErrorMessage("Invalid Manager ID format", "Input Error");
                return false;
            }
        }

        private bool IsAccountOpened()
        {
            try
            {
                int customerId = Convert.ToInt32(custIDTxt.Text);
                return customerController.RequestAccountStatus(customerId);
            }
            catch (FormatException)
            {
                customerController.DisplayErrorMessage("Invalid Customer ID format", "Input Error");
                return false;
            }
        }

        private void DisplayCustomerAccount()
        {
            int customerId = Convert.ToInt32(custIDTxt.Text);
            closeCustomerGrd.DataSource = customerController.FindCustomerAccount(customerId).Tables["Customers"];
            closeCustomerGrp.Visible = true;
        }

        

        private void CloseCustomerAccountBtn_Click(object sender, EventArgs e)
        {
            DialogResult close = customerController.DisplayConfirmationBottons("Would you like to continue?", "Confirmation");

            if (close == DialogResult.Yes)
            {
                if (IsCustomerClosed())
                {
                    customerController.DisplayInformationMessage("Customer ID " + custIDTxt.Text + "is Closed!", "Confirmation");
                }
                custIDTxt.Clear();
                closeCustomerGrp.Visible = false;
            }
            
        }

        private bool IsCustomerClosed()
        {
            try
            {
                int customerId = Convert.ToInt32(custIDTxt.Text);
                return customerController.ClosingCustomerAccount(customerId);
            }
            catch (FormatException)
            {
                customerController.DisplayErrorMessage("Invalid Customer ID format", "Input Error");
                return false;
            }
        }

        private void BackToMenuBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMnu backForm = new frmMainMnu();
            backForm.Show();
        }


        private void FrmCloseCustomer_Load(object sender, EventArgs e)
        {
            //No implementation required. This is just the FrmCloseClient UI
        }

        private void CloseCustomerGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //No implementation required. This is just a grid element on FrmCloseCustomer
        }

        private void Menu1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // No implementation required.
        }
    }
}
