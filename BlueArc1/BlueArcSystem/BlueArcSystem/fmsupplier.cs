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
    public partial class fmsupplier : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\BlueArc\BlueArcSystem\BlueArcSystem\BlueArcDb.mdf; Integrated Security = True; Connect Timeout = 30");

        public fmsupplier()
        {
            InitializeComponent();
        }

        private void fmsupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blueArcDbDataSet1.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.blueArcDbDataSet1.Supplier);
            timer.Start();
            hideedit();
            disp_dataSA();
            disp_dataSS();
            disp_dataSE();
            disp_dataSD();


        }
        public void cleardataSS()
        {
            txtSSBname.Text = "";
            txtSSid.Text = "";
            txtSSname.Text = "";
            txtSStel.Text = "";
        }
        public void cleardataSA()
        {
            txtSABaddress.Text = "";
            txtSABname.Text = "";
            txtSABregno.Text = "";
            txtSAcontactname.Text = "";
            txtSAcredit.Text = "";
            txtSAemail.Text = "";
            txtSAexpe.Text = "";
            txtSAfax.Text = "";
            txtSAid.Text = "";
            txtSAname.Text = "";
            txtSAtel.Text = "";
            txtSAtransport.Text = "";
            dtpSAregdt.Text = "";

        }
        public void cleardataSE()
        {
            txtSEBaddress.Text = "";
            txtSEBname.Text = "";
            txtSEBregno.Text = "";
            txtSEcontactname.Text = "";
            txtSEcredit.Text = "";
            txtSEemail.Text = "";
            txtSEexpe.Text = "";
            txtSEfax.Text = "";
            txtSEid.Text = "";
            txtSEname.Text = "";
            txtSEtel.Text = "";
            txtSEtransport.Text = "";
            dtpSEregdt.Text = "";
        }
        public void cleardataSD()
        {
            txtSDBname.Text = "";
            txtSDid.Text = "";
            txtSDname.Text = "";
            txtSDtel.Text = "";
        }

        public void disp_dataSA()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Supplier";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvSA.DataSource = dt;
            con.Close();
        }

        public void disp_dataSS()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Supplier";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvSS.DataSource = dt;
            con.Close();
        }

        public void disp_dataSE()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Supplier";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvSE.DataSource = dt;
            con.Close();
        }

        public void disp_dataSD()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Supplier";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvSD.DataSource = dt;
            con.Close();
        }

        public void hideedit()
        {
            txtSEBaddress.Visible = false;
            txtSEBname.Visible = false;
            txtSEBregno.Visible = false;
            txtSEcontactname.Visible = false;
            txtSEcredit.Visible = false;
            txtSEemail.Visible = false;
            txtSEexpe.Visible = false;
            txtSEfax.Visible = false;
            txtSEname.Visible = false;
            txtSEtel.Visible = false;
            txtSEtransport.Visible = false;
            dtpSEregdt.Visible = false;
            label100.Visible = false;
            label99.Visible = false;
            label98.Visible = false;
            label97.Visible = false;
            label96.Visible = false;
            label95.Visible = false;
            label94.Visible = false;
            label93.Visible = false;
            label92.Visible = false;
            label91.Visible = false;
            label90.Visible = false;
            label89.Visible = false;
            btnSEedit.Visible = false;
        }

        private void btnSSclear_Click(object sender, EventArgs e)
        {
            cleardataSS();
        }

        private void btnSAclear_Click(object sender, EventArgs e)
        {
            cleardataSA();
        }

        private void btnSEclear_Click(object sender, EventArgs e)
        {
            cleardataSE();
        }

        private void btnSDclear_Click(object sender, EventArgs e)
        {
            cleardataSD();
        }

        private void btnSSld_Click(object sender, EventArgs e)
        {
            disp_dataSS();
        }

        private void btnSAld_Click(object sender, EventArgs e)
        {
            disp_dataSA();
        }

        private void btnSEld_Click(object sender, EventArgs e)
        {
            disp_dataSE();
        }

        private void btnSDld_Click(object sender, EventArgs e)
        {
            disp_dataSD();
        }

        private void btnSAadd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Supplier values('" + txtSAid.Text + "','" + txtSAname.Text + "','" + txtSABname.Text + "','" + txtSABaddress.Text + "','" + txtSABregno.Text + "','" + dtpSAregdt.Value + "','" + txtSAtel.Text + "','" + txtSAfax.Text + "','" + txtSAemail.Text + "','" + txtSAcontactname.Text + "','" + txtSAcredit.Text + "','" + txtSAtransport.Text + "','" + txtSAexpe.Text + "','" + dtpSA.Value + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_dataSA();
            disp_dataSS();
            disp_dataSE();
            disp_dataSD();
            MessageBox.Show("New Supplier added successfully.!");
            cleardataSA();
        }

        private void btnSDdelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Supplier where Supp_Id='" + txtSDid.Text + "'";
            cmd.ExecuteNonQuery();

            con.Close();
            disp_dataSA();
            disp_dataSS();
            disp_dataSE();
            disp_dataSD();
            MessageBox.Show("Supplier Deleted Successfully.!");
            cleardataSD();
        }

        private void btnSEedit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Supplier set Supp_Name='" + txtSEname.Text + "',Supp_BusinessName='" + txtSEBname.Text + "',Supp_BusinessAddress='" + txtSEBaddress.Text + "',Supp_BusinessRegNo='" + txtSEBregno.Text + "',Supp_BusinessRegDate='" + dtpSEregdt.Value + "',Supp_Tel='" + txtSEtel.Text + "',Supp_Fax='" + txtSEfax.Text + "',Supp_Email='" + txtSEemail.Text + "',Supp_ContactName='" + txtSEcontactname.Text + "',Supp_CrdtCondition='" + txtSEcredit.Text + "',Supp_Transport='" + txtSEtransport.Text + "',Supp_Experience='" + txtSEexpe.Text + "'       where Supp_Id='" + txtSEid.Text + "'";
            cmd.ExecuteNonQuery();

            con.Close();
            disp_dataSA();
            disp_dataSS();
            disp_dataSE();
            disp_dataSD();
            MessageBox.Show("Supplier Edited Successfully.!");
            cleardataSE();
            hideedit();
        }

        private void btnSSsearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Supplier where Supp_Id='" + txtSSid.Text + "' or  Supp_Name='" + txtSSname.Text + "' or Supp_Tel='" + txtSStel.Text + "' or  Supp_BusinessName='" + txtSSBname.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvSS.DataSource = dt;
            con.Close();
        }

        private void btnSEsearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Supplier where Supp_Id='" + txtSEid.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvSE.DataSource = dt;
            con.Close();

            txtSEBaddress.Visible = true;
            txtSEBname.Visible = true;
            txtSEBregno.Visible = true;
            txtSEcontactname.Visible = true;
            txtSEcredit.Visible = true;
            txtSEemail.Visible = true;
            txtSEexpe.Visible = true;
            txtSEfax.Visible = true;
            txtSEname.Visible = true;
            txtSEtel.Visible = true;
            txtSEtransport.Visible = true;
            dtpSEregdt.Visible = true;
            label100.Visible = true;
            label99.Visible = true;
            label98.Visible = true;
            label97.Visible = true;
            label96.Visible = true;
            label95.Visible = true;
            label94.Visible = true;
            label93.Visible = true;
            label92.Visible = true;
            label91.Visible = true;
            label90.Visible = true;
            label89.Visible = true;
            btnSEedit.Visible = true;

            con.Open();
            string sqlSelectQuery = "select * from Supplier where Supp_Id='" + txtSEid.Text + "'  ";
            SqlCommand cmdd = new SqlCommand(sqlSelectQuery, con);
            SqlDataReader dr = cmdd.ExecuteReader();
            if (dr.Read())
            {
                txtSEBaddress.Text = (dr["Supp_BusinessAddress"].ToString());
                txtSEBname.Text = (dr["Supp_BusinessName"].ToString());
                txtSEBregno.Text = (dr["Supp_BusinessRegNo"].ToString());
                txtSEcontactname.Text = (dr["Supp_ContactName"].ToString());
                txtSEcredit.Text = (dr["Supp_CrdtCondition"].ToString());
                txtSEemail.Text = (dr["Supp_Email"].ToString());
                txtSEexpe.Text = (dr["Supp_Experience"].ToString());
                txtSEfax.Text = (dr["Supp_Fax"].ToString());
                txtSEname.Text = (dr["Supp_Name"].ToString());
                txtSEtel.Text = (dr["Supp_Tel"].ToString());
                txtSEtransport.Text = (dr["Supp_Transport"].ToString());
                dtpSEregdt.Text = (dr["Supp_BusinessRegDate"].ToString());
            }
            con.Close();
        }

        private void btnSDsearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Supplier where Supp_Id='" + txtSDid.Text + "' or Supp_Name='" + txtSDname.Text + "' or Supp_BusinessName='" + txtSDBname.Text + "' or Supp_Tel='" + txtSDtel.Text + "'  ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvSD.DataSource = dt;
            con.Close();
        }
    }
}
