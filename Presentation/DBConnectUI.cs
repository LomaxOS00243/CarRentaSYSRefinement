using System;
using System.Configuration;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using CarRentaSYS.DataAccessObject;

namespace CarRentaSYS.Presentation
{
    public partial class DBConnectUI : Form
    {

        readonly CustomerRepository _customerRep = CustomerRepository.ClientRepositoryInstance();
        
        public DBConnectUI()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
        
            try
            {
                _customerRep.OpenConnection();
                lbl1.Text = "Connection is Open";
            }
            catch (Exception rx)
            {
                MessageBox.Show("Unable to connect to the database!\n" + rx.ToString());

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           
            try
            {
                _customerRep.CloseConnection();
                lbl1.Text = "Connection is Close";
            }
            catch (Exception rx)
            {
                MessageBox.Show("Error: \n" + rx.ToString());

            }

        }

        private void frmConnect_Load(object sender, EventArgs e)
        {
            //This method allows the frmConnect to load
        }
    }
}
