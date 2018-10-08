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
    
   
    public partial class fmcustomer : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\BlueArc\BlueArcSystem\BlueArcSystem\BlueArcDb.mdf;Integrated Security = True; Connect Timeout = 30"); 

        public fmcustomer()
        {
            InitializeComponent();
        }


        private void fmcustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blueArcDbDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.blueArcDbDataSet.Customer);
            timer.Start();
            hideEdit();
        }

        public void disp_dataCS()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Customer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvCS.DataSource = dt;
            con.Close();
        }

        public void disp_dataCA()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Customer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvCA.DataSource = dt;
            con.Close();
        }

        public void disp_dataCE()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Customer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvCE.DataSource = dt;
            con.Close();
        }

        public void disp_dataCD()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Customer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvCD.DataSource = dt;
            con.Close();
        }

        public void clearCA()
        {
            txtCAaddress.Text = "";
            txtCAcompany.Text = "";
            txtCAemail.Text = "";
            txtCAid.Text = "";
            txtCAname.Text = "";
            txtCAtel.Text = "";
        }

        public void clearCS()
        {
            txtCSid.Text = "";
            txtCSname.Text = "";
            txtCStel.Text = "";
        }

        public void clearCE()
        {
            txtCEaddress.Text = "";
            txtCEcompany.Text = "";
            txtCEemail.Text = "";
            txtCEid.Text = "";
            txtCEname.Text = "";
            txtCEtel.Text = "";
        }

        public void clearCD()
        {
            txtCDid.Text = "";
            txtCDname.Text = "";
            txtCDtel.Text = "";
        }


        public void hideEdit()
        {
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            txtCEname.Visible = false;
            txtCEcompany.Visible = false;
            txtCEaddress.Visible = false;
            txtCEtel.Visible = false;
            txtCEemail.Visible = false;
        }

        private void btnCSsearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Customer where Cust_Id='" + txtCSid.Text + "' or  Cust_Name='" + txtCSname.Text + "' or Cust_Tel='" + txtCStel.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvCS.DataSource = dt;
            con.Close();
        }

        private void btnCSclear_Click(object sender, EventArgs e)
        {
            clearCS();
        }

        private void btnCSld_Click(object sender, EventArgs e)
        {
            disp_dataCS();
        }

        private void btnCAadd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Customer values ('" + txtCAid.Text + "','" + txtCAname.Text + "','" + txtCAcompany.Text + "','" + txtCAaddress.Text + "','" + txtCAtel.Text + "','" + txtCAemail.Text + "','" + dtpCA.Value + "')";
            cmd.ExecuteNonQuery();

            con.Close();
            disp_dataCA();
            disp_dataCS();
            disp_dataCE();
            disp_dataCD();
            MessageBox.Show("New Customer Added Successfully.!");
            clearCA();
            
        }

        private void btnCAclear_Click(object sender, EventArgs e)
        {
            clearCA();
        }

        private void btnCAld_Click(object sender, EventArgs e)
        {
            disp_dataCA();
        }

        private void btnCDsearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Customer where Cust_Id='" + txtCDid.Text + "' or Cust_Name='" + txtCDname.Text + "' or Cust_Tel='" + txtCDtel.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvCD.DataSource = dt;
            con.Close();

            con.Close();
        }

        private void btnCDdelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Customer where Cust_Id='" + txtCDid.Text + "'";
            cmd.ExecuteNonQuery();

            con.Close();
            disp_dataCA();
            disp_dataCS();
            disp_dataCE();
            disp_dataCD();
            MessageBox.Show("Customer Deleted Successfully.!");
            clearCD();
        }

        private void btnCDclear_Click(object sender, EventArgs e)
        {
            clearCD();
        }

        private void btnCDld_Click(object sender, EventArgs e)
        {
            disp_dataCD();
        }

        private void btnCEsearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Customer where Cust_Id='" + txtCEid.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvCE.DataSource = dt;
            con.Close();

            con.Close();

            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            txtCEname.Visible = true;
            txtCEcompany.Visible = true;
            txtCEaddress.Visible = true;
            txtCEtel.Visible = true;
            txtCEemail.Visible = true;


            con.Open();
            string sqlSelectQuery = "select * from Customer where Cust_Id='" + txtCEid.Text + "'  ";
            SqlCommand cmdd = new SqlCommand(sqlSelectQuery, con);
            SqlDataReader dr = cmdd.ExecuteReader();
            if (dr.Read())
            {
                txtCEname.Text = (dr["Cust_Name"].ToString());
                txtCEcompany.Text = (dr["Cust_Company"].ToString());
                txtCEaddress.Text = (dr["Cust_Address"].ToString());
                txtCEtel.Text = (dr["Cust_Tel"].ToString());
                txtCEemail.Text = (dr["Cust_Email"].ToString());

            }
            con.Close();

        }

        private void btnCEedit_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Customer set Cust_Name='" + txtCEname.Text + "',Cust_Company='" + txtCEcompany.Text + "',Cust_Address='" + txtCEaddress.Text + "',Cust_Tel='" + txtCEtel.Text + "',Cust_Email='" + txtCEemail.Text + "' where Cust_Id='" + txtCEid.Text + "' ";
            cmd.ExecuteNonQuery();

            con.Close();
            disp_dataCA();
            disp_dataCS();
            disp_dataCE();
            disp_dataCD();
            MessageBox.Show("Customer Edited Successfully.!");
            clearCE();
            hideEdit();
        }

        private void btnCEclear_Click(object sender, EventArgs e)
        {
            clearCE();
        }

        private void btnCEld_Click(object sender, EventArgs e)
        {
            disp_dataCE();
        }

    }
}
