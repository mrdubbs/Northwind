namespace Northwind
{
    partial class Form2
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
            this.closeLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.salesBox = new System.Windows.Forms.ComboBox();
            this.dateTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.customerBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.countryLbl = new System.Windows.Forms.TextBox();
            this.zipLbl = new System.Windows.Forms.TextBox();
            this.stateLbl = new System.Windows.Forms.TextBox();
            this.cityLbl = new System.Windows.Forms.TextBox();
            this.addressLbl = new System.Windows.Forms.TextBox();
            this.shipNameLbl = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.shipBox = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.orderLbl = new System.Windows.Forms.Label();
            this.createLbl = new System.Windows.Forms.Label();
            this.shipLbl = new System.Windows.Forms.Label();
            this.completeLbl = new System.Windows.Forms.Label();
            this.deleteLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.paymentBox = new System.Windows.Forms.ComboBox();
            this.notesBox = new System.Windows.Forms.RichTextBox();
            this.paymentDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeLbl
            // 
            this.closeLbl.AutoSize = true;
            this.closeLbl.BackColor = System.Drawing.Color.Transparent;
            this.closeLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.closeLbl.Location = new System.Drawing.Point(683, 52);
            this.closeLbl.Name = "closeLbl";
            this.closeLbl.Size = new System.Drawing.Size(33, 13);
            this.closeLbl.TabIndex = 1;
            this.closeLbl.Text = "&Close";
            this.closeLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.salesBox);
            this.groupBox1.Controls.Add(this.dateTxt);
            this.groupBox1.Controls.Add(this.emailTxt);
            this.groupBox1.Controls.Add(this.customerBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // salesBox
            // 
            this.salesBox.Enabled = false;
            this.salesBox.Location = new System.Drawing.Point(516, 10);
            this.salesBox.Name = "salesBox";
            this.salesBox.Size = new System.Drawing.Size(188, 21);
            this.salesBox.TabIndex = 7;
            // 
            // dateTxt
            // 
            this.dateTxt.Location = new System.Drawing.Point(516, 44);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.ReadOnly = true;
            this.dateTxt.Size = new System.Drawing.Size(188, 20);
            this.dateTxt.TabIndex = 6;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(177, 44);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(188, 20);
            this.emailTxt.TabIndex = 5;
            this.emailTxt.TextChanged += new System.EventHandler(this.emailTxt_TextChanged);
            // 
            // customerBox
            // 
            this.customerBox.FormattingEnabled = true;
            this.customerBox.Location = new System.Drawing.Point(177, 10);
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(188, 21);
            this.customerBox.TabIndex = 4;
            this.customerBox.SelectedIndexChanged += new System.EventHandler(this.customerBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(384, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Order Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(22, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "E-mail Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(384, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Salesperson";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(22, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 157);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 293);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvOrder);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(711, 267);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Order Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.quantity,
            this.unitPrice,
            this.discount,
            this.totPrice,
            this.status});
            this.dgvOrder.Location = new System.Drawing.Point(6, 3);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(699, 261);
            this.dgvOrder.TabIndex = 4;
            this.dgvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellContentClick);
            this.dgvOrder.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellValueChanged);
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.Width = 200;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Qty";
            this.quantity.Name = "quantity";
            this.quantity.Width = 65;
            // 
            // unitPrice
            // 
            this.unitPrice.HeaderText = "Unit Price";
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.ReadOnly = true;
            // 
            // discount
            // 
            this.discount.HeaderText = "Discount";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            // 
            // totPrice
            // 
            this.totPrice.HeaderText = "TotalPrice";
            this.totPrice.Name = "totPrice";
            this.totPrice.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(711, 267);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Shipping Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.countryLbl);
            this.groupBox3.Controls.Add(this.zipLbl);
            this.groupBox3.Controls.Add(this.stateLbl);
            this.groupBox3.Controls.Add(this.cityLbl);
            this.groupBox3.Controls.Add(this.addressLbl);
            this.groupBox3.Controls.Add(this.shipNameLbl);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(6, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(694, 186);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // countryLbl
            // 
            this.countryLbl.Location = new System.Drawing.Point(113, 146);
            this.countryLbl.Name = "countryLbl";
            this.countryLbl.Size = new System.Drawing.Size(575, 20);
            this.countryLbl.TabIndex = 15;
            // 
            // zipLbl
            // 
            this.zipLbl.Location = new System.Drawing.Point(113, 122);
            this.zipLbl.Name = "zipLbl";
            this.zipLbl.Size = new System.Drawing.Size(575, 20);
            this.zipLbl.TabIndex = 14;
            // 
            // stateLbl
            // 
            this.stateLbl.Location = new System.Drawing.Point(113, 95);
            this.stateLbl.Name = "stateLbl";
            this.stateLbl.Size = new System.Drawing.Size(575, 20);
            this.stateLbl.TabIndex = 13;
            // 
            // cityLbl
            // 
            this.cityLbl.Location = new System.Drawing.Point(113, 70);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(575, 20);
            this.cityLbl.TabIndex = 12;
            // 
            // addressLbl
            // 
            this.addressLbl.Location = new System.Drawing.Point(113, 36);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(575, 20);
            this.addressLbl.TabIndex = 11;
            // 
            // shipNameLbl
            // 
            this.shipNameLbl.Location = new System.Drawing.Point(113, 13);
            this.shipNameLbl.Name = "shipNameLbl";
            this.shipNameLbl.Size = new System.Drawing.Size(575, 20);
            this.shipNameLbl.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(12, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Ship Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(12, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(12, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "State/Province";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(12, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Zip/Postal Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(12, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Country/Region";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(12, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ship Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.shipBox);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.b);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(694, 45);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(377, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // shipBox
            // 
            this.shipBox.FormattingEnabled = true;
            this.shipBox.Location = new System.Drawing.Point(113, 13);
            this.shipBox.Name = "shipBox";
            this.shipBox.Size = new System.Drawing.Size(201, 21);
            this.shipBox.TabIndex = 0;
            this.shipBox.SelectedIndexChanged += new System.EventHandler(this.shipBox_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(588, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "$0.00";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.b.Location = new System.Drawing.Point(503, 16);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(69, 13);
            this.b.TabIndex = 2;
            this.b.Text = "Shipping Fee";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label.Location = new System.Drawing.Point(320, 16);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(54, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Ship Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shipping Company";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.paymentDate);
            this.tabPage3.Controls.Add(this.notesBox);
            this.tabPage3.Controls.Add(this.paymentBox);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(711, 267);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Payment Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Northwind.Properties.Resources.Order1;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(762, 76);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // orderLbl
            // 
            this.orderLbl.AutoSize = true;
            this.orderLbl.BackColor = System.Drawing.Color.Transparent;
            this.orderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLbl.ForeColor = System.Drawing.Color.White;
            this.orderLbl.Location = new System.Drawing.Point(83, 9);
            this.orderLbl.Name = "orderLbl";
            this.orderLbl.Size = new System.Drawing.Size(167, 29);
            this.orderLbl.TabIndex = 4;
            this.orderLbl.Text = "Order # (New)";
            this.orderLbl.Click += new System.EventHandler(this.label12_Click);
            // 
            // createLbl
            // 
            this.createLbl.AutoSize = true;
            this.createLbl.BackColor = System.Drawing.Color.Transparent;
            this.createLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.createLbl.Location = new System.Drawing.Point(207, 52);
            this.createLbl.Name = "createLbl";
            this.createLbl.Size = new System.Drawing.Size(76, 13);
            this.createLbl.TabIndex = 5;
            this.createLbl.Text = "Create Invoice";
            // 
            // shipLbl
            // 
            this.shipLbl.AutoSize = true;
            this.shipLbl.BackColor = System.Drawing.Color.Transparent;
            this.shipLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shipLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.shipLbl.Location = new System.Drawing.Point(306, 52);
            this.shipLbl.Name = "shipLbl";
            this.shipLbl.Size = new System.Drawing.Size(57, 13);
            this.shipLbl.TabIndex = 6;
            this.shipLbl.Text = "Ship Order";
            this.shipLbl.Click += new System.EventHandler(this.label13_Click);
            // 
            // completeLbl
            // 
            this.completeLbl.AutoSize = true;
            this.completeLbl.BackColor = System.Drawing.Color.Transparent;
            this.completeLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.completeLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.completeLbl.Location = new System.Drawing.Point(392, 52);
            this.completeLbl.Name = "completeLbl";
            this.completeLbl.Size = new System.Drawing.Size(80, 13);
            this.completeLbl.TabIndex = 7;
            this.completeLbl.Text = "Complete Order";
            // 
            // deleteLbl
            // 
            this.deleteLbl.AutoSize = true;
            this.deleteLbl.BackColor = System.Drawing.Color.Transparent;
            this.deleteLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.deleteLbl.Location = new System.Drawing.Point(500, 52);
            this.deleteLbl.Name = "deleteLbl";
            this.deleteLbl.Size = new System.Drawing.Size(67, 13);
            this.deleteLbl.TabIndex = 8;
            this.deleteLbl.Text = "Delete Order";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(33, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "Payment Type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(33, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "Payment Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(33, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 15);
            this.label14.TabIndex = 10;
            this.label14.Text = "Payment/Order Notes";
            // 
            // paymentBox
            // 
            this.paymentBox.FormattingEnabled = true;
            this.paymentBox.Location = new System.Drawing.Point(173, 23);
            this.paymentBox.Name = "paymentBox";
            this.paymentBox.Size = new System.Drawing.Size(121, 21);
            this.paymentBox.TabIndex = 11;
            // 
            // notesBox
            // 
            this.notesBox.Location = new System.Drawing.Point(173, 83);
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(484, 58);
            this.notesBox.TabIndex = 13;
            this.notesBox.Text = "";
            // 
            // paymentDate
            // 
            this.paymentDate.Location = new System.Drawing.Point(173, 54);
            this.paymentDate.Name = "paymentDate";
            this.paymentDate.Size = new System.Drawing.Size(200, 20);
            this.paymentDate.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 462);
            this.Controls.Add(this.deleteLbl);
            this.Controls.Add(this.completeLbl);
            this.Controls.Add(this.shipLbl);
            this.Controls.Add(this.createLbl);
            this.Controls.Add(this.orderLbl);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closeLbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Order Details";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label closeLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox customerBox;
        private System.Windows.Forms.ComboBox salesBox;
        private System.Windows.Forms.TextBox dateTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox shipBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox countryLbl;
        private System.Windows.Forms.TextBox zipLbl;
        private System.Windows.Forms.TextBox stateLbl;
        private System.Windows.Forms.TextBox cityLbl;
        private System.Windows.Forms.TextBox addressLbl;
        private System.Windows.Forms.TextBox shipNameLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label orderLbl;
        private System.Windows.Forms.Label createLbl;
        private System.Windows.Forms.Label shipLbl;
        private System.Windows.Forms.Label completeLbl;
        private System.Windows.Forms.Label deleteLbl;
        private System.Windows.Forms.DataGridViewComboBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DateTimePicker paymentDate;
        private System.Windows.Forms.RichTextBox notesBox;
        private System.Windows.Forms.ComboBox paymentBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}