namespace Northwind
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvActiveOrder = new System.Windows.Forms.DataGridView();
            this.dgvInventoryToRecorder = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ReorderLvl = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.supplierBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.shipperBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.employeeButton = new System.Windows.Forms.Button();
            this.empBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.productBox = new System.Windows.Forms.ComboBox();
            this.tempDGV = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.newPOrder = new System.Windows.Forms.Label();
            this.newCOrder = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLogin = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.tabPurchaseOrders = new System.Windows.Forms.TabPage();
            this.dgvPurchaseOrders = new System.Windows.Forms.DataGridView();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.tabShippers = new System.Windows.Forms.TabPage();
            this.dgvShippers = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.customerBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryToRecorder)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.tabOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.tabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabPurchaseOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrders)).BeginInit();
            this.tabSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.tabEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.tabShippers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShippers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActiveOrder
            // 
            this.dgvActiveOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveOrder.Location = new System.Drawing.Point(46, 105);
            this.dgvActiveOrder.Name = "dgvActiveOrder";
            this.dgvActiveOrder.ReadOnly = true;
            this.dgvActiveOrder.Size = new System.Drawing.Size(335, 181);
            this.dgvActiveOrder.TabIndex = 1;
            // 
            // dgvInventoryToRecorder
            // 
            this.dgvInventoryToRecorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryToRecorder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Quantity,
            this.ReorderLvl});
            this.dgvInventoryToRecorder.Location = new System.Drawing.Point(406, 105);
            this.dgvInventoryToRecorder.Name = "dgvInventoryToRecorder";
            this.dgvInventoryToRecorder.ReadOnly = true;
            this.dgvInventoryToRecorder.RowHeadersWidth = 51;
            this.dgvInventoryToRecorder.Size = new System.Drawing.Size(659, 181);
            this.dgvInventoryToRecorder.TabIndex = 2;
            this.dgvInventoryToRecorder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dgvInventoryToRecorder.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvInventoryToRecorder_CellFormatting);
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Qty Availible";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ReorderLvl
            // 
            this.ReorderLvl.HeaderText = "Reorder Level";
            this.ReorderLvl.Name = "ReorderLvl";
            this.ReorderLvl.ReadOnly = true;
            this.ReorderLvl.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReorderLvl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.linkLabel8);
            this.groupBox1.Controls.Add(this.linkLabel7);
            this.groupBox1.Controls.Add(this.linkLabel6);
            this.groupBox1.Controls.Add(this.linkLabel5);
            this.groupBox1.Controls.Add(this.linkLabel4);
            this.groupBox1.Controls.Add(this.linkLabel3);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(1087, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 238);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quick Links";
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel8.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel8.Location = new System.Drawing.Point(6, 209);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(73, 13);
            this.linkLabel8.TabIndex = 3;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Sales Reports";
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel7.Location = new System.Drawing.Point(6, 153);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(74, 13);
            this.linkLabel7.TabIndex = 6;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "View Shippers";
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel6.Location = new System.Drawing.Point(6, 182);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(84, 13);
            this.linkLabel6.TabIndex = 5;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "View Employees";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel5.Location = new System.Drawing.Point(6, 126);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(76, 13);
            this.linkLabel5.TabIndex = 4;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "View Suppliers";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel4.Location = new System.Drawing.Point(6, 100);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(112, 13);
            this.linkLabel4.TabIndex = 3;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "View Purchase Orders";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel3.Location = new System.Drawing.Point(6, 71);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(82, 13);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "View Customers";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel2.Location = new System.Drawing.Point(6, 42);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(64, 13);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "View Orders";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(6, 16);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View Inventory";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHome);
            this.tabControl.Controls.Add(this.tabInventory);
            this.tabControl.Controls.Add(this.tabOrder);
            this.tabControl.Controls.Add(this.tabCustomer);
            this.tabControl.Controls.Add(this.tabPurchaseOrders);
            this.tabControl.Controls.Add(this.tabSuppliers);
            this.tabControl.Controls.Add(this.tabEmployees);
            this.tabControl.Controls.Add(this.tabShippers);
            this.tabControl.Location = new System.Drawing.Point(0, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1310, 552);
            this.tabControl.TabIndex = 1;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            this.tabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseDown);
            this.tabControl.MouseEnter += new System.EventHandler(this.tabControl_MouseEnter);
            this.tabControl.MouseHover += new System.EventHandler(this.tabControl_MouseHover);
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.button1);
            this.tabHome.Controls.Add(this.label2);
            this.tabHome.Controls.Add(this.customerBox);
            this.tabHome.Controls.Add(this.label8);
            this.tabHome.Controls.Add(this.button5);
            this.tabHome.Controls.Add(this.button4);
            this.tabHome.Controls.Add(this.supplierBox);
            this.tabHome.Controls.Add(this.label10);
            this.tabHome.Controls.Add(this.shipperBox);
            this.tabHome.Controls.Add(this.label9);
            this.tabHome.Controls.Add(this.employeeButton);
            this.tabHome.Controls.Add(this.empBox);
            this.tabHome.Controls.Add(this.button3);
            this.tabHome.Controls.Add(this.label7);
            this.tabHome.Controls.Add(this.productBox);
            this.tabHome.Controls.Add(this.tempDGV);
            this.tabHome.Controls.Add(this.pictureBox2);
            this.tabHome.Controls.Add(this.newPOrder);
            this.tabHome.Controls.Add(this.newCOrder);
            this.tabHome.Controls.Add(this.label3);
            this.tabHome.Controls.Add(this.label1);
            this.tabHome.Controls.Add(this.cbLogin);
            this.tabHome.Controls.Add(this.groupBox1);
            this.tabHome.Controls.Add(this.dgvActiveOrder);
            this.tabHome.Controls.Add(this.dgvInventoryToRecorder);
            this.tabHome.Controls.Add(this.pictureBox1);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1302, 526);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(43, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Choose Employee";
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(619, 340);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Create New Shipper";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(619, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Create New Supplier";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // supplierBox
            // 
            this.supplierBox.FormattingEnabled = true;
            this.supplierBox.Location = new System.Drawing.Point(406, 317);
            this.supplierBox.Name = "supplierBox";
            this.supplierBox.Size = new System.Drawing.Size(335, 21);
            this.supplierBox.TabIndex = 23;
            this.supplierBox.SelectedIndexChanged += new System.EventHandler(this.supplierBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(403, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Choose Supplier";
            // 
            // shipperBox
            // 
            this.shipperBox.FormattingEnabled = true;
            this.shipperBox.Location = new System.Drawing.Point(406, 369);
            this.shipperBox.Name = "shipperBox";
            this.shipperBox.Size = new System.Drawing.Size(335, 21);
            this.shipperBox.TabIndex = 21;
            this.shipperBox.SelectedIndexChanged += new System.EventHandler(this.shipperBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(403, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Choose Shipper";
            // 
            // employeeButton
            // 
            this.employeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.employeeButton.Location = new System.Drawing.Point(259, 343);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(122, 23);
            this.employeeButton.TabIndex = 19;
            this.employeeButton.Text = "Create New Employee";
            this.employeeButton.UseVisualStyleBackColor = true;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // empBox
            // 
            this.empBox.FormattingEnabled = true;
            this.empBox.Location = new System.Drawing.Point(46, 369);
            this.empBox.Name = "empBox";
            this.empBox.Size = new System.Drawing.Size(335, 21);
            this.empBox.TabIndex = 18;
            this.empBox.SelectedIndexChanged += new System.EventHandler(this.empBox_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(259, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Create New Product";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(43, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Choose Product";
            // 
            // productBox
            // 
            this.productBox.FormattingEnabled = true;
            this.productBox.Location = new System.Drawing.Point(46, 317);
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(335, 21);
            this.productBox.TabIndex = 3;
            this.productBox.SelectedIndexChanged += new System.EventHandler(this.productBox_SelectedIndexChanged);
            // 
            // tempDGV
            // 
            this.tempDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tempDGV.Location = new System.Drawing.Point(1051, 408);
            this.tempDGV.Name = "tempDGV";
            this.tempDGV.Size = new System.Drawing.Size(240, 150);
            this.tempDGV.TabIndex = 14;
            this.tempDGV.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Northwind.Properties.Resources.Refresh;
            this.pictureBox2.Location = new System.Drawing.Point(581, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(12, 14);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // newPOrder
            // 
            this.newPOrder.AutoSize = true;
            this.newPOrder.BackColor = System.Drawing.Color.Transparent;
            this.newPOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newPOrder.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.newPOrder.Location = new System.Drawing.Point(448, 50);
            this.newPOrder.Name = "newPOrder";
            this.newPOrder.Size = new System.Drawing.Size(106, 13);
            this.newPOrder.TabIndex = 12;
            this.newPOrder.Text = "New Purchase Order";
            this.newPOrder.Click += new System.EventHandler(this.newPOrder_Click);
            this.newPOrder.MouseHover += new System.EventHandler(this.newPOrder_MouseHover);
            // 
            // newCOrder
            // 
            this.newCOrder.AutoSize = true;
            this.newCOrder.BackColor = System.Drawing.Color.Transparent;
            this.newCOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newCOrder.ForeColor = System.Drawing.SystemColors.Window;
            this.newCOrder.Location = new System.Drawing.Point(325, 50);
            this.newCOrder.Name = "newCOrder";
            this.newCOrder.Size = new System.Drawing.Size(105, 13);
            this.newCOrder.TabIndex = 11;
            this.newCOrder.Text = "New Customer Order";
            this.newCOrder.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(403, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inventory to Reorder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(43, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Active Orders";
            // 
            // cbLogin
            // 
            this.cbLogin.FormattingEnabled = true;
            this.cbLogin.ItemHeight = 13;
            this.cbLogin.Location = new System.Drawing.Point(144, 47);
            this.cbLogin.Name = "cbLogin";
            this.cbLogin.Size = new System.Drawing.Size(154, 21);
            this.cbLogin.TabIndex = 5;
            this.cbLogin.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1308, 73);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.dgvInventory);
            this.tabInventory.Location = new System.Drawing.Point(4, 22);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(1302, 526);
            this.tabInventory.TabIndex = 1;
            this.tabInventory.Text = "Inventory List";
            this.tabInventory.UseVisualStyleBackColor = true;
            this.tabInventory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabInventory_MouseClick);
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(6, 6);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.Size = new System.Drawing.Size(1259, 511);
            this.dgvInventory.TabIndex = 0;
            this.dgvInventory.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellValueChanged);
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.dgvOrders);
            this.tabOrder.Location = new System.Drawing.Point(4, 22);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Size = new System.Drawing.Size(1302, 526);
            this.tabOrder.TabIndex = 2;
            this.tabOrder.Text = "Order";
            this.tabOrder.UseVisualStyleBackColor = true;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(20, 20);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(1243, 497);
            this.dgvOrders.TabIndex = 0;
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.dgvCustomers);
            this.tabCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(1302, 526);
            this.tabCustomer.TabIndex = 3;
            this.tabCustomer.Text = "Customers";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(21, 15);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(1243, 497);
            this.dgvCustomers.TabIndex = 1;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellContentClick);
            // 
            // tabPurchaseOrders
            // 
            this.tabPurchaseOrders.Controls.Add(this.dgvPurchaseOrders);
            this.tabPurchaseOrders.Location = new System.Drawing.Point(4, 22);
            this.tabPurchaseOrders.Name = "tabPurchaseOrders";
            this.tabPurchaseOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPurchaseOrders.Size = new System.Drawing.Size(1302, 526);
            this.tabPurchaseOrders.TabIndex = 4;
            this.tabPurchaseOrders.Text = "Purchase Orders";
            this.tabPurchaseOrders.UseVisualStyleBackColor = true;
            // 
            // dgvPurchaseOrders
            // 
            this.dgvPurchaseOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseOrders.Location = new System.Drawing.Point(21, 15);
            this.dgvPurchaseOrders.Name = "dgvPurchaseOrders";
            this.dgvPurchaseOrders.Size = new System.Drawing.Size(1243, 497);
            this.dgvPurchaseOrders.TabIndex = 1;
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.Controls.Add(this.dgvSuppliers);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tabSuppliers.Size = new System.Drawing.Size(1302, 526);
            this.tabSuppliers.TabIndex = 5;
            this.tabSuppliers.Text = "Suppliers";
            this.tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Location = new System.Drawing.Point(21, 15);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.Size = new System.Drawing.Size(1243, 497);
            this.dgvSuppliers.TabIndex = 1;
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.dgvEmployees);
            this.tabEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployees.Size = new System.Drawing.Size(1302, 526);
            this.tabEmployees.TabIndex = 6;
            this.tabEmployees.Text = "Employees";
            this.tabEmployees.UseVisualStyleBackColor = true;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(21, 15);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(1243, 497);
            this.dgvEmployees.TabIndex = 1;
            this.dgvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellContentClick);
            // 
            // tabShippers
            // 
            this.tabShippers.Controls.Add(this.dgvShippers);
            this.tabShippers.Location = new System.Drawing.Point(4, 22);
            this.tabShippers.Name = "tabShippers";
            this.tabShippers.Padding = new System.Windows.Forms.Padding(3);
            this.tabShippers.Size = new System.Drawing.Size(1302, 526);
            this.tabShippers.TabIndex = 7;
            this.tabShippers.Text = "Shippers";
            this.tabShippers.UseVisualStyleBackColor = true;
            // 
            // dgvShippers
            // 
            this.dgvShippers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShippers.Location = new System.Drawing.Point(21, 15);
            this.dgvShippers.Name = "dgvShippers";
            this.dgvShippers.Size = new System.Drawing.Size(1036, 348);
            this.dgvShippers.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Engravers MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1285, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 20);
            this.button2.TabIndex = 2;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // customerBox
            // 
            this.customerBox.FormattingEnabled = true;
            this.customerBox.Location = new System.Drawing.Point(46, 418);
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(335, 21);
            this.customerBox.TabIndex = 27;
            this.customerBox.SelectedIndexChanged += new System.EventHandler(this.customerBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(43, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Choose Customer";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(259, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Create New Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 563);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Southwest Airways";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryToRecorder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.tabOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.tabCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tabPurchaseOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrders)).EndInit();
            this.tabSuppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.tabEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.tabShippers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShippers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActiveOrder;
        private System.Windows.Forms.DataGridView dgvInventoryToRecorder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabInventory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TabPage tabPurchaseOrders;
        private System.Windows.Forms.TabPage tabSuppliers;
        private System.Windows.Forms.TabPage tabEmployees;
        private System.Windows.Forms.TabPage tabShippers;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.DataGridView dgvPurchaseOrders;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridView dgvShippers;
        private System.Windows.Forms.ComboBox cbLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label newPOrder;
        private System.Windows.Forms.Label newCOrder;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.DataGridView tempDGV;
        private System.Windows.Forms.DataGridViewLinkColumn Product;
        private System.Windows.Forms.DataGridViewLinkColumn Quantity;
        private System.Windows.Forms.DataGridViewLinkColumn ReorderLvl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox productBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox supplierBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox shipperBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.ComboBox empBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox customerBox;

    }
}

