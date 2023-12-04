using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentaSYS.DataAccessObject
{
    internal class CustomerDatabaseProxy : ICustomerDatabase
    {
        private readonly CustomerDatabaseManager manager;

        public CustomerDatabaseProxy() 
        {
            manager = CustomerDatabaseManager.CustomerDatabaseInstance();
        }

        public void CreateCustomerAccount(string sqlQuery)
        {
            manager.CreateCustomerAccount(sqlQuery);
               
        }


        public bool IsAccountOpened(int customerID)
        {
            bool customerStatus = manager.IsAccountOpened(customerID);

            manager.CloseConnection();

            return customerStatus;
        }

        public bool IsAuthorisedManagerID(int managerID)
        {
            bool managerIDValidation = manager.VerifyManagerID(managerID);

            manager.CloseConnection();

            return managerIDValidation;


        }

        
  
    }
}
