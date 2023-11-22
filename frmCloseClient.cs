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
    public partial class frmCloseClient : Form
    {
        public frmCloseClient()
        {
            InitializeComponent();
        }

        private void findClientBtn_Click(object sender, EventArgs e)
        {
            bool isValidID = Clients.isValidCliendID(Convert.ToInt32(findClientTxt.Text));
            //Validation
            if (findClientTxt.Text.Equals("") || !isValidID)
            {
                MessageBox.Show("Sorry! this client is closed or you entered incorrect client Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                findClientTxt.Focus();

            }
            else
            {
                //Find the matching client
                closeClientGrd.DataSource = Clients.findClient(Convert.ToInt32(findClientTxt.Text)).Tables["Client"];
                

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
                bool closeClient = Clients.closeClient(Convert.ToInt32(findClientTxt.Text));
                //Close account
                if (closeClient)
                {
                    MessageBox.Show("The client " + findClientTxt.Text + "is Closed!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                findClientTxt.Clear();
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
