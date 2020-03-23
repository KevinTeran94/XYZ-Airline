using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XYZ_Airlines
{
    public partial class AddBookingForm : Form
    {
        Form1 f1;

        public AddBookingForm()
        {
            InitializeComponent();
        }
        public AddBookingForm(Form1 f)
        {
            f1 = f;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Hide();
        }

        private void AddBookingForm_Load(object sender, EventArgs e)
        {
            txtCustomerList.Text = Program.Ac.customerList();
            txtFlightList.Text = Program.Ac.flightList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtFlightNum.Text == "")
            {
                lblEfNo.Text = "Please enter the Flight Number";
            }
            if(txtCustomerNum.Text == "")
            {
                lblEcustNum.Text = "Please enter Customer Number";
            }
            else
            {
                int cNum = Convert.ToInt32(txtCustomerNum.Text);
                int flno = Convert.ToInt32(txtFlightNum.Text);
                Program.Ac.addBooking(cNum, flno);
            }

        }
    }
}
