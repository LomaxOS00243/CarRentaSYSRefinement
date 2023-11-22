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
    public partial class frmMakeReservation : Form
    {
        
        public frmMakeReservation()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String collectCar = String.Format("{0:dd-MMM-yy}", collectDate.Value);
            String returnCar = String.Format("{0:dd-MMM-yy}", returnDate.Value);

            //Create Reservation object
            Reservation addReservation = new Reservation(Convert.ToInt32(resIdTxtBox.Text), 
                                                    collectCar,returnCar,Convert.ToDouble(resCostTxtBox.Text),0.00,'W',regNoTxtBox.Text,Convert.ToInt32(clIdTxtBox.Text));

            addReservation.addReservation();

            //Display a confirmation message
            MessageBox.Show("Reservation" + resIdTxtBox.Text + " is added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            MessageBox.Show("The revervation is made", "Reservation Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cbClientId.SelectedIndex = -1;
            cbCarType.SelectedIndex = -1;
            collectDate.Value = DateTime.Today;
            selectCars.Visible = false;
            resSummary.Visible = false;
       
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMakeReservation_Load(object sender, EventArgs e)
        {
            //Retrieve  all clients names from the system
            DataSet da = Reservation.GetClientID();

            for (int i = 0; i < da.Tables[0].Rows.Count; i++)
            {
                cbClientId.Items.Add(da.Tables[0].Rows[i][0]);
            }

            //Retrieve all cars types from the system 
            DataSet ds = Type.getTypes();

            //fill the type comboBox
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cbCarType.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1]);
            }
            collectDate.MinDate = DateTime.Today;

            returnDate.MinDate = collectDate.Value.AddDays(1);

      

        }

        private void btnavaillllability_Click(object sender, EventArgs e)
        {
            
            //Check user input to find the list of the car available
            if (cbClientId.SelectedIndex == -1)
            {
                MessageBox.Show("You must select client name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbClientId.Focus();
            }
            else if (cbCarType.SelectedIndex == -1)
            {
                MessageBox.Show("You must select car type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbCarType.Focus();
            }
            else
            {
                makeResGrd.DataSource = Reservation.findAvailableCar(cbCarType.Text.Substring(0, 2), String.Format("{0:dd-MMM-yy}", collectDate.Value),
                String.Format("{0:dd-MMM-yy}", returnDate.Value)).Tables["Reserve"];
                selectCars.Visible = true;
            }

               

        }

        private void listCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listResSummary.Items.Add("00001"+"112"+"201Ky123" +"10/12/21"+"12/12/21"+ "€500");
            resSummary.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult cancel = MessageBox.Show("Are you sure you want to cancel", "Confrimation", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Information);

                if (cancel == DialogResult.Yes)
                {
                resSummary.Visible = false;
                }
            
            
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMnu frmMain = new frmMainMnu();
            frmMain.Show();
        }

        private void listResSummary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectCars_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void makeResGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //getNext Reservation No;
            resIdTxtBox.Text = Reservation.getNextReservationNo().ToString("0000");

            //Find client id that matchs the client name
            int id = Reservation.getClientID(cbClientId.Text);
            
            //Find cost that matchs the type code
            double carCost = Type.getCost(cbCarType.Text.Substring(0, 2));



            int index = e.RowIndex;

            //Pass values into Reservation textboxes
            DataGridViewRow selectedRow = makeResGrd.Rows[index];
            regNoTxtBox.Text = selectedRow.Cells[0].Value.ToString();
            clIdTxtBox.Text = Convert.ToString(id);
            collectDateTxtBox.Text = String.Format("{0:dd-MMM-yy}", collectDate.Value);
            returnDateTxtBox.Text = String.Format("{0:dd-MMM-yy}", returnDate.Value);
            resCostTxtBox.Text = Convert.ToString(carCost);
            resSummary.Visible = true;
        }
    }
}
