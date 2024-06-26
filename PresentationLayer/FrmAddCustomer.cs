﻿using CarRentaSYS.BusinessLogicLayer.CustomerLogic;
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
        private readonly CustomerController customerController = new CustomerController();
        private readonly CustomerInputsValidator inputsValidator = new CustomerInputsValidator();

        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        private void AddNewAccount_Click(object sender, EventArgs e)
        {

            if (!inputsValidator.VerifyEmptyField(managerIDTxt, new ManagerIDValidationStrategy()))
            { return; }

            if (!inputsValidator.VerifyEmptyField(custNameTxt, new NameValidationStrategy()))
            { return; }

            if (!inputsValidator.VerifyEmptyField(custAddTxt, new AddressValidationStrategy()))
            { return; }

            if (!inputsValidator.VerifyEmptyField(custTownTxt, new TownValidationStrategy()))
            { return; }

            if (!inputsValidator.VerifyEmptyField(custCountryTxt, new CountryValidationStrategy()))
            { return; }

            if (!inputsValidator.VerifyEmptyField(custZipTxt, new ZipcodeValidationStrategy()))
            { return; }

            if (!inputsValidator.VerifyEmptyField(custEmailTxt, new EmailValidationStrategy()))
            { return; }

            if (!inputsValidator.VerifyEmptyField(custTelTxt, new TelnoValidationStrategy()))
            { return; }

            CustomerController addNewAccount = new CustomerController(Convert.ToInt32(custIDTxt.Text), custNameTxt.Text, custAddTxt.Text, custTownTxt.Text,

                                                                      custCountryTxt.Text, custZipTxt.Text, custEmailTxt.Text, custTelTxt.Text, 'O');



            AddingNewAccount(addNewAccount);

        }
        private void AddingNewAccount(CustomerController addAccount)
        {
            
            try
            {
                int managerId = Convert.ToInt32(managerIDTxt.Text);
                bool anAuthorisedID = addAccount.CreateAccount(managerId);
                if (anAuthorisedID)
                {
                    ConfirmNewAccountCreation();
                    ResetInputFields();
                    return;
                }

                customerController.DisplayErrorMessage("Unauthorized manager ID", "Authorization Error");
            }
            catch (FormatException)
            {
                customerController.DisplayErrorMessage("Invalid Manager ID format", "Input Error");
            }
        }
        
        private void ConfirmNewAccountCreation()
        {
            customerController.DisplayInformationMessage("Customer " + custIDTxt.Text + " added successfully", "Success");

            customerController.DisplayInformationMessage("Customer Account is Created", "Success");
         
        }
        private void ResetInputFields()
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

        
        private void FrmAddClient_Load(object sender, EventArgs e)
        {
            //Return the next customer id number when this form is invoked
            custIDTxt.Text = customerController.GetNextCustomerID().ToString("0000");
        }

        private void BackToMenuBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmMainMnu mainMenu = new FrmMainMnu();
            mainMenu.Show();
        }


        private void NewTxtBox1_TextChanged(object sender, EventArgs e)
        {
            //No implementation required. This is just a textbox element on FrmAddCustomer
        }

        private void NewCustomerBox1_Enter(object sender, EventArgs e)
        {
            //No implementation required. This is just a textbox element on FrmAddCustomer
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            //No implementation required. This is just a label element on FrmAddCustomer
        }

        private void CustomerNameTxt_TextChanged(object sender, EventArgs e)
        {
            //No implementation required. This is just a textbox element on FrmAddCustomer
        }

        private void ManagerIDLabel_Click(object sender, EventArgs e)
        {
            //No implementation required. This is just a label element on FrmAddCustomer
        }
    }
}
