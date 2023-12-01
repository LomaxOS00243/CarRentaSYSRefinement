using CarRentaSYS.BusinessLogic.CustomerLogic;
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
    public partial class FrmAddCustomer : Form
    {

        CustomerInputsValidator inputsValidator = new CustomerInputsValidator();

        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            if (!inputsValidator.ValidateField(managerIDTxt, new ManagerIDValidationStrategy()))
            { return; } 

            if (!inputsValidator.ValidateField(custNameTxt, new NameValidationStrategy()))
            { return; }

            if (!inputsValidator.ValidateField(custAddTxt, new AddressValidationStrategy()))
            { return; }

            if (!inputsValidator.ValidateField(custTownTxt, new TownValidationStrategy()))
            { return; }

            if (!inputsValidator.ValidateField(custCountryTxt, new CountryValidationStrategy()))
            { return; }

            if (!inputsValidator.ValidateField(custZipTxt, new ZipcodeValidationStrategy()))
            { return; }

            if (!inputsValidator.ValidateField(custEmailTxt, new EmailValidationStrategy()))
            { return; }

            if (!inputsValidator.ValidateField(custTelTxt, new TelnoValidationStrategy()))
            { return; }


            CustomerController addCustomer = new CustomerController(Convert.ToInt32(custIDTxt.Text), custNameTxt.Text, custAddTxt.Text,
                custTownTxt.Text, custCountryTxt.Text, custZipTxt.Text, custEmailTxt.Text, custTelTxt.Text,'O');

            

            bool isValidId = addCustomer.CreateAccount(Convert.ToInt32(managerIDTxt.Text));

            if (isValidId)
            {
                DisplayCreateAccountMessages();
                ResetInputField();

            }
            else
                MessageBox.Show("Unauthorized manager ID", "Authorization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        public void DisplayCreateAccountMessages()
        {
            MessageBox.Show("Client " + custIDTxt.Text + " added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("Client Account Createed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ResetInputField()
        {
            custIDTxt.Text = customerController.GetNextCustomerID().ToString("0000");
            custNameTxt.Clear();
            custAddTxt.Clear();
            custAddTxt.Clear();
            custTownTxt.Clear();
            custCountryTxt.Clear();
            custZipTxt.Clear();
            custEmailTxt.Clear();
            custTelTxt.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {

            custIDTxt.Text = customerController.GetNextCustomerID().ToString("0000");
        }


        private void newTxtBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void newClientBox1_Enter(object sender, EventArgs e)
        {

        }


        private void backToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMnu mainMenu = new frmMainMnu();
            mainMenu.Show();
        }

        private void custNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void managerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
