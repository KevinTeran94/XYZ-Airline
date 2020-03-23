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
    public partial class DeleteFlightForm : Form
    {
        Form1 f1;
        public DeleteFlightForm()
        {
            InitializeComponent();
        }
        public DeleteFlightForm(Form1 a)
        {
            f1 = a;
            InitializeComponent();
        }
        private void DeleteFlightForm_Load(object sender, EventArgs e)
        {
            txtFlightList.Text = Program.Ac.flightList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtFid.Text == "")
            {
                lblEfId.Text = "enter the flight Id you want to delete";
            }
            else
            {
                Program.Ac.deleteFlight(Convert.ToInt32(txtFid.Text));
            }
            
        }
    }
}
