using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentaSYS.BusinessLogic.CustomerLogic
{
    internal class ZipcodeValidationStrategy : ICustomerValidationStrategy
    {
        public void ReturnResponse()
        {
            MessageBox.Show("Zipcode must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
 
        }
    }
}
