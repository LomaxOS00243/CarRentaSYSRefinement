using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;



namespace CarRentaSYS
{
    public partial class frmIssueInvoice : Form
    {
        List<int> allClientIdInReturnState = new List<int>();
        List<int> distinctIds = new List<int>();
        int [] ids ;
        

        public frmIssueInvoice()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            
            int invoiceId = 0, clientId = 0;
            string invoiceDate = String.Format("{0:dd-MMM-yy}", DateTime.Now);
            double totalCost = 0;
            Invoices invoice;
            MimeMessage message;
            SmtpClient clientEmail;
            string invoiceIdToEmail = " ", clientIdToEmail = " ", invoiceDateToEmail = " ", totalToEmail = " ";


            //store the disctinct ids of client
            distinctIds = allClientIdInReturnState.Distinct().ToList();

            //Show number of min and the max clients have been retrieved from the Reservations File
            maxNumLb.Text = Convert.ToString(distinctIds.Count()-1);
            minNumLb.Text = Convert.ToString(0);
            maxNumLb.Visible = true;
            minNumLb.Visible = true;
            
            proBar.Visible = true;

            //Loop through each client id
            for (int i = 0; i<distinctIds.Count-1; i++)
            {
                //store each ids one by one to use it as reference
                ids = distinctIds.GetRange(i, 1).ToArray();
                
                //initialise the invoice id in every iteration
                invoiceId = Invoices.getNextInvoiceNo();
                for (int j = 0; j <= ids.Length-1; j++)
                {
                    //Store values into variables

                    //Call the function to Retrieve that specified client id
                    clientId = Reservation.getEachClientId(ids[j]);

                    //Call the function to get total of client id in distinctId list
                    totalCost = Reservation.getTotalCost(ids[j]);

                    //create invoice object
                    invoice = new Invoices(invoiceId, clientId, invoiceDate, totalCost);

                    //store in Invoices file
                    invoice.addInvoices();

                    //Create Mime object to allow to send emails to client
                    message = new MimeMessage();

                    message.From.Add(new MailboxAddress("Car Rental", "Lomaxos6@gmail.com"));

                    message.To.Add(MailboxAddress.Parse(Invoices.getClientEmails(ids[j])));

                    message.Subject = "Invoices";

                    //Retrieve all invoices datails in every iteration
                    DataSet dSet = Invoices.getInvoicesDetails(ids[j]);

                    //In each iteration , loop through the object Dataset to retrieve all data from Invoices file
                    //to stor into varialbles.
                    for (int k = 0; k < dSet.Tables[0].Rows.Count; k++)
                    {

                        invoiceIdToEmail = Convert.ToString(dSet.Tables[0].Rows[k][0]);
                        clientIdToEmail = Convert.ToString(dSet.Tables[0].Rows[k][1]);
                        invoiceDateToEmail = String.Format("{0:dd-MMM-yy}",dSet.Tables[0].Rows[k][2]);
                        totalToEmail = Convert.ToString(dSet.Tables[0].Rows[k][3]);
                    }

                    
                    message.Body = new TextPart("plain")
                    {
                        Text = "Dear Customer,\n\n" +
                        "We would like to thank you for your trust and loyalty\n" +
                        "Please see attached your invoice below \n" +
                        "Invoice No: 000"+invoiceId+"\n"+
                        "Client Id: " + clientIdToEmail + "\n" +
                        "Date: " + invoiceDateToEmail+"\n" +
                        "The Total due: " + totalToEmail
                    };


                    clientEmail = new SmtpClient();

                    //Inable the revocation checker 
                    clientEmail.CheckCertificateRevocation = false;

                    try
                    {
                        
                       clientEmail.Connect("smtp.gmail.com",465,true);
                       
                       clientEmail.Authenticate("Lomaxos6@gmail.com", "Password");
                       clientEmail.Send(message);
                       
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        clientEmail.Disconnect(true);
                        clientEmail.Dispose();
                    }

                    //Delete all the reservations that already got email of their invoices
                    //To delete that allow the car that was hold by this particular client, to be available 
                    //in the system for other clients
                    Reservation.deleteReservation(ids[j]);
                }
                
                
            }
            
            for (int count = 0; count < 100; count++)
            {
                proBar.Value++;

                Thread.Sleep(100);
            }


            
           
            //Exit if the process is completed successfully
            if (proBar.Value == 100)
            {
                StartInvoiceBtn.Enabled = false;
                MessageBox.Show("The emails were successfully sent to clients", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Invoices saved ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                frmMainMnu frmMain = new frmMainMnu();
                frmMain.Show();

            }

           
        }

        private void frmIssueInvoice_Load(object sender, EventArgs e)
        {
            //Retrieves all reservation in return state
            invoiceDataGr.DataSource = Reservation.getReturnCarDetails().Tables["retCarDetails"];


            //Loop through the invoice's DataGridView to store all the name of the first column
            for (int rows = 0; rows < invoiceDataGr.Rows.Count; rows++)
            {

                allClientIdInReturnState.Add(Convert.ToInt32(invoiceDataGr.Rows[rows].Cells["ClientId"].Value));

            }

        }

        private void invoiceDataGr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

            
            
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMnu mainMnu = new frmMainMnu();
            mainMnu.Show();
        }
    }
}
