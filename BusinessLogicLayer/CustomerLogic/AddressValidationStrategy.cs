﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentaSYS.BusinessLogicLayer.CustomerLogic
{
    internal class AddressValidationStrategy : ICustomerValidationStrategy
    {
        public void ReturnResponse()
        {
            MessageBox.Show("Address must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
