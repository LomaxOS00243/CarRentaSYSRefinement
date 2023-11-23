using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentaSYS.BusinessLogic.CustomerLogic
{
    internal class CustomerEmailValidator : ICustomerValidationStrategy
    {
        public bool Validate(TextBox input)
        {
            if (input.Text.Equals(""))
            {

                MessageBox.Show("Email address must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                input.Focus();
                return true;
            }
            return false;
        }
    }
}
