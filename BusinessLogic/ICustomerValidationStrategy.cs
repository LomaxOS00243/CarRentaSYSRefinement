using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace CarRentaSYS.BusinessLogic
{
    internal interface ICustomerValidationStrategy
    {
        bool Validate(TextBox input);
    }
}
