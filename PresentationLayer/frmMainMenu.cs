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
    public partial class FrmMainMnu : Form
    {
        public FrmMainMnu()
        {
            InitializeComponent();
        }

        private void nCToolStripMnu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAddCustomer addForm = new FrmAddCustomer();
            addForm.Show();

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //No implementation required.
        }



        private void closeClAccToolStripMnu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCloseCustomer closeClient = new FrmCloseCustomer();
            closeClient.Show();
        }

        

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            //No implementation required. 
        }

        private void FrmMainMnu_Load(object sender, EventArgs e)
        {
            //No implementation required.
        }

        private void ClToolStripMnu_Click(object sender, EventArgs e)
        {
            //No implementation required.
        }
    }
}
