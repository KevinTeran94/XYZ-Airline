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
    public partial class ViewFlightsForm : Form
    {
        Form1 f1;
        public ViewFlightsForm()
        {
            InitializeComponent();
        }
        public ViewFlightsForm(Form1 a)
        {
            f1 = a;
            InitializeComponent();
        }
        private void ViewFlightsForm_Load(object sender, EventArgs e)
        {
            txtViewFlights.Text = Program.Ac.flightList();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Close();
        }

        private void txtViewFlights_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
