namespace BlueArcSystem
{
    partial class ucleftpnl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucleftpnl));
            this.pnlright = new MetroFramework.Controls.MetroPanel();
            this.pnlstng = new System.Windows.Forms.Panel();
            this.btnexit = new MetroFramework.Controls.MetroTile();
            this.lblstyle = new MetroFramework.Controls.MetroLabel();
            this.btnlogout = new MetroFramework.Controls.MetroTile();
            this.btnapply = new MetroFramework.Controls.MetroButton();
            this.lbltheme = new MetroFramework.Controls.MetroLabel();
            this.btndark = new MetroFramework.Controls.MetroButton();
            this.cmbstyle = new System.Windows.Forms.ComboBox();
            this.btnlight = new MetroFramework.Controls.MetroButton();
            this.btnstng = new System.Windows.Forms.Button();
            this.pbbw = new System.Windows.Forms.PictureBox();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.pbcolor = new System.Windows.Forms.PictureBox();
            this.btnpwr = new System.Windows.Forms.Button();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblday = new System.Windows.Forms.Label();
            this.lblsec = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlright.SuspendLayout();
            this.pnlstng.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbbw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcolor)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlright
            // 
            this.pnlright.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlright.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.pnlright.Controls.Add(this.pnlstng);
            this.pnlright.Controls.Add(this.btnstng);
            this.pnlright.Controls.Add(this.pbbw);
            this.pnlright.Controls.Add(this.btnrefresh);
            this.pnlright.Controls.Add(this.pbcolor);
            this.pnlright.Controls.Add(this.btnpwr);
            this.pnlright.Controls.Add(this.lbldate);
            this.pnlright.Controls.Add(this.lblday);
            this.pnlright.Controls.Add(this.lblsec);
            this.pnlright.Controls.Add(this.lbltime);
            this.pnlright.Controls.Add(this.monthCalendar1);
            this.pnlright.CustomBackground = true;
            this.pnlright.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlright.HorizontalScrollbarBarColor = true;
            this.pnlright.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlright.HorizontalScrollbarSize = 10;
            this.pnlright.Location = new System.Drawing.Point(0, 0);
            this.pnlright.Name = "pnlright";
            this.pnlright.Size = new System.Drawing.Size(228, 645);
            this.pnlright.TabIndex = 1;
            this.pnlright.VerticalScrollbarBarColor = true;
            this.pnlright.VerticalScrollbarHighlightOnWheel = false;
            this.pnlright.VerticalScrollbarSize = 10;
            // 
            // pnlstng
            // 
            this.pnlstng.BackColor = System.Drawing.Color.Blue;
            this.pnlstng.Controls.Add(this.btnexit);
            this.pnlstng.Controls.Add(this.lblstyle);
            this.pnlstng.Controls.Add(this.btnlogout);
            this.pnlstng.Controls.Add(this.btnapply);
            this.pnlstng.Controls.Add(this.lbltheme);
            this.pnlstng.Controls.Add(this.btndark);
            this.pnlstng.Controls.Add(this.cmbstyle);
            this.pnlstng.Controls.Add(this.btnlight);
            this.pnlstng.Location = new System.Drawing.Point(3, 249);
            this.pnlstng.Name = "pnlstng";
            this.pnlstng.Size = new System.Drawing.Size(177, 124);
            this.pnlstng.TabIndex = 3;
            this.pnlstng.Visible = false;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnexit.CustomBackground = true;
            this.btnexit.Location = new System.Drawing.Point(13, 62);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(161, 50);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "Exit";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnexit.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnexit.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblstyle
            // 
            this.lblstyle.AutoSize = true;
            this.lblstyle.BackColor = System.Drawing.Color.Blue;
            this.lblstyle.CustomBackground = true;
            this.lblstyle.CustomForeColor = true;
            this.lblstyle.ForeColor = System.Drawing.Color.White;
            this.lblstyle.Location = new System.Drawing.Point(5, 54);
            this.lblstyle.Name = "lblstyle";
            this.lblstyle.Size = new System.Drawing.Size(36, 19);
            this.lblstyle.TabIndex = 2;
            this.lblstyle.Text = "Style";
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnlogout.CustomBackground = true;
            this.btnlogout.Location = new System.Drawing.Point(13, 6);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(161, 50);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.Text = "Log out";
            this.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlogout.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnlogout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnapply
            // 
            this.btnapply.Location = new System.Drawing.Point(99, 95);
            this.btnapply.Name = "btnapply";
            this.btnapply.Size = new System.Drawing.Size(75, 23);
            this.btnapply.TabIndex = 5;
            this.btnapply.Text = "Apply";
            // 
            // lbltheme
            // 
            this.lbltheme.AutoSize = true;
            this.lbltheme.BackColor = System.Drawing.Color.Blue;
            this.lbltheme.CustomBackground = true;
            this.lbltheme.CustomForeColor = true;
            this.lbltheme.ForeColor = System.Drawing.Color.White;
            this.lbltheme.Location = new System.Drawing.Point(5, 14);
            this.lbltheme.Name = "lbltheme";
            this.lbltheme.Size = new System.Drawing.Size(49, 19);
            this.lbltheme.TabIndex = 2;
            this.lbltheme.Text = "Theme";
            // 
            // btndark
            // 
            this.btndark.Location = new System.Drawing.Point(120, 14);
            this.btndark.Name = "btndark";
            this.btndark.Size = new System.Drawing.Size(54, 23);
            this.btndark.TabIndex = 3;
            this.btndark.Text = "Dark";
            this.btndark.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btndark.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // cmbstyle
            // 
            this.cmbstyle.FormattingEnabled = true;
            this.cmbstyle.Location = new System.Drawing.Point(60, 54);
            this.cmbstyle.Name = "cmbstyle";
            this.cmbstyle.Size = new System.Drawing.Size(114, 21);
            this.cmbstyle.TabIndex = 4;
            // 
            // btnlight
            // 
            this.btnlight.Location = new System.Drawing.Point(60, 14);
            this.btnlight.Name = "btnlight";
            this.btnlight.Size = new System.Drawing.Size(54, 23);
            this.btnlight.TabIndex = 3;
            this.btnlight.Text = "Light";
            this.btnlight.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnlight.Click += new System.EventHandler(this.btnlight_Click);
            // 
            // btnstng
            // 
            this.btnstng.BackColor = System.Drawing.Color.Transparent;
            this.btnstng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnstng.BackgroundImage")));
            this.btnstng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnstng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstng.Location = new System.Drawing.Point(53, 203);
            this.btnstng.Name = "btnstng";
            this.btnstng.Size = new System.Drawing.Size(45, 45);
            this.btnstng.TabIndex = 5;
            this.btnstng.UseVisualStyleBackColor = false;
            this.btnstng.Click += new System.EventHandler(this.btnstng_Click);
            // 
            // pbbw
            // 
            this.pbbw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbbw.BackgroundImage")));
            this.pbbw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbbw.Location = new System.Drawing.Point(3, 3);
            this.pbbw.Name = "pbbw";
            this.pbbw.Size = new System.Drawing.Size(222, 83);
            this.pbbw.TabIndex = 6;
            this.pbbw.TabStop = false;
            this.pbbw.Visible = false;
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnrefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrefresh.BackgroundImage")));
            this.btnrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.Location = new System.Drawing.Point(104, 203);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(45, 45);
            this.btnrefresh.TabIndex = 5;
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnstng_Click);
            // 
            // pbcolor
            // 
            this.pbcolor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbcolor.BackgroundImage")));
            this.pbcolor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbcolor.Location = new System.Drawing.Point(3, 3);
            this.pbcolor.Name = "pbcolor";
            this.pbcolor.Size = new System.Drawing.Size(222, 83);
            this.pbcolor.TabIndex = 6;
            this.pbcolor.TabStop = false;
            // 
            // btnpwr
            // 
            this.btnpwr.BackColor = System.Drawing.Color.Transparent;
            this.btnpwr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpwr.BackgroundImage")));
            this.btnpwr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnpwr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpwr.Location = new System.Drawing.Point(2, 203);
            this.btnpwr.Name = "btnpwr";
            this.btnpwr.Size = new System.Drawing.Size(45, 45);
            this.btnpwr.TabIndex = 5;
            this.btnpwr.UseVisualStyleBackColor = false;
            this.btnpwr.Click += new System.EventHandler(this.btnpwr_Click);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(6, 167);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(163, 33);
            this.lbldate.TabIndex = 3;
            this.lbldate.Text = "88-88-8888";
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblday.Location = new System.Drawing.Point(4, 131);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(179, 37);
            this.lblday.TabIndex = 3;
            this.lblday.Text = "888888888";
            // 
            // lblsec
            // 
            this.lblsec.AutoSize = true;
            this.lblsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsec.Location = new System.Drawing.Point(121, 102);
            this.lblsec.Name = "lblsec";
            this.lblsec.Size = new System.Drawing.Size(39, 29);
            this.lblsec.TabIndex = 3;
            this.lblsec.Text = "88";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(3, 89);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(117, 42);
            this.lbltime.TabIndex = 3;
            this.lbltime.Text = "88:88";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 449);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucleftpnl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlright);
            this.Name = "ucleftpnl";
            this.Size = new System.Drawing.Size(640, 645);
            this.Load += new System.EventHandler(this.ucleftpnl_Load);
            this.pnlright.ResumeLayout(false);
            this.pnlright.PerformLayout();
            this.pnlstng.ResumeLayout(false);
            this.pnlstng.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbbw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcolor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlright;
        private System.Windows.Forms.Button btnstng;
        private System.Windows.Forms.Button btnpwr;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Label lblsec;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnrefresh;
        private MetroFramework.Controls.MetroTile btnexit;
        private MetroFramework.Controls.MetroTile btnlogout;
        private System.Windows.Forms.PictureBox pbbw;
        private System.Windows.Forms.PictureBox pbcolor;
        private MetroFramework.Controls.MetroButton btnapply;
        private System.Windows.Forms.ComboBox cmbstyle;
        private MetroFramework.Controls.MetroButton btndark;
        private MetroFramework.Controls.MetroButton btnlight;
        private MetroFramework.Controls.MetroLabel lblstyle;
        private MetroFramework.Controls.MetroLabel lbltheme;
        private System.Windows.Forms.Panel pnlstng;
    }
}
