namespace Motor_Yard
{
    partial class Main_Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_StockControl = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStock_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStock_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStock_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearStock_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockStatusTool_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.sales_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalIncome_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxesPayable_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Catalog = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Customers = new System.Windows.Forms.ToolStripMenuItem();
            this.ratings_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discountOffered_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requests_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.Done_button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete_button = new System.Windows.Forms.Button();
            this.total_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button6_AddItem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantity_box = new System.Windows.Forms.ComboBox();
            this.comboBox7_part = new System.Windows.Forms.ComboBox();
            this.comboBox_BrandName = new System.Windows.Forms.ComboBox();
            this.comboBox6_category = new System.Windows.Forms.ComboBox();
            this.comboBox5_year = new System.Windows.Forms.ComboBox();
            this.comboBox2_model = new System.Windows.Forms.ComboBox();
            this.comboBox4_engine = new System.Windows.Forms.ComboBox();
            this.comboBox3_fuel = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_StockControl,
            this.ToolStripMenuItem_Report,
            this.ToolStripMenuItem_Catalog,
            this.ToolStripMenuItem_Customers,
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(995, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_StockControl
            // 
            this.ToolStripMenuItem_StockControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStock_ToolStripMenuItem,
            this.updateStock_ToolStripMenuItem,
            this.deleteStock_ToolStripMenuItem,
            this.clearStock_ToolStripMenuItem,
            this.stockStatusTool_StripMenuItem});
            this.ToolStripMenuItem_StockControl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem_StockControl.Name = "ToolStripMenuItem_StockControl";
            this.ToolStripMenuItem_StockControl.Size = new System.Drawing.Size(96, 19);
            this.ToolStripMenuItem_StockControl.Text = "Stock_Control";
            // 
            // addNewStock_ToolStripMenuItem
            // 
            this.addNewStock_ToolStripMenuItem.Name = "addNewStock_ToolStripMenuItem";
            this.addNewStock_ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.addNewStock_ToolStripMenuItem.Text = "Add New Item";
            this.addNewStock_ToolStripMenuItem.Click += new System.EventHandler(this.addNewStock_ToolStripMenuItem_Click);
            // 
            // updateStock_ToolStripMenuItem
            // 
            this.updateStock_ToolStripMenuItem.Name = "updateStock_ToolStripMenuItem";
            this.updateStock_ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.updateStock_ToolStripMenuItem.Text = "Update Item";
            this.updateStock_ToolStripMenuItem.Click += new System.EventHandler(this.updateStock_ToolStripMenuItem_Click);
            // 
            // deleteStock_ToolStripMenuItem
            // 
            this.deleteStock_ToolStripMenuItem.Name = "deleteStock_ToolStripMenuItem";
            this.deleteStock_ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.deleteStock_ToolStripMenuItem.Text = "Delete Item";
            this.deleteStock_ToolStripMenuItem.Click += new System.EventHandler(this.deleteStock_ToolStripMenuItem_Click);
            // 
            // clearStock_ToolStripMenuItem
            // 
            this.clearStock_ToolStripMenuItem.Name = "clearStock_ToolStripMenuItem";
            this.clearStock_ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.clearStock_ToolStripMenuItem.Text = "Clear Stock";
            this.clearStock_ToolStripMenuItem.Click += new System.EventHandler(this.clearStock_ToolStripMenuItem_Click);
            // 
            // stockStatusTool_StripMenuItem
            // 
            this.stockStatusTool_StripMenuItem.Name = "stockStatusTool_StripMenuItem";
            this.stockStatusTool_StripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.stockStatusTool_StripMenuItem.Text = "Stock Status";
            this.stockStatusTool_StripMenuItem.Click += new System.EventHandler(this.stockStatusTool_StripMenuItem_Click);
            // 
            // ToolStripMenuItem_Report
            // 
            this.ToolStripMenuItem_Report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sales_ToolStripMenuItem,
            this.totalIncome_ToolStripMenuItem,
            this.taxesPayable_ToolStripMenuItem});
            this.ToolStripMenuItem_Report.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem_Report.Name = "ToolStripMenuItem_Report";
            this.ToolStripMenuItem_Report.Size = new System.Drawing.Size(54, 19);
            this.ToolStripMenuItem_Report.Text = "Report";
            // 
            // sales_ToolStripMenuItem
            // 
            this.sales_ToolStripMenuItem.Name = "sales_ToolStripMenuItem";
            this.sales_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sales_ToolStripMenuItem.Text = "Sales";
            this.sales_ToolStripMenuItem.Click += new System.EventHandler(this.sales_ToolStripMenuItem_Click);
            // 
            // totalIncome_ToolStripMenuItem
            // 
            this.totalIncome_ToolStripMenuItem.Name = "totalIncome_ToolStripMenuItem";
            this.totalIncome_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.totalIncome_ToolStripMenuItem.Text = "Total Income";
            this.totalIncome_ToolStripMenuItem.Click += new System.EventHandler(this.totalIncome_ToolStripMenuItem_Click);
            // 
            // taxesPayable_ToolStripMenuItem
            // 
            this.taxesPayable_ToolStripMenuItem.Name = "taxesPayable_ToolStripMenuItem";
            this.taxesPayable_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.taxesPayable_ToolStripMenuItem.Text = "Taxes Payable";
            this.taxesPayable_ToolStripMenuItem.Click += new System.EventHandler(this.taxesPayable_ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_Catalog
            // 
            this.ToolStripMenuItem_Catalog.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem_Catalog.Name = "ToolStripMenuItem_Catalog";
            this.ToolStripMenuItem_Catalog.Size = new System.Drawing.Size(60, 19);
            this.ToolStripMenuItem_Catalog.Text = "Catalog";
            this.ToolStripMenuItem_Catalog.Click += new System.EventHandler(this.ToolStripMenuItem_Catalog_Click);
            // 
            // ToolStripMenuItem_Customers
            // 
            this.ToolStripMenuItem_Customers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ratings_ToolStripMenuItem,
            this.discountOffered_ToolStripMenuItem,
            this.requests_ToolStripMenuItem});
            this.ToolStripMenuItem_Customers.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem_Customers.Name = "ToolStripMenuItem_Customers";
            this.ToolStripMenuItem_Customers.Size = new System.Drawing.Size(76, 19);
            this.ToolStripMenuItem_Customers.Text = "Customers";
            // 
            // ratings_ToolStripMenuItem
            // 
            this.ratings_ToolStripMenuItem.Name = "ratings_ToolStripMenuItem";
            this.ratings_ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ratings_ToolStripMenuItem.Text = "Ratings";
            this.ratings_ToolStripMenuItem.Click += new System.EventHandler(this.ratings_ToolStripMenuItem_Click);
            // 
            // discountOffered_ToolStripMenuItem
            // 
            this.discountOffered_ToolStripMenuItem.Name = "discountOffered_ToolStripMenuItem";
            this.discountOffered_ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.discountOffered_ToolStripMenuItem.Text = "Discount Offered";
            this.discountOffered_ToolStripMenuItem.Click += new System.EventHandler(this.discountOffered_ToolStripMenuItem_Click);
            // 
            // requests_ToolStripMenuItem
            // 
            this.requests_ToolStripMenuItem.Name = "requests_ToolStripMenuItem";
            this.requests_ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.requests_ToolStripMenuItem.Text = "Requests";
            this.requests_ToolStripMenuItem.Click += new System.EventHandler(this.requests_ToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.logOutToolStripMenuItem1});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.logOutToolStripMenuItem1.Text = "LogOut";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(6, 54);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(700, 197);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Code";
            this.columnHeader1.Width = 196;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Name";
            this.columnHeader2.Width = 282;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit Price";
            this.columnHeader3.Width = 113;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantity";
            this.columnHeader5.Width = 348;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.Done_button);
            this.groupBox1.Controls.Add(this.Clear_button);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Delete_button);
            this.groupBox1.Controls.Add(this.total_box);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 374);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transactions";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(617, 312);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Done_button
            // 
            this.Done_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done_button.Location = new System.Drawing.Point(524, 312);
            this.Done_button.Name = "Done_button";
            this.Done_button.Size = new System.Drawing.Size(75, 23);
            this.Done_button.TabIndex = 11;
            this.Done_button.Text = "Done";
            this.Done_button.UseVisualStyleBackColor = true;
            this.Done_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_button.Location = new System.Drawing.Point(93, 312);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(75, 23);
            this.Clear_button.TabIndex = 10;
            this.Clear_button.Text = "Clear All";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total ";
            // 
            // Delete_button
            // 
            this.Delete_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_button.Location = new System.Drawing.Point(12, 312);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 23);
            this.Delete_button.TabIndex = 9;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // total_box
            // 
            this.total_box.Enabled = false;
            this.total_box.Location = new System.Drawing.Point(585, 267);
            this.total_box.Name = "total_box";
            this.total_box.Size = new System.Drawing.Size(107, 22);
            this.total_box.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(49, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // button6_AddItem
            // 
            this.button6_AddItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6_AddItem.Location = new System.Drawing.Point(52, 302);
            this.button6_AddItem.Name = "button6_AddItem";
            this.button6_AddItem.Size = new System.Drawing.Size(121, 42);
            this.button6_AddItem.TabIndex = 0;
            this.button6_AddItem.Text = "Add Item";
            this.button6_AddItem.UseVisualStyleBackColor = true;
            this.button6_AddItem.Click += new System.EventHandler(this.button6_AddItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.quantity_box);
            this.groupBox2.Controls.Add(this.comboBox7_part);
            this.groupBox2.Controls.Add(this.comboBox_BrandName);
            this.groupBox2.Controls.Add(this.comboBox6_category);
            this.groupBox2.Controls.Add(this.button6_AddItem);
            this.groupBox2.Controls.Add(this.comboBox5_year);
            this.groupBox2.Controls.Add(this.comboBox2_model);
            this.groupBox2.Controls.Add(this.comboBox4_engine);
            this.groupBox2.Controls.Add(this.comboBox3_fuel);
            this.groupBox2.Location = new System.Drawing.Point(747, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 373);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity :";
            // 
            // quantity_box
            // 
            this.quantity_box.FormattingEnabled = true;
            this.quantity_box.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.quantity_box.Location = new System.Drawing.Point(111, 264);
            this.quantity_box.Name = "quantity_box";
            this.quantity_box.Size = new System.Drawing.Size(62, 23);
            this.quantity_box.TabIndex = 8;
            // 
            // comboBox7_part
            // 
            this.comboBox7_part.FormattingEnabled = true;
            this.comboBox7_part.Items.AddRange(new object[] {
            "head light"});
            this.comboBox7_part.Location = new System.Drawing.Point(52, 228);
            this.comboBox7_part.Name = "comboBox7_part";
            this.comboBox7_part.Size = new System.Drawing.Size(121, 23);
            this.comboBox7_part.TabIndex = 7;
            // 
            // comboBox_BrandName
            // 
            this.comboBox_BrandName.FormattingEnabled = true;
            this.comboBox_BrandName.Items.AddRange(new object[] {
            "honda"});
            this.comboBox_BrandName.Location = new System.Drawing.Point(52, 54);
            this.comboBox_BrandName.Name = "comboBox_BrandName";
            this.comboBox_BrandName.Size = new System.Drawing.Size(121, 23);
            this.comboBox_BrandName.TabIndex = 1;
            // 
            // comboBox6_category
            // 
            this.comboBox6_category.FormattingEnabled = true;
            this.comboBox6_category.Items.AddRange(new object[] {
            "electrical & lighting"});
            this.comboBox6_category.Location = new System.Drawing.Point(52, 199);
            this.comboBox6_category.Name = "comboBox6_category";
            this.comboBox6_category.Size = new System.Drawing.Size(121, 23);
            this.comboBox6_category.TabIndex = 6;
            // 
            // comboBox5_year
            // 
            this.comboBox5_year.FormattingEnabled = true;
            this.comboBox5_year.Items.AddRange(new object[] {
            "2012"});
            this.comboBox5_year.Location = new System.Drawing.Point(52, 170);
            this.comboBox5_year.Name = "comboBox5_year";
            this.comboBox5_year.Size = new System.Drawing.Size(121, 23);
            this.comboBox5_year.TabIndex = 5;
            // 
            // comboBox2_model
            // 
            this.comboBox2_model.FormattingEnabled = true;
            this.comboBox2_model.Items.AddRange(new object[] {
            "fit"});
            this.comboBox2_model.Location = new System.Drawing.Point(52, 83);
            this.comboBox2_model.Name = "comboBox2_model";
            this.comboBox2_model.Size = new System.Drawing.Size(121, 23);
            this.comboBox2_model.TabIndex = 2;
            // 
            // comboBox4_engine
            // 
            this.comboBox4_engine.FormattingEnabled = true;
            this.comboBox4_engine.Items.AddRange(new object[] {
            "1.6"});
            this.comboBox4_engine.Location = new System.Drawing.Point(52, 141);
            this.comboBox4_engine.Name = "comboBox4_engine";
            this.comboBox4_engine.Size = new System.Drawing.Size(121, 23);
            this.comboBox4_engine.TabIndex = 4;
            // 
            // comboBox3_fuel
            // 
            this.comboBox3_fuel.FormattingEnabled = true;
            this.comboBox3_fuel.Items.AddRange(new object[] {
            "petrol 95"});
            this.comboBox3_fuel.Location = new System.Drawing.Point(52, 112);
            this.comboBox3_fuel.Name = "comboBox3_fuel";
            this.comboBox3_fuel.Size = new System.Drawing.Size(121, 23);
            this.comboBox3_fuel.TabIndex = 3;
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(995, 422);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Control System - Main Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_StockControl;
        private System.Windows.Forms.ToolStripMenuItem addNewStock_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStock_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStock_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearStock_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockStatusTool_StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Report;
        private System.Windows.Forms.ToolStripMenuItem sales_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalIncome_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxesPayable_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Catalog;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Customers;
        private System.Windows.Forms.ToolStripMenuItem ratings_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discountOffered_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requests_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Done_button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.TextBox total_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button6_AddItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox7_part;
        private System.Windows.Forms.ComboBox comboBox_BrandName;
        private System.Windows.Forms.ComboBox comboBox6_category;
        private System.Windows.Forms.ComboBox comboBox5_year;
        private System.Windows.Forms.ComboBox comboBox2_model;
        private System.Windows.Forms.ComboBox comboBox4_engine;
        private System.Windows.Forms.ComboBox comboBox3_fuel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox quantity_box;
    }
}