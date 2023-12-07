using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentaSYS.BusinessLogicLayer.CustomerLogic
{
    internal class TownValidationStrategy : ICustomerValidationStrategy
    {
        public void ReturnResponse()
        {
            MessageBox.Show("The town must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
