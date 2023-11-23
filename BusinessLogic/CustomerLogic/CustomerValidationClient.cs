using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentaSYS.BusinessLogic.CustomerLogic
{
    internal class CustomerValidationClient
    {
        private ICustomerValidationStrategy _customerValidationStrategy;
        

        public void CreateCustomerValidator(ICustomerValidationStrategy customerValidationStrategy)
        {
            _customerValidationStrategy = customerValidationStrategy;
        }

        public void GetCustomerValidatorBehavior(TextBox input)
        {
            _customerValidationStrategy.Validate(input);
        }
    }
}
