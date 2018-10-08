namespace BlueArcSystem
{
    partial class fmmktng
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmmktng));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblday = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblsec = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnCustomerM = new System.Windows.Forms.Button();
            this.btnSupplierM = new System.Windows.Forms.Button();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.ucleftpnl1 = new BlueArcSystem.ucleftpnl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblday);
            this.panel1.Controls.Add(this.lbldate);
            this.panel1.Controls.Add(this.lblsec);
            this.panel1.Controls.Add(this.lbltime);
            this.panel1.Location = new System.Drawing.Point(972, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 148);
            this.panel1.TabIndex = 7;
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblday.Location = new System.Drawing.Point(3, 51);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(0, 35);
            this.lblday.TabIndex = 3;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(79, 91);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(0, 29);
            this.lbldate.TabIndex = 2;
            // 
            // lblsec
            // 
            this.lblsec.AutoSize = true;
            this.lblsec.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsec.Location = new System.Drawing.Point(149, 18);
            this.lblsec.Name = "lblsec";
            this.lblsec.Size = new System.Drawing.Size(0, 25);
            this.lblsec.TabIndex = 1;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(15, 4);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(0, 42);
            this.lbltime.TabIndex = 0;
            // 
            // btnlogout
            // 
            this.btnlogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlogout.BackColor = System.Drawing.Color.White;
            this.btnlogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlogout.BackgroundImage")));
            this.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlogout.Location = new System.Drawing.Point(1016, 12);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnlogout.Size = new System.Drawing.Size(75, 75);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnexit
            // 
            this.btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexit.BackColor = System.Drawing.Color.White;
            this.btnexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexit.BackgroundImage")));
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.Location = new System.Drawing.Point(1097, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnexit.Size = new System.Drawing.Size(75, 75);
            this.btnexit.TabIndex = 5;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnCustomerM
            // 
            this.btnCustomerM.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCustomerM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerM.Location = new System.Drawing.Point(387, 33);
            this.btnCustomerM.Name = "btnCustomerM";
            this.btnCustomerM.Size = new System.Drawing.Size(300, 100);
            this.btnCustomerM.TabIndex = 8;
            this.btnCustomerM.Text = "Manage Customers";
            this.btnCustomerM.UseVisualStyleBackColor = false;
            this.btnCustomerM.Click += new System.EventHandler(this.btnCustomerM_Click);
            // 
            // btnSupplierM
            // 
            this.btnSupplierM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierM.Location = new System.Drawing.Point(387, 139);
            this.btnSupplierM.Name = "btnSupplierM";
            this.btnSupplierM.Size = new System.Drawing.Size(300, 100);
            this.btnSupplierM.TabIndex = 8;
            this.btnSupplierM.Text = "Manage Suppliers";
            this.btnSupplierM.UseVisualStyleBackColor = true;
            this.btnSupplierM.Click += new System.EventHandler(this.btnSupplierM_Click);
            // 
            // ucleftpnl1
            // 
            this.ucleftpnl1.BackColor = System.Drawing.Color.Transparent;
            this.ucleftpnl1.Location = new System.Drawing.Point(0, 63);
            this.ucleftpnl1.Name = "ucleftpnl1";
            this.ucleftpnl1.Size = new System.Drawing.Size(231, 645);
            this.ucleftpnl1.TabIndex = 10;
            // 
            // fmmktng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.ucleftpnl1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btnSupplierM);
            this.Controls.Add(this.btnCustomerM);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnexit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmmktng";
            this.Text = "Marketing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblsec;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnCustomerM;
        private System.Windows.Forms.Button btnSupplierM;
        private MetroFramework.Controls.MetroTile metroTile1;
        private ucleftpnl ucleftpnl1;
    }
}