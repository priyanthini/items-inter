namespace BlueArcSystem
{
    partial class fmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmlogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtun = new System.Windows.Forms.TextBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbtype = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(249, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(249, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtun
            // 
            this.txtun.Location = new System.Drawing.Point(377, 137);
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(200, 20);
            this.txtun.TabIndex = 1;
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(377, 192);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(200, 20);
            this.txtpw.TabIndex = 2;
            this.txtpw.UseSystemPasswordChar = true;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(371, 259);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(100, 25);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(477, 259);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(100, 25);
            this.btnreset.TabIndex = 4;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(249, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type Of User";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(29, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 60);
            this.label4.TabIndex = 8;
            // 
            // cmbtype
            // 
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.ItemHeight = 23;
            this.cmbtype.Items.AddRange(new object[] {
            "Administrator",
            "Marketing",
            "Finance"});
            this.cmbtype.Location = new System.Drawing.Point(377, 83);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(200, 29);
            this.cmbtype.TabIndex = 9;
            // 
            // fmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.cmbtype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.txtun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmlogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtun;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox cmbtype;
    }
}

