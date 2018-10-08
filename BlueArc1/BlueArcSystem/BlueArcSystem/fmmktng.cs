using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueArcSystem
{
    public partial class fmmktng : MetroFramework.Forms.MetroForm
    {
        public fmmktng()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmlogin ss = new fmlogin();
            ss.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("HH:mm");
            lblsec.Text = DateTime.Now.ToString("ss");
            lbldate.Text = DateTime.Now.ToString("MMMM dd");
            lblday.Text = DateTime.Now.ToString("dddd");
        }


        private void btnSupplierM_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmsupplier ss = new fmsupplier();
            ss.Show();
        }

        private void btnCustomerM_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmcustomer ss = new fmcustomer();
            ss.Show();
        }

    }
}
