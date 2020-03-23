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
    public partial class FlightAddForm : Form
    {
        Form1 f1;
        public FlightAddForm()
        {
            InitializeComponent();
        }
        public FlightAddForm(Form1 a)
        {
            f1 = a;
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Close();
        }
        public bool checkInteger(TextBox t)
        {
            int a;
            return int.TryParse(t.Text, out a);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtFlightNum.Text == "" && checkInteger(txtFlightNum))
            {
                errFlNum.Text = "Please Enter Flight Number and int";
            }
            if(txtMaxSeats.Text == "")
            {
                lblEseats.Text = "Please enter Maximum seats";
            }
            if(txtOrigin.Text == "")
            {
                lblEorigin.Text = "Please enter the Origin of the Flight";
            }
            if(txtDest.Text == "")
            {
                lblEdest.Text = "Please enter the destination of the Flight";
            }
            else
            {
                int num = Convert.ToInt32(txtFlightNum.Text);
                int maxSeats = Convert.ToInt32(txtMaxSeats.Text);
                Program.Ac.addFlight(num, txtOrigin.Text, txtDest.Text, maxSeats);
            }
        }

        private void FlightAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
