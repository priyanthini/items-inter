using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BlueArcSystem
{
    public partial class fmlogin : MetroFramework.Forms.MetroForm
    {

        public fmlogin()
        {
            InitializeComponent();
            cmbtype.Text = "Marketing";
            txtun.Text = "mkt";
            txtpw.Text = "222";
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            cmbtype.Text = "";
            txtun.Text = "";
            txtpw.Text = "";
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\BlueArc\DB\BlueArcDb.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from [User] where username='" + txtun.Text + "' and password='" + txtpw.Text + "' and type='" + cmbtype.Text + "'   ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlDataAdapter sda1 = new SqlDataAdapter("select type from [User] where username='" + txtun.Text + "' and password='" + txtpw.Text + "'   ", con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                if (dt1.Rows[0][0].ToString() == "Administrator")
                {
                    fmmktng ss = new fmmktng();
                    ss.Show();
                    this.Hide();
                }
                else if (dt1.Rows[0][0].ToString() == "Finance")
                {
                    fmmktng ss = new fmmktng();
                    ss.Show();
                    this.Hide();
                }
                else if (dt1.Rows[0][0].ToString() == "Marketing")
                {
                    fmmktng ss = new fmmktng();
                    ss.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please Check your Username, Password and Type.!");
                }
            }
            else
            {
                MessageBox.Show("Please Check your Username, Password and Type.!");

            }

        }
 
    }
}
