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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.IId = new System.Windows.Forms.TextBox();
            this.IClear = new System.Windows.Forms.Button();
            this.Isearch = new System.Windows.Forms.Button();
            this.IType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IAdd = new System.Windows.Forms.Button();
            this.AIUnit = new System.Windows.Forms.TextBox();
            this.AIDescription = new System.Windows.Forms.TextBox();
            this.AICategory = new System.Windows.Forms.TextBox();
            this.AIType = new System.Windows.Forms.TextBox();
            this.AIId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ItemSearch = new System.Windows.Forms.Button();
            this.IUpdate = new System.Windows.Forms.Button();
            this.EIUnit = new System.Windows.Forms.TextBox();
            this.EIDescription = new System.Windows.Forms.TextBox();
            this.EICategory = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EIType = new System.Windows.Forms.TextBox();
            this.EIId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.IDelete = new System.Windows.Forms.Button();
            this.DItemSearch = new System.Windows.Forms.Button();
            this.DIType = new System.Windows.Forms.TextBox();
            this.DIId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsDbDataSet = new BlueArcSystem.ItemsDbDataSet();
            this.itemsTableAdapter = new BlueArcSystem.ItemsDbDataSetTableAdapters.ItemsTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(48, 21);
            this.tabControl1.Location = new System.Drawing.Point(348, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1090, 488);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage1.Controls.Add(this.IId);
            this.tabPage1.Controls.Add(this.IClear);
            this.tabPage1.Controls.Add(this.Isearch);
            this.tabPage1.Controls.Add(this.IType);
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
            // IId
            // 
            this.IId.Location = new System.Drawing.Point(173, 39);
            this.IId.Name = "IId";
            this.IId.Size = new System.Drawing.Size(337, 27);
            this.IId.TabIndex = 12;
            // 
            // IClear
            // 
            this.IClear.BackColor = System.Drawing.Color.Aquamarine;
            this.IClear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IClear.Location = new System.Drawing.Point(855, 126);
            this.IClear.Name = "IClear";
            this.IClear.Size = new System.Drawing.Size(184, 62);
            this.IClear.TabIndex = 11;
            this.IClear.Text = "CLEAR";
            this.IClear.UseVisualStyleBackColor = false;
            this.IClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // Isearch
            // 
            this.Isearch.BackColor = System.Drawing.Color.Aquamarine;
            this.Isearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Isearch.Location = new System.Drawing.Point(855, 36);
            this.Isearch.Name = "Isearch";
            this.Isearch.Size = new System.Drawing.Size(184, 67);
            this.Isearch.TabIndex = 10;
            this.Isearch.Text = "SEARCH ITEM";
            this.Isearch.UseVisualStyleBackColor = false;
            this.Isearch.Click += new System.EventHandler(this.Isearch_Click);
            // 
            // IType
            // 
            this.IType.Location = new System.Drawing.Point(173, 81);
            this.IType.Name = "IType";
            this.IType.Size = new System.Drawing.Size(337, 27);
            this.IType.TabIndex = 6;
            this.IType.TextChanged += new System.EventHandler(this.Itype_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Id";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.IAdd);
            this.tabPage2.Controls.Add(this.AIUnit);
            this.tabPage2.Controls.Add(this.AIDescription);
            this.tabPage2.Controls.Add(this.AICategory);
            this.tabPage2.Controls.Add(this.AIType);
            this.tabPage2.Controls.Add(this.AIId);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1082, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Item";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIdDataGridViewTextBoxColumn,
            this.itemTypeDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(120, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(542, 185);
            this.dataGridView1.TabIndex = 11;
            // 
            // IAdd
            // 
            this.IAdd.BackColor = System.Drawing.Color.Aquamarine;
            this.IAdd.Location = new System.Drawing.Point(710, 57);
            this.IAdd.Name = "IAdd";
            this.IAdd.Size = new System.Drawing.Size(163, 83);
            this.IAdd.TabIndex = 10;
            this.IAdd.Text = "ADD ITEM";
            this.IAdd.UseVisualStyleBackColor = false;
            this.IAdd.Click += new System.EventHandler(this.IAdd_Click);
            // 
            // AIUnit
            // 
            this.AIUnit.Location = new System.Drawing.Point(160, 189);
            this.AIUnit.Name = "AIUnit";
            this.AIUnit.Size = new System.Drawing.Size(299, 27);
            this.AIUnit.TabIndex = 9;
            // 
            // AIDescription
            // 
            this.AIDescription.Location = new System.Drawing.Point(160, 156);
            this.AIDescription.Name = "AIDescription";
            this.AIDescription.Size = new System.Drawing.Size(299, 27);
            this.AIDescription.TabIndex = 8;
            // 
            // AICategory
            // 
            this.AICategory.Location = new System.Drawing.Point(160, 123);
            this.AICategory.Name = "AICategory";
            this.AICategory.Size = new System.Drawing.Size(299, 27);
            this.AICategory.TabIndex = 7;
            // 
            // AIType
            // 
            this.AIType.Location = new System.Drawing.Point(160, 86);
            this.AIType.Name = "AIType";
            this.AIType.Size = new System.Drawing.Size(299, 27);
            this.AIType.TabIndex = 6;
            // 
            // AIId
            // 
            this.AIId.Location = new System.Drawing.Point(160, 49);
            this.AIId.Name = "AIId";
            this.AIId.Size = new System.Drawing.Size(299, 27);
            this.AIId.TabIndex = 5;
            this.AIId.Click += new System.EventHandler(this.A001);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 19);
            this.label14.TabIndex = 4;
            this.label14.Text = "Unit price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Item type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Item ID";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage3.Controls.Add(this.ItemSearch);
            this.tabPage3.Controls.Add(this.IUpdate);
            this.tabPage3.Controls.Add(this.EIUnit);
            this.tabPage3.Controls.Add(this.EIDescription);
            this.tabPage3.Controls.Add(this.EICategory);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.EIType);
            this.tabPage3.Controls.Add(this.EIId);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1082, 459);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Edit Item";
            // 
            // ItemSearch
            // 
            this.ItemSearch.BackColor = System.Drawing.Color.Aquamarine;
            this.ItemSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemSearch.Location = new System.Drawing.Point(656, 142);
            this.ItemSearch.Name = "ItemSearch";
            this.ItemSearch.Size = new System.Drawing.Size(180, 71);
            this.ItemSearch.TabIndex = 11;
            this.ItemSearch.Text = "SEARCH";
            this.ItemSearch.UseVisualStyleBackColor = false;
            this.ItemSearch.Click += new System.EventHandler(this.ItemSearch_Click);
            // 
            // IUpdate
            // 
            this.IUpdate.BackColor = System.Drawing.Color.Aquamarine;
            this.IUpdate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IUpdate.Location = new System.Drawing.Point(656, 59);
            this.IUpdate.Name = "IUpdate";
            this.IUpdate.Size = new System.Drawing.Size(180, 63);
            this.IUpdate.TabIndex = 10;
            this.IUpdate.Text = "UPDATE";
            this.IUpdate.UseVisualStyleBackColor = false;
            this.IUpdate.Click += new System.EventHandler(this.IUpdate_Click);
            // 
            // EIUnit
            // 
            this.EIUnit.Location = new System.Drawing.Point(172, 211);
            this.EIUnit.Name = "EIUnit";
            this.EIUnit.Size = new System.Drawing.Size(269, 27);
            this.EIUnit.TabIndex = 9;
            // 
            // EIDescription
            // 
            this.EIDescription.Location = new System.Drawing.Point(172, 177);
            this.EIDescription.Name = "EIDescription";
            this.EIDescription.Size = new System.Drawing.Size(269, 27);
            this.EIDescription.TabIndex = 8;
            this.EIDescription.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // EICategory
            // 
            this.EICategory.Location = new System.Drawing.Point(172, 142);
            this.EICategory.Name = "EICategory";
            this.EICategory.Size = new System.Drawing.Size(269, 27);
            this.EICategory.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(55, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "Unit price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(55, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Category";
            // 
            // EIType
            // 
            this.EIType.Location = new System.Drawing.Point(172, 100);
            this.EIType.Name = "EIType";
            this.EIType.Size = new System.Drawing.Size(269, 27);
            this.EIType.TabIndex = 3;
            this.EIType.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // EIId
            // 
            this.EIId.Location = new System.Drawing.Point(172, 61);
            this.EIId.Name = "EIId";
            this.EIId.Size = new System.Drawing.Size(269, 27);
            this.EIId.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Item Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Item ID";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage4.Controls.Add(this.IDelete);
            this.tabPage4.Controls.Add(this.DItemSearch);
            this.tabPage4.Controls.Add(this.DIType);
            this.tabPage4.Controls.Add(this.DIId);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1082, 459);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Delete Item";
            // 
            // IDelete
            // 
            this.IDelete.BackColor = System.Drawing.Color.Aquamarine;
            this.IDelete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDelete.Location = new System.Drawing.Point(727, 170);
            this.IDelete.Name = "IDelete";
            this.IDelete.Size = new System.Drawing.Size(150, 69);
            this.IDelete.TabIndex = 5;
            this.IDelete.Text = "DELETE";
            this.IDelete.UseVisualStyleBackColor = false;
            this.IDelete.Click += new System.EventHandler(this.IDelete_Click);
            // 
            // DItemSearch
            // 
            this.DItemSearch.BackColor = System.Drawing.Color.Aquamarine;
            this.DItemSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DItemSearch.Location = new System.Drawing.Point(727, 66);
            this.DItemSearch.Name = "DItemSearch";
            this.DItemSearch.Size = new System.Drawing.Size(150, 67);
            this.DItemSearch.TabIndex = 4;
            this.DItemSearch.Text = "SEARCH";
            this.DItemSearch.UseVisualStyleBackColor = false;
            this.DItemSearch.Click += new System.EventHandler(this.DItemSearch_Click);
            // 
            // DIType
            // 
            this.DIType.Location = new System.Drawing.Point(192, 111);
            this.DIType.Name = "DIType";
            this.DIType.Size = new System.Drawing.Size(276, 27);
            this.DIType.TabIndex = 3;
            // 
            // DIId
            // 
            this.DIId.Location = new System.Drawing.Point(192, 68);
            this.DIId.Name = "DIId";
            this.DIId.Size = new System.Drawing.Size(276, 27);
            this.DIId.TabIndex = 2;
            this.DIId.TextChanged += new System.EventHandler(this.DIId_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(57, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "Item type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(57, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Item ID";
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "Item Id";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "Item Id";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            // 
            // itemTypeDataGridViewTextBoxColumn
            // 
            this.itemTypeDataGridViewTextBoxColumn.DataPropertyName = "Item Type";
            this.itemTypeDataGridViewTextBoxColumn.HeaderText = "Item Type";
            this.itemTypeDataGridViewTextBoxColumn.Name = "itemTypeDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "Unit price";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Unit price";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.itemsDbDataSet;
            // 
            // itemsDbDataSet
            // 
            this.itemsDbDataSet.DataSetName = "ItemsDbDataSet";
            this.itemsDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 677);
            this.ControlBox = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IType;
        private System.Windows.Forms.Button IClear;
        private System.Windows.Forms.Button Isearch;
        private System.Windows.Forms.TextBox EIType;
        private System.Windows.Forms.TextBox EIId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EIUnit;
        private System.Windows.Forms.TextBox EIDescription;
        private System.Windows.Forms.TextBox EICategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button IAdd;
        private System.Windows.Forms.TextBox AIUnit;
        private System.Windows.Forms.TextBox AIDescription;
        private System.Windows.Forms.TextBox AICategory;
        private System.Windows.Forms.TextBox AIType;
        private System.Windows.Forms.TextBox AIId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ItemSearch;
        private System.Windows.Forms.Button IUpdate;
        private System.Windows.Forms.Button IDelete;
        private System.Windows.Forms.Button DItemSearch;
        private System.Windows.Forms.TextBox DIType;
        private System.Windows.Forms.TextBox DIId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox IId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ItemsDbDataSet itemsDbDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private ItemsDbDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
    }
}