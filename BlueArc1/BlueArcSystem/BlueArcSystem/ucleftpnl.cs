using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueArcSystem
{
    public partial class ucleftpnl : UserControl
    {
        public ucleftpnl()
        {
            InitializeComponent();
        }

        private void ucleftpnl_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void btnpwr_Click(object sender, EventArgs e)
        {
            if(pnlstng.Visible==false)
            {
                btnpwr.BackColor = Color.Blue;
                pnlstng.Visible = true;
                btnapply.Visible = false;
                btndark.Visible = false;
                btnlight.Visible = false;
                cmbstyle.Visible = false;
                lbltheme.Visible = false;
                lblstyle.Visible = false;
                btnexit.Visible = true;
                btnlogout.Visible = true;
            }
            else if(pnlstng.Visible ==true && btnpwr.BackColor==Color.Blue)
            {
                btnpwr.BackColor = Color.Transparent;
                pnlstng.Visible = false;
                btnapply.Visible = true;
                btndark.Visible = true;
                btnlight.Visible = true;
                cmbstyle.Visible = true;
                lbltheme.Visible = true;
                lblstyle.Visible = true;
                btnexit.Visible = false;
                btnlogout.Visible = false;
            }
            else if (pnlstng.Visible == true && btnstng.BackColor == Color.Blue)
            {
                btnstng.BackColor = Color.Transparent;
                pnlstng.Visible = false;
                btnexit.Visible = true;
                btnlogout.Visible = true;
                btnapply.Visible = false;
                btndark.Visible = false;
                btnlight.Visible = false;
                cmbstyle.Visible = false;
                lbltheme.Visible = false;
                lblstyle.Visible = false;

                btnpwr.BackColor = Color.Blue;
                pnlstng.Visible = true;
                btnapply.Visible = false;
                btndark.Visible = false;
                btnlight.Visible = false;
                cmbstyle.Visible = false;
                lbltheme.Visible = false;
                lblstyle.Visible = false;
                btnexit.Visible = true;
                btnlogout.Visible = true;
            }

        }

        private void btnstng_Click(object sender, EventArgs e)
        {
            if (pnlstng.Visible == false)
            {
                btnstng.BackColor = Color.Blue;
                pnlstng.Visible = true;
                btnexit.Visible = false;
                btnlogout.Visible = false;
                btnapply.Visible = true;
                btndark.Visible = true;
                btnlight.Visible = true;
                cmbstyle.Visible = true;
                lbltheme.Visible = true;
                lblstyle.Visible = true;

            }
            else if (pnlstng.Visible == true && btnstng.BackColor==Color.Blue)
            {

                btnstng.BackColor = Color.Transparent;
                pnlstng.Visible = false;
                btnexit.Visible = true;
                btnlogout.Visible = true;
                btnapply.Visible = false;
                btndark.Visible = false;
                btnlight.Visible = false;
                cmbstyle.Visible = false;
                lbltheme.Visible = false;
                lblstyle.Visible = false;

            }
            else if (pnlstng.Visible == true && btnpwr.BackColor == Color.Blue)
            {
                btnpwr.BackColor = Color.Transparent;
                pnlstng.Visible = false;
                btnapply.Visible = true;
                btndark.Visible = true;
                btnlight.Visible = true;
                cmbstyle.Visible = true;
                lbltheme.Visible = true;
                lblstyle.Visible = true;
                btnexit.Visible = false;
                btnlogout.Visible = false;

                btnstng.BackColor = Color.Blue;
                pnlstng.Visible = true;
                btnexit.Visible = false;
                btnlogout.Visible = false;
                btnapply.Visible = true;
                btndark.Visible = true;
                btnlight.Visible = true;
                cmbstyle.Visible = true;
                lbltheme.Visible = true;
                lblstyle.Visible = true;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("HH:mm");
            lblsec.Text = DateTime.Now.ToString("ss");
            lbldate.Text = DateTime.Now.ToString("MMMM dd");
            lblday.Text = DateTime.Now.ToString("dddd");

        }

        private void metroButton2_Click(object sender, EventArgs e)//dark
        {
            pnlright.BackColor=Color.MidnightBlue;
            pnlstng.BackColor = Color.DarkBlue;
            lblstyle.BackColor = Color.DarkBlue;
            lbltheme.BackColor = Color.DarkBlue;
            pbbw.Visible = true;
            pbcolor.Visible = false;
            pnlstng.Visible = false;
            btnstng.BackColor = Color.Transparent;

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You want to Exit.?", "Exit Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnlight_Click(object sender, EventArgs e)
        {
            pnlright.BackColor = Color.DodgerBlue;
            pnlstng.BackColor = Color.Blue;
            lblstyle.BackColor = Color.Blue;
            lbltheme.BackColor = Color.Blue;
            pbbw.Visible = false;
            pbcolor.Visible = true;
            pnlstng.Visible = false;
            btnstng.BackColor = Color.Transparent;
        }
    }
}
