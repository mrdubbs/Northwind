using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Northwind
{
    public partial class Form1 : Form
    {
        private string myConnection;
        MySqlConnection myConn;
        MySqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        BindingSource bSource;
        MySqlCommandBuilder cb;
        string employee;
        int combVal;
        int orderNum = 0;
        public Form1()
        {

            InitializeComponent();
            newCOrder.Parent = pictureBox1;
            newPOrder.Parent = pictureBox1;
            try
            {
                bSource = new BindingSource();

                myConnection = "datasource=localhost;port=3306;username=root;password=root;Convert Zero Datetime=True";
                myConn = new MySqlConnection(myConnection);
                da = new MySqlDataAdapter();

                ds = new DataSet();
                dt = new DataTable();
                //Inventory
                fillInventory();

                //Order
                fillOrder();

                //Customer
                fillCustomer();

                //Purchase Order
                fillPurchaseOrder();

                //Supplier
                fillSupplier();

                //Shipper
                fillShipper();

                //ActiveOrder
                fillActiveOrder();

                //Inventory To Recorder
                fillInvToRec();

                //Products
                fillProducts();

                //Employee
                fillEmployee();
                //Login

                fillProductBox();

                fillEmployeeBox();

                fillShipperBox();

                fillSupplierBox();

                fillCustomerBox();
                
                foreach (DataRow dtRow in dt.Rows)
                {
                    cbLogin.Items.Add(dtRow[1] + " " + dtRow[3]);
                }
                int i = 0;
                foreach(string item in cbLogin.Items){
                    if(item.Equals(employee)){
                        break;
                    }
                    i++;
                }
                setVal(i);
                tabControl.TabPages.Remove(tabInventory);
                tabControl.TabPages.Remove(tabOrder);
                tabControl.TabPages.Remove(tabCustomer);
                tabControl.TabPages.Remove(tabPurchaseOrders);
                tabControl.TabPages.Remove(tabSuppliers);
                tabControl.TabPages.Remove(tabShippers);
                tabControl.TabPages.Remove(tabEmployees);

                tabControl.SizeMode = TabSizeMode.Fixed;
                tabControl.ItemSize = new Size(130, 20);

                //MessageBox.Show("Connected");
                //determineOrder();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable getCurrentTable()
        {
            return dt;
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string x = dgvInventoryToRecorder.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //MessageBox.Show(e.ToString());
            Form6 f = new Form6();
            f.setName(x);
            selectTable("inventory");
            f.fillInventory(dt);
            selectTable("products");
            f.fillProducts(dt);
            selectTable("supplier");
            f.fillSuppliers(dt);
            f.initialize();
            f.Show();
        }
        private void setVal(int x)
        {
            combVal = x;
        }
        private int getVal()
        {
            return combVal;
        }
        public void setEmployee(string x){
            employee = x;
            cbLogin.Text = employee;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!tabControl.TabPages.Contains(tabInventory))
            {
                tabControl.TabPages.Add(tabInventory);
            }
            tabControl.SelectTab(tabInventory);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!tabControl.TabPages.Contains(tabOrder))
            {
                tabControl.TabPages.Add(tabOrder);
            }
            tabControl.SelectTab(tabOrder);

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!tabControl.TabPages.Contains(tabCustomer))
            {
                tabControl.TabPages.Add(tabCustomer);
            }
            tabControl.SelectTab(tabCustomer);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!tabControl.TabPages.Contains(tabPurchaseOrders))
            {
                tabControl.TabPages.Add(tabPurchaseOrders);
            }
            tabControl.SelectTab(tabPurchaseOrders);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!tabControl.TabPages.Contains(tabSuppliers))
            {
                tabControl.TabPages.Add(tabSuppliers);
            }
            tabControl.SelectTab(tabSuppliers);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!tabControl.TabPages.Contains(tabEmployees))
            {
                tabControl.TabPages.Add(tabEmployees);
            }
            tabControl.SelectTab(tabEmployees);
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!tabControl.TabPages.Contains(tabShippers))
            {
                tabControl.TabPages.Add(tabShippers);
            }
            tabControl.SelectTab(tabShippers);
        }

        private void employeeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Setting Tables
        /// </summary>
        private void fillInventory()
        {
            da.SelectCommand = new MySqlCommand(" select * from northwind.inventory ;", myConn);
            da.Fill(ds, "northwind.inventory");
            dt = ds.Tables["northwind.inventory"];

            cb = new MySqlCommandBuilder(da);
            dgvInventory.DataSource = dt;

            DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();

            btnCol.HeaderText = "Purchase from Supplier";
            btnCol.UseColumnTextForButtonValue = true;
            btnCol.Text = "Purchase";

            myConn.Open();
            

            dgvInventory.Columns.Add(btnCol);
            DataGridViewColumn column = dgvInventory.Columns[0];
            column.Width = 400;
        }
        private void fillOrder()
        {
            da.SelectCommand = new MySqlCommand(" select * from northwind.eorder ;", myConn);
            da.Fill(ds, "northwind.eorder");
            dt = ds.Tables["northwind.eorder"];
            cb = new MySqlCommandBuilder(da);
            dgvOrders.DataSource = dt;
            
            
        }
        private void fillCustomer()
        {
            da.SelectCommand = new MySqlCommand(" select * from northwind.customer ;", myConn);
            da.Fill(ds, "northwind.customer");
            dt = ds.Tables["northwind.customer"];
            cb = new MySqlCommandBuilder(da);
            dgvCustomers.DataSource = dt;
        }
        private void fillProducts()
        {
            da.SelectCommand = new MySqlCommand(" select * from northwind.products ;", myConn);
            da.Fill(ds, "northwind.products");
            dt = ds.Tables["northwind.products"];
            cb = new MySqlCommandBuilder(da); 
        }
        private void fillPurchaseOrder()
        {
            da.SelectCommand = new MySqlCommand(" select * from northwind.purchaseorder ;", myConn);
            da.Fill(ds, "northwind.purchaseorder");
            dt = ds.Tables["northwind.purchaseorder"];
            cb = new MySqlCommandBuilder(da);
            dgvPurchaseOrders.DataSource = dt;
        }
        private void fillSupplier()
        {
            da.SelectCommand = new MySqlCommand(" select * from northwind.supplier ;", myConn);
            da.Fill(ds, "northwind.supplier");
            dt = ds.Tables["northwind.supplier"];
            cb = new MySqlCommandBuilder(da);
            dgvSuppliers.DataSource = dt;
        }
        private void fillShipper()
        {
            da.SelectCommand = new MySqlCommand(" select * from northwind.shipper ;", myConn);
            da.Fill(ds, "northwind.shipper");
            dt = ds.Tables["northwind.shipper"];
            cb = new MySqlCommandBuilder(da);
            dgvShippers.DataSource = dt;
        }
        private void fillActiveOrder()
        {
            da.SelectCommand = new MySqlCommand(" select * from northwind.activeorder ;", myConn);
            da.Fill(ds, "northwind.activeorder");
            dt = ds.Tables["northwind.activeorder"];
            cb = new MySqlCommandBuilder(da);
            dgvActiveOrder.DataSource = dt;
        }
        private void fillInvToRec()
        {
            fillReorder();
            /*da.SelectCommand = new MySqlCommand(" select * from northwind.inventorytorecorder ;", myConn);
            da.Fill(ds, "northwind.inventorytorecorder");
            dt = ds.Tables["northwind.inventorytorecorder"];
            cb = new MySqlCommandBuilder(da);
            tempDGV.DataSource = dt;
            int x = tempDGV.Rows.Count;
            for (int j = 0; j < x; j++)
            {
                //MessageBox.Show(x.ToString());
                dgvInventoryToRecorder.Rows.Add(new DataGridViewRow());
                    for (int i = 0; i < 3; i++)
                    {
                        dgvInventoryToRecorder.Rows[j].Cells[i].Value = tempDGV.Rows[j].Cells[i].Value;
                    }
            }*/
            
        }
        private void fillProductBox()
        {
            selectTable("products");
            foreach (DataRow row in dt.Rows)
            {
                productBox.Items.Add(row[3].ToString());
            }
        }
        private void fillEmployeeBox()
        {
            selectTable("employee");
            foreach (DataRow row in dt.Rows)
            {
                empBox.Items.Add(row[1].ToString() + " " + row[3].ToString());
            }
        }
        private void fillShipperBox()
        {
            selectTable("shipper");
            foreach (DataRow row in dt.Rows)
            {
                shipperBox.Items.Add(row[0].ToString());
            }
        }
        private void fillCustomerBox()
        {
            selectTable("customer");
            foreach (DataRow row in dt.Rows)
            {
                customerBox.Items.Add(row[2].ToString() + " " + row[3].ToString());
            }
        }
        private void fillSupplierBox()
        {
            selectTable("supplier");
            foreach (DataRow row in dt.Rows)
            {
                supplierBox.Items.Add(row[0].ToString());
            }
        }
        private void fillReorder()
        {
            selectTable("inventory");
            /*DataColumn pName = dt.Columns[0];
            DataColumn total = dt.Columns[1];
            DataColumn toReorder = dt.Columns[7];*/
            DataTable newReo = new DataTable();
            newReo = dt.Copy();
            newReo.Columns.Remove("AllocatedInventory");
            newReo.Columns.Remove("AvailibleInventory");
            newReo.Columns.Remove("InventoryDue");
            newReo.Columns.Remove("CombinedTotal");
            newReo.Columns.Remove("TargetLevel");
            dt = newReo.Copy();
            int x = dt.Rows.Count;
            for (int j = 0; j < x; j++)
            {
                //MessageBox.Show(x.ToString());
                dgvInventoryToRecorder.Rows.Add(new DataGridViewRow());
                for (int i = 0; i < 3; i++)
                {
                    dgvInventoryToRecorder.Rows[j].Cells[i].Value = dt.Rows[j][i];
                }
            }
            //dgvInventory.DataSource = newReo;
            
            
        }
        private void fillEmployee()
        {
            da.SelectCommand = new MySqlCommand(" select * from northwind.employee ;", myConn);
            da.Fill(ds, "northwind.employee");
            dt = ds.Tables["northwind.employee"];
            cb = new MySqlCommandBuilder(da);
            dgvEmployees.DataSource = dt;

            
            
            //dgvEmployees.DataSource = bSource;
            //bSource.DataSource = dt;
        }
        private void determineOrder()
        {         
            foreach (DataGridViewRow d in dgvOrders.Rows)
            {
                if (int.Parse(d.Cells[0].Value.ToString()) >= orderNum)
                {
                    //MessageBox.Show((d.Cells[0].Value.ToString()));
                    //orderNum = int.Parse(d.Cells[0].Value.ToString());
                }
            }
            selectTable("employee");
            
        }
        public void selectTable(string x)
        {
            dt = ds.Tables["northwind." + x];
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabInventory);
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
        }
        private void dgvInventory_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tabControl.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private void tabControl_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabControl.TabPages.Count; i++)
            {
                Rectangle r = tabControl.GetTabRect(i);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location))
                {
                        this.tabControl.TabPages.RemoveAt(i);
                        break;
                    
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            employee = cbLogin.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            
            f.setPerson(employee);
            selectTable("customer");
            f.setTable(dt);
            selectTable("shipper");
            f.addShip(dt);
            selectTable("inventory");
            f.setInventory(dt);
            selectTable("products");
            f.setProducts(dt);
            selectTable("eorder");
            f.setOrder(dt);
            f.fillBox();

            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl_MouseHover(object sender, EventArgs e)
        { }


        private void tabControl_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void dgvInventory_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root"))
            using (var adapter = new MySqlDataAdapter("SELECT * FROM northwind.employee", con))
            using (new MySqlCommandBuilder(adapter))
            {
                try
                {
                    con.Open();
                    adapter.Update(dt);
                    MessageBox.Show("FINALLY!");
                }
                catch (Exception ead)
                {
                    MessageBox.Show(ead.Message);
                }
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            cbLogin.Text = employee;
            MessageBox.Show("Hello");
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tabInventory_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void newPOrder_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        private void newPOrder_MouseHover(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
            
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void dgvInventoryToRecorder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            selectTable("customer");
            f.fillCustomer(dt);
            f.setCustomer();
            f.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            selectTable("employee");
            f.fillEmployee(dt);
            f.setEmployee();
            f.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            selectTable("supplier");
            f.fillSupplier(dt);
            f.setSupplier();
            f.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            selectTable("shipper");
            f.fillShipper(dt);
            MessageBox.Show("Hello");
            f.setShipper();
            f.Show();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string x = dgvCustomers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            Form7 f = new Form7();
            selectTable("customer");
            

        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string x = dgvEmployees.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            MessageBox.Show(x);
            Form7 f = new Form7();
            selectTable("employee");         
            f.fillEmployee(dt);
            f.setID(x);
            f.setEmployee();
            f.initialize();
            
            f.Show();
            
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = productBox.SelectedItem.ToString();
            //MessageBox.Show(e.ToString());
            Form6 f = new Form6();
            f.setName(x);
            selectTable("inventory");
            f.fillInventory(dt);
            selectTable("products");
            f.fillProducts(dt);
            selectTable("supplier");
            f.fillSuppliers(dt);
            f.initialize();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            selectTable("inventory");
            f.fillInventory(dt);
            selectTable("products");
            f.fillProducts(dt);
            selectTable("supplier");
            f.fillSuppliers(dt);
            f.initialize();
            f.newP();
            f.Show();
        }

        private void empBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = empBox.SelectedItem.ToString();
            //MessageBox.Show(e.ToString());
            Form7 f = new Form7();
            f.setName(x);
            selectTable("employee");
            f.fillEmployee(dt);
            f.setID(x);
            f.setName2(x);
            f.setEmployee();
            f.initialize();

            f.Show();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.setEmployee();
            selectTable("employee");
            f.fillEmployee(dt);
            f.initialize();
            f.Show();
        }

        private void shipperBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = shipperBox.SelectedItem.ToString();
            //MessageBox.Show(e.ToString());
            Form7 f = new Form7();
            f.setName(x);
            selectTable("shipper");
            f.fillShipper(dt);
            f.setShipper();
            f.initialize();

            f.Show();
        }

        private void supplierBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = supplierBox.SelectedItem.ToString();
            //MessageBox.Show(e.ToString());
            Form7 f = new Form7();
            f.setName(x);
            selectTable("supplier");
            f.fillSupplier(dt);
            f.setSupplier();
            f.initialize();

            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.setSupplier();
            selectTable("supplier");
            f.fillSupplier(dt);
            f.initialize();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.setShipper();
            selectTable("shipper");
            f.fillShipper(dt);
            f.initialize();
            f.Show();
        }

        private void customerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = customerBox.SelectedItem.ToString();
            //MessageBox.Show(e.ToString());
            Form7 f = new Form7();
            f.setName(x);
            selectTable("customer");
            f.fillCustomer(dt);
            f.setCustomer();
            f.initialize();

            f.Show();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.setCustomer();
            selectTable("customer");
            f.fillCustomer(dt);
            f.initialize();
            f.Show();
        }
    }
}
