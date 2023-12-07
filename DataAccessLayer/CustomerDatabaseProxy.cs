using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentaSYS.DataAccessLayer
{
    public class CustomerDatabaseProxy : ICustomerDatabase
    {
        private readonly CustomerDatabaseManager manager;

        //CustomerDatabaseManager object is created during this instatiation
        public CustomerDatabaseProxy() 
        {
            manager = CustomerDatabaseManager.CustomerDatabaseInstance();
        }


        //Forward the create account requests to CustomerDatabaseManager
        public void CreateCustomerAccount(string sqlQuery)
        {
            manager.CreateCustomerAccount(sqlQuery);
               
        }

        /* 
         * Forward the account status check request.
         * 
         * Return status ("True = Opened Account" or "False = Closed Account") to allow their details retrieval for closure.
         */
        public bool IsAccountOpened(int customerID)
        {
            bool customerStatus = manager.IsAccountOpened(customerID);

            manager.CloseConnection();

            return customerStatus;
        }

        //Forward the veryfication the Manager IDs
        public bool IsAuthorisedManagerID(int managerID)
        {
            bool managerIDValidation = manager.VerifyManagerID(managerID);

            manager.CloseConnection();

            return managerIDValidation;

        }

    }
}
