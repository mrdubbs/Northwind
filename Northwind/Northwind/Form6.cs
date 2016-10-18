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
    public partial class Form6 : Form
    {
        private DataTable inventory;
        private DataTable products;
        private DataTable suppliers;
        private string product;
        private string pc;
        public Form6()
        {
            InitializeComponent();
            nameLbl.Parent = pictureBox1;
            closeLbl.Parent = pictureBox1;
            savenewLbl.Parent = pictureBox1;
            inventory = new DataTable();
            products = new DataTable();
            suppliers = new DataTable();
        }
        public void initialize()
        {
            foreach(DataRow row in products.Rows){
                if(row[3].ToString() == product){
                    idBox.Text = row[1].ToString();
                    nameBox.Text = row[3].ToString();
                    codeBox.Text = row[2].ToString();
                    categoryBox.Text = row[12].ToString();
                    qpuBox.Text = row[9].ToString();
                    costBox.Text = row[5].ToString();
                    priceBox.Text = row[6].ToString();
                    reorderBox.Text = row[7].ToString();
                    targetBox.Text = row[8].ToString();
                    drqBox.Text = row[11].ToString();
                    desBox.Text = row[4].ToString();
                    supplierBox.Text = row[0].ToString();
                    newP();
                }
            }
        }
        public void newP()
        {
            foreach (DataRow dRow in suppliers.Rows)
            {
                supplierBox.Items.Add(dRow[0].ToString());

            }
            idBox.Text = calculateID().ToString();
           
        }
        private void nameLbl_Click(object sender, EventArgs e)
        {

        }
        public void fillInventory(DataTable i)
        {
            inventory = i.Copy();
        }
        public void fillProducts(DataTable p)
        {
            products = p.Copy();
        }
        public void fillSuppliers(DataTable s)
        {
            suppliers = s.Copy();
        }
        private void closeLbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void setName(string p)
        {
            product = p;
            nameLbl.Text = product;
        }
        private int calculateID()
        {
            int max = -10000000;
            foreach (DataRow row in products.Rows)
            {
                int j = int.Parse(row[1].ToString());
                if (j > max)
                {
                    max = j;
                }
            }
            int id = max + 1;
            return id;
        }
        private void savenewLbl_Click(object sender, EventArgs e)
        {
            string id = products.Rows[products.Rows.Count - 1][1].ToString();
            int i = int.Parse(id);

            i = calculateID();
            string temp = categoryBox.Text;
            char[] tempA = temp.ToCharArray();
            string init = "";
            Boolean isUpdate = false;
            for (int k = 0; k < tempA.Length; k++)
            {
                if (k == 0)
                {
                    init += tempA[k];
                }
                if (tempA[k] == ' ')
                {
                    init += tempA[k + 1];
                }
            }
            for (int j = 0; j < products.Rows.Count; j++)
            {
                DataRow row = products.Rows[j];
                if (row[2].ToString() == codeBox.Text)
                {
                    id = products.Rows[j][1].ToString();
                    string supplier = products.Rows[j][0].ToString();
                    string pco = products.Rows[j][2].ToString();
                    pc = pco;
                    products.Rows[j].Delete();
                    products.Rows.Add(supplierBox.Text, id, pco, nameBox.Text, desBox.Text, costBox.Text, priceBox.Text, reorderBox.Text, targetBox.Text, qpuBox.Text, dCheck.Checked, drqBox.Text, categoryBox.Text, 0);
                    isUpdate = true;
                }
            }
            if(isUpdate == false)
            {
                pc = "NWT" + init + "-"+ i;
                products.Rows.Add(supplierBox.Text, i.ToString(), pc, nameBox.Text, desBox.Text, costBox.Text, priceBox.Text, reorderBox.Text, targetBox.Text, qpuBox.Text, dCheck.Checked, drqBox.Text, categoryBox.Text, 0);
                id = i.ToString();
            }
            
            using (var con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root"))
            using (var adapter = new MySqlDataAdapter("SELECT * FROM northwind.products", con))
            using (new MySqlCommandBuilder(adapter))
            {
                try
                {
                    con.Open();
                    adapter.Update(products);
                    MessageBox.Show("Successful!\nProduct: "+nameBox.Text+"\nProduct ID: "+id);
                }
                catch (Exception ead)
                {
                    MessageBox.Show(ead.Message);
                }
            }
            idBox.Text = id.ToString();
            nameLbl.Text = nameBox.Text;
            codeBox.Text = pc;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoryBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void categoryBox_Validated(object sender, EventArgs e)
        {
            string temp = categoryBox.Text;
            char[] tempA = temp.ToCharArray();
            string init = "";
            for (int k = 0; k < tempA.Length; k++)
            {
                if (k == 0)
                {
                    init += tempA[k];
                }
                if (tempA[k] == ' ')
                {
                    init += tempA[k + 1];
                }
            }
            pc = "NWT" + init + "-" + idBox.Text.ToString();
            codeBox.Text = pc;
        }

        private void supplierBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
