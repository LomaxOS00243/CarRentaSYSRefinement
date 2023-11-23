using CarRentaSYS.BusinessLogic.CustomerLogic;
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
    public partial class frmAddClient : Form
    {
        CustomerControllerManager customerController;

        public frmAddClient()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
           //validator method calls
            

            //Create an instance of Product and instantiate with values from controls
            Clients addClient = new Clients(Convert.ToInt32(clientIdTxt.Text), clientNmeTxt.Text, clientAddTxt.Text,
                clientTownTxt.Text, clientConTxt.Text, clientZipTxt.Text,clientEmailTxt.Text,clientTelTxt.Text,'O');

            //Invoke the method to addProduct from Class Product 
            addClient.addClient();

            //Display a confirmation message
            MessageBox.Show("Client " + clientIdTxt.Text + " added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);




            MessageBox.Show("Client Account Createed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset ui
            clientIdTxt.Text = Clients.getNextClientId().ToString("0000");
            clientNmeTxt.Clear();
            clientAddTxt.Clear();
            clientAddTxt.Clear();
            clientTownTxt.Clear();
            clientConTxt.Clear();
            clientZipTxt.Clear();
            clientEmailTxt.Clear();
            clientTelTxt.Clear();
           


         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {

            clientIdTxt.Text = CustomerControllerManager.GetNextID().ToString("0000");
        }


        private void newTxtBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void newClientBox1_Enter(object sender, EventArgs e)
        {

        }


        private void backToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMnu mainMenu = new frmMainMnu();
            mainMenu.Show();
        }
    }
}
