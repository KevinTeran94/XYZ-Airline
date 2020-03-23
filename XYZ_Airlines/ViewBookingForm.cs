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
    public partial class ViewBookingForm : Form
    {
        Form1 f1;
        AirLineCoordinator Ac;
        public ViewBookingForm()
        {
            InitializeComponent();
        }
        public ViewBookingForm(Form1 a)
        {
            Ac = new AirLineCoordinator(1, 1000, 10000, 1, 1000);
            f1 = a;
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Close();
        }

        private void ViewBookingForm_Load(object sender, EventArgs e)
        {
            txtViewBookings.Text = Program.Ac.bookingList();
        }
    }
}
