﻿using System;
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
    public partial class ViewCustomersForm : Form
    {
        Form1 f1;
        public ViewCustomersForm()
        {
            InitializeComponent();
        }
        public ViewCustomersForm(Form1 a)
        {
            f1 = a;
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Close();
        }

        private void txtViewCustomers_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ViewCustomersForm_Load(object sender, EventArgs e)
        {
            txtViewCustomers.Text = Program.Ac.customerList();
        }
    }
}
