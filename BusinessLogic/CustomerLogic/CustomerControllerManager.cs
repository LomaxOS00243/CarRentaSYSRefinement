using CarRentaSYS.DataAccessObject;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentaSYS.BusinessLogic.CustomerLogic
{
    internal class CustomerControllerManager
    {
        private int customerId;
        private String name;
        private String address;
        private String town;
        private String country;
        private String zipCode;
        private String email;
        private String telNo;
        private char status;

        //private CustomerRepository _customerRep = CustomerRepository.ClientRepositoryInstance();

        public CustomerControllerManager()
        { 
            this.customerId = 0;
            this.name = " ";
            this.address = " ";
            this.town = " ";
            this.country = " ";
            this.zipCode = " ";
            this.email = " ";
            this.telNo = " ";
            this.status = ' ';
        }


        public CustomerControllerManager(int customerId, string name, string address, string town, string country, string zipCode, string email, string telNo, char status)
        {
            this.customerId = customerId;
            this.name = name;
            this.address = address;
            this.town = town;
            this.country = country;
            this.zipCode = zipCode;
            this.email = email;
            this.telNo = telNo;
            this.status = status;
        }
        public void SetClientId(int customerID)
        {
            customerId = customerID;
        }
        public int GetClientId()
        {
            return customerId;
        }
        public void SetName(String names)
        {
            name = names;
        }
        public String GetName()
        {
            return name;
        }
        public void SetAddress(String addr)
        {
            address = addr;
        }
        public String GetAddress()
        {
            return address;
        }
        public void SetTown(String towns)
        {
            town = towns;
        }
        public String GetTown()
        {
            return town;
        }
        public void SetZipCode(String zipcode)
        {
            zipCode = zipcode;
        }
        public String GetZipCode()
        {
            return zipCode;
        }
        public void SetEmail(String emails)
        {
            email = emails;
        }
        public String GetEmail()
        {
            return email;
        }
        public void SetTelNo(String telno)
        {
            telNo = telno;
        }
        public String GetTelNo()
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
        public static int GetNextID()
        {
            CustomerDatabaseManager _customerRepistory = CustomerDatabaseManager.ClientRepositoryInstance();
            int _id = _customerRepistory.NextClientId();

            return _id;
        }
        
         
    }
}
