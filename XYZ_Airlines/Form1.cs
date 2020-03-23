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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            FlightSearchForm f = new FlightSearchForm(this);
            Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlightAddForm add = new FlightAddForm(this);
            Hide();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustAddForm f = new CustAddForm(this);
            Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewFlightsForm f = new ViewFlightsForm(this);
            Hide();
            f.Show();
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            ViewCustomersForm f = new ViewCustomersForm(this);
            Hide();
            f.Show();
        }

        private void btnDelCustomer_Click(object sender, EventArgs e)
        {
            DeleteCustomerForm f = new DeleteCustomerForm(this);
            Hide();
            f.Show();
        }

        private void btnDelFlight_Click(object sender, EventArgs e)
        {
            DeleteFlightForm f = new DeleteFlightForm(this);
            Hide();
            f.Show();
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            AddBookingForm f = new AddBookingForm(this);
            Hide();
            f.Show();
        }

        private void btnViewBooking_Click(object sender, EventArgs e)
        {
            ViewBookingForm f = new ViewBookingForm(this);
            Hide();
            f.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
