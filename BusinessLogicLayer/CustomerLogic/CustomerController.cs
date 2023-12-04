using CarRentaSYS.DataAccessObject;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentaSYS.BusinessLogic.CustomerLogic
{
    internal class CustomerController
    {

        private readonly CustomerDatabaseManager customerDatabaseManager = CustomerDatabaseManager.CustomerDatabaseInstance();

        private readonly CustomerDatabaseProxy customerDatabaseProxy = new CustomerDatabaseProxy(); 

        private int customerID;
        private string name;
        private string address;
        private string town;
        private string country;
        private string zipCode;
        private string email;
        private string telNo;
        private char status;

        

        public CustomerController()
        { 
            this.customerID = 0;
            this.name = " ";
            this.address = " ";
            this.town = " ";
            this.country = " ";
            this.zipCode = " ";
            this.email = " ";
            this.telNo = " ";
            this.status = ' ';
        }


        public CustomerController(int customerId, string name, string address, string town, string country, string zipCode, string email, string telNo, char status)
        {
            this.customerID = customerId;
            this.name = name;
            this.address = address;
            this.town = town;
            this.country = country;
            this.zipCode = zipCode;
            this.email = email;
            this.telNo = telNo;
            this.status = status;
        }
        public void SetClientId(int customerId)
        {
            customerID = customerId;
        }
        public int GetClientId()
        {
            return customerID;
        }
        public void SetName(string names)
        {
            name = names;
        }
        public string GetName()
        {
            return name;
        }
        public void SetAddress(string addr)
        {
            address = addr;
        }
        public string GetAddress()
        {
            return address;
        }
        public void SetTown(string towns)
        {
            town = towns;
        }
        public string GetTown()
        {
            return town;
        }
        public void SetZipCode(string zipcode)
        {
            zipCode = zipcode;
        }
        public string GetZipCode()
        {
            return zipCode;
        }
        public void SetEmail(string emails)
        {
            email = emails;
        }
        public string GetEmail()
        {
            return email;
        }
        public void SetTelNo(string telno)
        {
            telNo = telno;
        }
        public string GetTelNo()
        {
            return telNo;
        }
        public void SetStatus(char clientStatus)
        {
            status = clientStatus;
        }
        public char GetStatus()
        {
            return status;
        }
        
        public int GetNextCustomerID()
        { 
            int id = customerDatabaseManager.GetNextCustomerID();

            return id;
        }

        //Create a new account via the Proxy
        public bool CreateAccount(int managerID)
        {

            string query = "INSERT INTO Customers VALUES(" +
                this.customerID + ",'" +
                this.name + "','" +
                this.address + "','" +
                this.town + "','" +
                this.country + "','" +
                this.zipCode + "','" +
                this.email + "','" +
                this.telNo + "','" +
                this.status + "')";

            
            if (GetAuthorisation(managerID))
            {
                customerDatabaseProxy.CreateCustomerAccount(query);
                return true;
            }
            else
                return false;
        }

        
        public bool RequestAccountStatus(int customerID)
        { 
            return customerDatabaseProxy.IsAccountOpened(customerID);
        }


        public DataSet FindCustomerAccount(int customerID)
        {
            return customerDatabaseManager.FindCustomerAccountForClosure(customerID); 
        }


        public bool ClosingCustomerAccount(int customerID)
        {
            bool accountClosureResponse = customerDatabaseManager.CloseCustomerAccount(customerID);
            customerDatabaseManager.CloseConnection();
            return accountClosureResponse;

        }


        //Verify manager ID
        public bool GetAuthorisation(int managerID)
        {
            return customerDatabaseProxy.IsAuthorisedManagerID(managerID);
        }

        public void DisplayInformationMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DisplayErrorMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult DisplayConfirmationBottons(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
    }
}
