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
    public partial class DeleteCustomerForm : Form
    {
        Form1 f1;
        public DeleteCustomerForm()
        {
            InitializeComponent();
        }
        public DeleteCustomerForm(Form1 f)
        {
            f1 = f;
            InitializeComponent();
        }
        private void DeleteCustomerForm_Load(object sender, EventArgs e)
        {
            txtViewCustomers.Text = Program.Ac.customerList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtCustID.Text == "")
            {
                lblEcustId.Text = "Please enter Customer Id you want to delete";
            }
            else
            {
                Program.Ac.deleteCustomer(Convert.ToInt32(txtCustID.Text));
            }
            
        }
    }
}
