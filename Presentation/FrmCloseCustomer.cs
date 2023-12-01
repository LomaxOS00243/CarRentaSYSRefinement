using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentaSYS
{
    public partial class FrmCloseCustomer : Form
    {
        public FrmCloseCustomer()
        {
            InitializeComponent();
        }

        private void findClientBtn_Click(object sender, EventArgs e)
        {
            bool isValidID = Clients.isValidCliendID(Convert.ToInt32(custIDTxt.Text));
            //Validation
            if (custIDTxt.Text.Equals("") || !isValidID)
            {
                MessageBox.Show("Sorry! this client is closed or you entered incorrect client Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                custIDTxt.Focus();

            }
            else
            {
                //Find the matching client
                closeClientGrd.DataSource = Clients.findClient(Convert.ToInt32(custIDTxt.Text)).Tables["Client"];
                

                //Make the matching client visible
                closeClientGrp.Visible = true;
            }
            

            
        }

        

        private void frmCloseClient_Load(object sender, EventArgs e)
        {

        }

        private void closeClientBtn_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("You are about to close this client, Are you sure?", "Confrimation", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Information);

            if (close == DialogResult.Yes)
            {
                bool closeClient = Clients.closeClient(Convert.ToInt32(custIDTxt.Text));
                //Close account
                if (closeClient)
                {
                    MessageBox.Show("The client " + custIDTxt.Text + "is Closed!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                custIDTxt.Clear();
                closeClientGrp.Visible = false;
            }
            
            
        }

        private void backToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMnu backForm = new frmMainMnu();
            backForm.Show();
        }

        private void closeClientGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
