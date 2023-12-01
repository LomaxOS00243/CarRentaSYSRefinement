using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentaSYS.DataAccessObject
{
    internal interface ICustomerDatabase
    {
        void CreateCustomerAccount(string sqlQuery);
    }
}
