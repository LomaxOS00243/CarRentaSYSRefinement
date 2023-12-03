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


        //Return true if the input on FrmAddCustomer is valid. If not, returns false and displays an appropiate error message
        public bool VerifyEmptyField(TextBox inputField, ICustomerValidationStrategy validationStrategy)
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


        //Allow the interaction of various input validation strategies via an interface
        public void CreateValidationStrategy(ICustomerValidationStrategy customerValidationStrategy)
        {
            _customerValidationStrategy = customerValidationStrategy;
        }


        // Returns a specific error message corresponding to the type of validation failure encountered.
        public void GetErrorMessage()
        {
            _customerValidationStrategy.ReturnResponse();
        }
    }
}
