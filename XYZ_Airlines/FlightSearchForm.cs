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
    public partial class FlightSearchForm : Form
    {
        Form1 f1;
        public FlightSearchForm()
        {
            InitializeComponent();
        }
        public FlightSearchForm(Form1 a)
        {
            f1 = a;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Close();
        }

        private void FlightSearchForm_Load(object sender, EventArgs e)
        {
            txtFlightList.Text = Program.Ac.flightList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtFlightNum.Text == "")
            {
                lblEfNo.Text = "Please enter Flight Number";
            }
            else
            {
                txtFindFlight.Text = Program.Ac.viewFlight(Convert.ToInt32(txtFlightNum.Text));
            }
            
        }
    }
}
