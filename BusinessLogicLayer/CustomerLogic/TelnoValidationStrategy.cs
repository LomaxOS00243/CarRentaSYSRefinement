using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentaSYS.BusinessLogicLayer.CustomerLogic
{
    internal class TelnoValidationStrategy : ICustomerValidationStrategy
    {
        public void ReturnResponse()
        {
            MessageBox.Show("Phone number address must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
