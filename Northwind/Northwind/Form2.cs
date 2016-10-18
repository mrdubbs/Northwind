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
    public partial class Form2 : Form
    {
        string person, company, shipper;
        string address, city, state, country;
        string zip;
        Boolean start = false;
        DataTable dt = new DataTable();
        DataTable inventory = new DataTable();
        DataTable products = new DataTable();
        DataTable ship = new DataTable();
        DataTable order = new DataTable();
        public Form2()
        {
            InitializeComponent();
            tabPage1.Enabled = false;
            tabPage2.Enabled = false;
            tabPage3.Enabled = false;
            closeLbl.Parent = pictureBox1;
            orderLbl.Parent = pictureBox1;
            createLbl.Parent = pictureBox1;
            shipLbl.Parent = pictureBox1;
            completeLbl.Parent = pictureBox1;
            deleteLbl.Parent = pictureBox1;
           

            dgvOrder.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dgvOrder_EditingControlShowing);
        }
        public void setPerson(string n)
        {
            person = n;
        }
        public void addShip(DataTable d)
        {
            ship = d.Copy();
        }
        public void setTable(DataTable d)
        {
            dt = d.Copy();
        }
        public void setOrder(DataTable d)
        {
            order = d.Copy();
        }
        public void setInventory(DataTable d)
        {
            inventory = d.Copy();
        }
        public void setProducts(DataTable d)
        {
            products = d.Copy();
        }
        public void fillBox()
        {
            foreach (DataRow dtRow in dt.Rows)
            {
                customerBox.Items.Add(dtRow[0]);
            }
        }
        public void addTable(DataTable d)
        {
            ship = d.Copy();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabPage1.Enabled = true;
            tabPage2.Enabled = true;
            tabPage3.Enabled = true;
            foreach (DataRow dRow in ship.Rows)
            {
                shipBox.Items.Add(dRow[0]);
            }
            DateTime date = DateTime.Parse(System.DateTime.Now.ToString());
            dateTxt.Text = System.DateTime.Now.ToShortDateString();
            string company = customerBox.Text;
            int max = -1000000;
            foreach (DataRow r in order.Rows)
            {
                int i = int.Parse(r[0].ToString());
                if (i > max)
                {
                    max = i;
                }
            }
            max+=1;
            orderLbl.Text = "Order #" + max;
            foreach (DataRow dRow in dt.Rows)
            {
                if(company.Equals(dRow[0]))
                {
                    shipper = dRow[2] + " " + dRow[3];
                    address = dRow[11].ToString();
                    city = dRow[14].ToString();
                    state = dRow[13].ToString();
                    zip = dRow[12].ToString();
                    country = dRow[15].ToString();
                    break;
                }
                
            }
            MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root;Convert Zero Datetime=True");
            MySqlCommand cmd = new MySqlCommand("select * from northwind.customer where Company LIKE company", conn);
            
            
            shipNameLbl.Text = shipper;
            addressLbl.Text = address;
            cityLbl.Text = city;
            stateLbl.Text = state;
            zipLbl.Text = zip;
            countryLbl.Text = country;
            
            foreach (DataRow dRow in inventory.Rows)
            {
                Product.Items.Add(dRow[0]);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            salesBox.Text = person;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void shipBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Activated");
        }
        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void dgvOrder_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox combo  = e.Control as ComboBox;
            if(combo != null){
                combo.SelectedIndexChanged-= new EventHandler(ComboBox_SelectedIndexChanged);
                combo.SelectedIndexChanged+= new EventHandler(ComboBox_SelectedIndexChanged);
                 
            }
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string item = cb.Text;
            for (int k = 0; k < dgvOrder.Rows.Count; k++)
            {
                DataGridViewRow row = dgvOrder.Rows[k];
                int qty = 0;
                double price = 0.00;
                    for (int i = 0; i < inventory.Rows.Count; i++)
                    {
                        DataRow drow = inventory.Rows[i];
                        if (drow[0].ToString() == item)
                        {
                            row.Cells[1].Value = drow[3].ToString();
                            qty = int.Parse(drow[3].ToString());
                            break;
                        }
                    }
                    foreach (DataRow drow in products.Rows)
                    {
                        if (drow[3].ToString() == item)
                        {
                            row.Cells[2].Value = "$"+drow[6].ToString();
                            price = double.Parse(drow[6].ToString());
                            k = dgvOrder.Rows.Count;
                            break;

                        }
                    }
                    double discount = .95;
                    row.Cells[3].Value = "5.00%";
                    double total = qty * price;
                    total *= discount;
                    row.Cells[4].Value = "$" + total.ToString();

                    start = true;
  
            }
            
        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (start)
            {
                int index = e.RowIndex;
                DataGridViewRow row = dgvOrder.Rows[index];
                int qty = int.Parse(row.Cells[1].Value.ToString());
                double discount = .95;
                string x = row.Cells[2].Value.ToString();
                string y = "";
                foreach (char c in x.ToCharArray())
                {
                    if (c != '$')
                        y += c;
                }
                int price = int.Parse(y);
                double total = qty * price;
                total *= discount;
                row.Cells[4].Value = "$" + total.ToString();
                start = false;
            }
            

        }
    }
}

