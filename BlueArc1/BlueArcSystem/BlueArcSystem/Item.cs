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
    public partial class Item : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Priya\Documents\GitHub\items-inter\BlueArc1\BlueArcSystem\BlueArcSystem\ItemsDb.mdf;Integrated Security=True")
        public Item()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Item_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itemsDbDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.itemsDbDataSet.Items);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Items where Item Id='" + IId.Text + "' and Item Type='" + IType.Text + "';
            cmd.ExecuteNonQuery();
            con.Close();
            IId.Text = "";
            IType.Text = "";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Itype_TextChanged(object sender, EventArgs e)
        {

        }

        private void IAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Items values('"+AIId.Text+ "','" +AIType.Text+ "','" +AICategory.Text+ "','" +AIDescription.Text+ "','" +AIUnit.Text +"')";
            cmd.ExecuteNonQuery();
            con.Close();
            AIId.Text = "";
            AIType.Text = "";
            AICategory.Text = "";
            AIDescription.Text = "";
            AIUnit.Text = "";

            MessageBox.Show("Item Insertion Is Successful!");
        }

        private void A001(object sender, EventArgs e)
        {

        }

        private void Isearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Items where Item Id='" + IId.Text + "' Item Type='"+IType.Text+"';
            cmd.ExecuteNonQuery();
            con.Close();
            IId.Text = "";
            IType.Text = "";
            
        }

        private void IUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Items set Item Id='" + EIId.Text + "', Item Type= '" + EIType.Text + "',Category='" + EICategory.Text + "',Description='" + EIDescription.Text + "',Unit price='" + EIUnit.Text + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
            EIId.Text = "";
            EIType.Text = "";
            EICategory.Text = "";
            EIDescription.Text = "";
            EIUnit.Text = "";

            MessageBox.Show("Item Updated Successfully!");
        }

        private void IDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Items where Item Id='"+DIId.Text+"' and Item Type='"+DIType.Text+"';
            cmd.ExecuteNonQuery();
            con.Close();
            DIId.Text = "";
            DIType.Text = "";
            
        }

        private void DIId_TextChanged(object sender, EventArgs e)
        {

        }

        private void DItemSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Items where Item Id='"+DIId.Text+"';
            cmd.ExecuteNonQuery();
            con.Close();
            DIId.Text = "";
            DIType.Text = "";

        }

        private void ItemSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Items where Item Id='" + EIId.Text + "';
            cmd.ExecuteNonQuery();
            con.Close();
            EIId.Text = "";
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
