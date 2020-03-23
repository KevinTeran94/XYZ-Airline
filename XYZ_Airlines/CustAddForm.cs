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
    public partial class CustAddForm : Form
    {
        Form1 f1;
        public CustAddForm()
        {
            InitializeComponent();
        }
        public CustAddForm(Form1 a)
        {
            f1 = a;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Close();
        }

        private void CustAddForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text == "")
            {
                lblEfName.Text = "Please enter First Name";
            }
            if(txtLastName.Text == "")
            {
                lblElastName.Text = "Please enter Last Name";
            }
            if(txtPhone.Text == "")
            {
                lblEphone.Text = "Please enter Phone Number";
            }
            else
            {
                Program.Ac.addCustomer(txtFirstName.Text, txtLastName.Text, txtPhone.Text);
            }
            
        }
    }
}
