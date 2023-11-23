using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentaSYS.BusinessLogic.CustomerLogic
{
    internal class CustomerZipcodeValidator : ICustomerValidationStrategy
    {
        public bool Validate(TextBox input)
        {
            if (input.Text.Equals(""))
            {

                MessageBox.Show("Zipcode must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                input.Focus();
                return true;
            }
            return false;
        }
    }
}
