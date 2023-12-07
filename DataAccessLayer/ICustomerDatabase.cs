using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentaSYS.DataAccessLayer
{
    internal interface ICustomerDatabase
    {
        void CreateCustomerAccount(string sqlQuery);
        bool IsAccountOpened(int customerID);
    }
}
