namespace BlueArcSystem
{
    partial class Item
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.IID = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Itype = new System.Windows.Forms.TextBox();
            this.Isearch = new System.Windows.Forms.Button();
            this.Iclear = new System.Windows.Forms.Button();
            this.ucleftpnl1 = new BlueArcSystem.ucleftpnl();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.eID = new System.Windows.Forms.TextBox();
            this.eItype = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.eIcategory = new System.Windows.Forms.TextBox();
            this.eIdescription = new System.Windows.Forms.TextBox();
            this.eIunit = new System.Windows.Forms.TextBox();
            this.Iupdate = new System.Windows.Forms.Button();
            this.itemsearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.delitemsearch = new System.Windows.Forms.Button();
            this.idelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.ItemSize = new System.Drawing.Size(48, 21);
            this.tabControl1.Location = new System.Drawing.Point(348, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1090, 488);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.Iclear);
            this.tabPage1.Controls.Add(this.Isearch);
            this.tabPage1.Controls.Add(this.Itype);
            this.tabPage1.Controls.Add(this.IID);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1082, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Item";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // IID
            // 
            this.IID.Location = new System.Drawing.Point(173, 45);
            this.IID.Mask = "Numeric";
            this.IID.Name = "IID";
            this.IID.Size = new System.Drawing.Size(337, 22);
            this.IID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Id";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1082, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Item";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.itemsearch);
            this.tabPage3.Controls.Add(this.Iupdate);
            this.tabPage3.Controls.Add(this.eIunit);
            this.tabPage3.Controls.Add(this.eIdescription);
            this.tabPage3.Controls.Add(this.eIcategory);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.eItype);
            this.tabPage3.Controls.Add(this.eID);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1082, 459);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Edit Item";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.idelete);
            this.tabPage4.Controls.Add(this.delitemsearch);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1082, 459);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Delete Item";
            // 
            // Itype
            // 
            this.Itype.Location = new System.Drawing.Point(173, 81);
            this.Itype.Name = "Itype";
            this.Itype.Size = new System.Drawing.Size(337, 22);
            this.Itype.TabIndex = 6;
            // 
            // Isearch
            // 
            this.Isearch.Location = new System.Drawing.Point(855, 36);
            this.Isearch.Name = "Isearch";
            this.Isearch.Size = new System.Drawing.Size(184, 67);
            this.Isearch.TabIndex = 10;
            this.Isearch.Text = "SEARCH ITEM";
            this.Isearch.UseVisualStyleBackColor = true;
            // 
            // Iclear
            // 
            this.Iclear.Location = new System.Drawing.Point(855, 126);
            this.Iclear.Name = "Iclear";
            this.Iclear.Size = new System.Drawing.Size(184, 73);
            this.Iclear.TabIndex = 11;
            this.Iclear.Text = "CLEAR";
            this.Iclear.UseVisualStyleBackColor = true;
            this.Iclear.Click += new System.EventHandler(this.button2_Click);
            // 
            // ucleftpnl1
            // 
            this.ucleftpnl1.BackColor = System.Drawing.Color.Transparent;
            this.ucleftpnl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucleftpnl1.Location = new System.Drawing.Point(27, 74);
            this.ucleftpnl1.Margin = new System.Windows.Forms.Padding(5);
            this.ucleftpnl1.Name = "ucleftpnl1";
            this.ucleftpnl1.Size = new System.Drawing.Size(313, 578);
            this.ucleftpnl1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Item ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Item Type";
            // 
            // eID
            // 
            this.eID.Location = new System.Drawing.Point(172, 61);
            this.eID.Name = "eID";
            this.eID.Size = new System.Drawing.Size(269, 22);
            this.eID.TabIndex = 2;
            // 
            // eItype
            // 
            this.eItype.Location = new System.Drawing.Point(172, 105);
            this.eItype.Name = "eItype";
            this.eItype.Size = new System.Drawing.Size(269, 22);
            this.eItype.TabIndex = 3;
            this.eItype.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Category";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Unit price";
            // 
            // eIcategory
            // 
            this.eIcategory.Location = new System.Drawing.Point(172, 144);
            this.eIcategory.Name = "eIcategory";
            this.eIcategory.Size = new System.Drawing.Size(269, 22);
            this.eIcategory.TabIndex = 7;
            // 
            // eIdescription
            // 
            this.eIdescription.Location = new System.Drawing.Point(172, 177);
            this.eIdescription.Name = "eIdescription";
            this.eIdescription.Size = new System.Drawing.Size(269, 22);
            this.eIdescription.TabIndex = 8;
            this.eIdescription.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // eIunit
            // 
            this.eIunit.Location = new System.Drawing.Point(172, 211);
            this.eIunit.Name = "eIunit";
            this.eIunit.Size = new System.Drawing.Size(269, 22);
            this.eIunit.TabIndex = 9;
            // 
            // Iupdate
            // 
            this.Iupdate.Location = new System.Drawing.Point(656, 59);
            this.Iupdate.Name = "Iupdate";
            this.Iupdate.Size = new System.Drawing.Size(180, 63);
            this.Iupdate.TabIndex = 10;
            this.Iupdate.Text = "UPDATE";
            this.Iupdate.UseVisualStyleBackColor = true;
            // 
            // itemsearch
            // 
            this.itemsearch.Location = new System.Drawing.Point(656, 142);
            this.itemsearch.Name = "itemsearch";
            this.itemsearch.Size = new System.Drawing.Size(180, 71);
            this.itemsearch.TabIndex = 11;
            this.itemsearch.Text = "SEARCH";
            this.itemsearch.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Item ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Item type";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(192, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(276, 22);
            this.textBox2.TabIndex = 3;
            // 
            // delitemsearch
            // 
            this.delitemsearch.Location = new System.Drawing.Point(727, 66);
            this.delitemsearch.Name = "delitemsearch";
            this.delitemsearch.Size = new System.Drawing.Size(150, 67);
            this.delitemsearch.TabIndex = 4;
            this.delitemsearch.Text = "SEARCH";
            this.delitemsearch.UseVisualStyleBackColor = true;
            // 
            // idelete
            // 
            this.idelete.Location = new System.Drawing.Point(727, 170);
            this.idelete.Name = "idelete";
            this.idelete.Size = new System.Drawing.Size(150, 69);
            this.idelete.TabIndex = 5;
            this.idelete.Text = "DELETE";
            this.idelete.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Item ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Item tytpe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Category";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Description";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "Unit price";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(299, 22);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(160, 92);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(299, 22);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(160, 123);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(299, 22);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(160, 155);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(299, 22);
            this.textBox6.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(160, 185);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(299, 22);
            this.textBox7.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 83);
            this.button1.TabIndex = 10;
            this.button1.Text = "ADD ITEM";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 677);
            this.ControlBox = false;
            this.Controls.Add(this.ucleftpnl1);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Item";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Manage Items";
            this.Load += new System.EventHandler(this.Item_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.MaskedTextBox IID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Itype;
        private System.Windows.Forms.Button Iclear;
        private System.Windows.Forms.Button Isearch;
        private ucleftpnl ucleftpnl1;
        private System.Windows.Forms.TextBox eItype;
        private System.Windows.Forms.TextBox eID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox eIunit;
        private System.Windows.Forms.TextBox eIdescription;
        private System.Windows.Forms.TextBox eIcategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button itemsearch;
        private System.Windows.Forms.Button Iupdate;
        private System.Windows.Forms.Button idelete;
        private System.Windows.Forms.Button delitemsearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}