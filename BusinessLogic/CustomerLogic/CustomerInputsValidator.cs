using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentaSYS.BusinessLogic.CustomerLogic
{
    internal class CustomerInputsValidator
    {
        private ICustomerValidationStrategy _customerValidationStrategy;
        

        public bool ValidateField(TextBox inputField, ICustomerValidationStrategy validationStrategy)
        {
            if(string.IsNullOrWhiteSpace(inputField.Text))
            {
                CreateValidationStrategy(validationStrategy);

                GetErrorMessage();

                inputField.Focus();

                return false;
            }
            return true;
        }

        public void CreateValidationStrategy(ICustomerValidationStrategy customerValidationStrategy)
        {
            _customerValidationStrategy = customerValidationStrategy;
        }


        public void GetErrorMessage()
        {
            _customerValidationStrategy.ReturnResponse();
        }
    }
}
