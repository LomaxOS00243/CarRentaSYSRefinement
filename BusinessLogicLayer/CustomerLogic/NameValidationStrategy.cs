using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentaSYS.BusinessLogic.CustomerLogic
{
    internal class NameValidationStrategy : ICustomerValidationStrategy
    {
        
        public void ReturnResponse()
        {
            MessageBox.Show("Name must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
