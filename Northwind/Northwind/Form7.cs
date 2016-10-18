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
    public partial class Form7 : Form
    {
        private DataTable employee, customer, supplier, shipper;
        private Boolean isCustomer, isEmployee, isSupplier, isShipper;
        private string nameID, name2;
        public Form7()
        {
            InitializeComponent();
            nameLbl.Parent = pictureBox1;
            label17.Parent = pictureBox1;
            
        }
        public void setName(string x)
        {
            nameLbl.Text = x;
        }
        private void fNumberBox_TextChanged(object sender, EventArgs e)
        {

        }
        public void fillEmployee(DataTable dt)
        {
            employee = dt.Copy();
        }
        public void fillCustomer(DataTable dt)
        {
            customer = dt.Copy();
        }
        public void fillShipper(DataTable dt)
        {
            shipper = dt.Copy();
        }
        public void fillSupplier(DataTable dt)
        {
            supplier = dt.Copy();
        }
        public void setCustomer()
        {
            isCustomer = true;
            isEmployee = false;
            isShipper = false;
            isSupplier = false;
        }
        public void setEmployee()
        {
            isEmployee = true;
            isCustomer = false;
            isSupplier = false;
            isShipper = false;
        }
        public void setShipper()
        {
            isShipper = true;
            isEmployee = false;
            isCustomer = false;
            isSupplier = false;
        }
        public void setSupplier()
        {
            isSupplier = true;
            isEmployee = false;
            isCustomer = false;
            isShipper = false;

        }
        private void label17_Click(object sender, EventArgs e)
        {
            nameID = idBox.Text;
            Boolean isUpdate = false;
            int index = 0;
            if (isEmployee == true)
            {
                foreach (DataRow row in employee.Rows)
                {
                    if (nameID.Equals(row[2].ToString()))
                    {
                        isUpdate = true;
                        break;
                    }
                    index++;
                }
                employee.DefaultView.Sort = "EmployeeID";
                string id = employee.Rows[employee.Rows.Count - 1][2].ToString();
                int i = int.Parse(id);

                i += 1;
                if (isUpdate)
                {
                    int di = int.Parse(idBox.Text.ToString());
                    employee.Rows[index].Delete();
                    employee.Rows.Add(null, fNameBox.Text, di, lNameBox.Text, emailBox.Text, bPhoneBox.Text, companyBox.Text, jTitleBox.Text, hPhoneBox.Text, mPhoneBox.Text, fNumberBox.Text, streetBox.Text, cityBox.Text, sBox.Text, int.Parse(pCodeBox.Text.ToString()), regionBox.Text, notesBox.Text);

                }
                else
                {
                    employee.Rows.Add(null, fNameBox.Text, i, lNameBox.Text, emailBox.Text, bPhoneBox.Text, companyBox.Text, jTitleBox.Text, hPhoneBox.Text, mPhoneBox.Text, fNumberBox.Text, streetBox.Text, cityBox.Text, sBox.Text, int.Parse(pCodeBox.Text.ToString()), regionBox.Text, notesBox.Text);
                }
                
                using (var con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root"))
                using (var adapter = new MySqlDataAdapter("SELECT * FROM northwind.employee", con))
                using (new MySqlCommandBuilder(adapter))
                {
                    try
                    {
                        con.Open();
                        adapter.Update(employee);
                        MessageBox.Show("Successful!");
                    }
                    catch (Exception ead)
                    {
                        MessageBox.Show(ead.Message);
                    }
                }
            }
            if (isCustomer == true)
            {
                foreach (DataRow row in customer.Rows)
                {
                    if (nameID.Equals(row[1].ToString()))
                    {
                        isUpdate = true;
                        break;
                    }
                    index++;
                }
                customer.DefaultView.Sort = "CustomerID";
                string id = customer.Rows[customer.Rows.Count - 1][1].ToString();
                int i = int.Parse(id);

                i += 1;
                if (isUpdate)
                {
                    int di = int.Parse(idBox.Text.ToString());
                    customer.Rows[index].Delete();
                    customer.Rows.Add(companyBox.Text, di, fNameBox.Text, lNameBox.Text, emailBox.Text, bPhoneBox.Text, jTitleBox.Text, notesBox.Text, hPhoneBox.Text, mPhoneBox.Text, fNumberBox.Text, streetBox.Text, int.Parse(pCodeBox.Text.ToString()), cityBox.Text, sBox.Text, regionBox.Text);

                }
                else
                {
                    customer.Rows.Add(companyBox.Text, i, fNameBox.Text, lNameBox.Text, emailBox.Text, bPhoneBox.Text, jTitleBox.Text, notesBox.Text, hPhoneBox.Text, mPhoneBox.Text, fNumberBox.Text, streetBox.Text, int.Parse(pCodeBox.Text.ToString()), cityBox.Text, sBox.Text, regionBox.Text);
                }
                
                using (var con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root"))
                using (var adapter = new MySqlDataAdapter("SELECT * FROM northwind.customer", con))
                using (new MySqlCommandBuilder(adapter))
                {
                    try
                    {
                        con.Open();
                        adapter.Update(customer);
                        MessageBox.Show("Successful!");
                    }
                    catch (Exception ead)
                    {
                        MessageBox.Show(ead.Message);
                    }
                }
            }
            if (isSupplier == true)
            {
                MessageBox.Show("ji");
                foreach (DataRow row in supplier.Rows)
                {
                    if (nameID.Equals(row[1].ToString()))
                    {
                        isUpdate = true;
                        break;
                    }
                    index++;
                }
                
                string id = supplier.Rows[supplier.Rows.Count - 1][1].ToString();
                int i = int.Parse(id);
                i = getID();
                if (isUpdate)
                {
                    int di = int.Parse(idBox.Text.ToString());
                    supplier.Rows[index].Delete();
                    supplier.Rows.Add(companyBox.Text, di, fNameBox.Text, lNameBox.Text, emailBox.Text, bPhoneBox.Text, jTitleBox.Text, notesBox.Text, hPhoneBox.Text, mPhoneBox.Text, fNumberBox.Text, streetBox.Text, pCodeBox.Text, sBox.Text, cityBox.Text, regionBox.Text);
                }
                else
                {
                    supplier.Rows.Add(companyBox.Text, i, fNameBox.Text, lNameBox.Text, emailBox.Text, bPhoneBox.Text, jTitleBox.Text, notesBox.Text, hPhoneBox.Text, mPhoneBox.Text, fNumberBox.Text, streetBox.Text, pCodeBox.Text, sBox.Text, cityBox.Text, regionBox.Text);
                }
                
                using (var con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root"))
                using (var adapter = new MySqlDataAdapter("SELECT * FROM northwind.supplier", con))
                using (new MySqlCommandBuilder(adapter))
                {
                    try
                    {
                        con.Open();
                        adapter.Update(supplier);
                        MessageBox.Show("Successful!");
                    }
                    catch (Exception ead)
                    {
                        MessageBox.Show(ead.ToString());
                    }
                }
            }
            if (isShipper == true)
            {
                foreach (DataRow row in shipper.Rows)
                {
                    if (nameID.Equals(row[1].ToString()))
                    {
                        isUpdate = true;
                        break;
                    }
                    index++;
                }
                shipper.DefaultView.Sort = "ShipperID";
                string id = shipper.Rows[shipper.Rows.Count - 1][1].ToString();
                int i = int.Parse(id);
                i += 1;
                if (isUpdate)
                {
                    int di = int.Parse(idBox.Text.ToString());
                    shipper.Rows[index].Delete();
                    shipper.Rows.Add(companyBox.Text, di, fNameBox.Text, lNameBox.Text, emailBox.Text, bPhoneBox.Text, jTitleBox.Text, notesBox.Text, hPhoneBox.Text, mPhoneBox.Text, fNumberBox.Text, streetBox.Text, int.Parse(pCodeBox.Text.ToString()), sBox.Text, cityBox.Text, regionBox.Text);
                }
                else
                {
                    shipper.Rows.Add(companyBox.Text, i, fNameBox.Text, lNameBox.Text, emailBox.Text, bPhoneBox.Text, jTitleBox.Text, notesBox.Text, hPhoneBox.Text, mPhoneBox.Text, fNumberBox.Text, streetBox.Text, int.Parse(pCodeBox.Text.ToString()), sBox.Text, cityBox.Text, regionBox.Text);
                }
                
                using (var con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root"))
                using (var adapter = new MySqlDataAdapter("SELECT * FROM northwind.shipper", con))
                using (new MySqlCommandBuilder(adapter))
                {
                    try
                    {
                        con.Open();
                        adapter.Update(shipper);
                        MessageBox.Show("Successful!");
                    }
                    catch (Exception ead)
                    {
                        MessageBox.Show(ead.Message);
                    }
                }
            }
        }
        public void setID(string x)
        {
            nameID = x;
        }
        public void setName2(string x)
        {
            name2 = x;
        }
        public void initialize()
        {
            Boolean isUp = true;
            if (isEmployee)
            {
                foreach (DataRow row in employee.Rows)
                {
                    if ((row[1].ToString()+ " "+row[3].ToString()).Equals(name2))
                    {
                        fNameBox.Text = row[1].ToString();    
                        lNameBox.Text = row[3].ToString();
                        emailBox.Text = row[4].ToString();
                        bPhoneBox.Text = row[5].ToString();
                        companyBox.Text = row[6].ToString();
                        jTitleBox.Text = row[7].ToString();
                        hPhoneBox.Text = row[8].ToString();
                        mPhoneBox.Text = row[9].ToString();
                        fNumberBox.Text = row[10].ToString();
                        streetBox.Text = row[11].ToString();
                        cityBox.Text = row[12].ToString();
                        sBox.Text = row[13].ToString();
                        pCodeBox.Text = row[14].ToString();
                        regionBox.Text = row[15].ToString();
                        notesBox.Text = row[16].ToString();
                        idBox.Text = row[2].ToString();
                        isUp = false;
                    }
                   
                }
                 if(isUp)
                   {
                        idBox.Text = getID().ToString();
                   }
            }
            if (isCustomer)
            {
                foreach(DataRow row in customer.Rows)
                {
                    if((row[2].ToString()+" "+row[3].ToString()).Equals(nameLbl.Text))
                    {
                        fNameBox.Text = row[2].ToString();
                        lNameBox.Text = row[3].ToString();
                        emailBox.Text = row[4].ToString();
                        bPhoneBox.Text = row[5].ToString();
                        companyBox.Text = row[0].ToString();
                        jTitleBox.Text = row[6].ToString();
                        hPhoneBox.Text = row[8].ToString();
                        mPhoneBox.Text = row[9].ToString();
                        fNumberBox.Text = row[10].ToString();
                        streetBox.Text = row[11].ToString();
                        cityBox.Text = row[14].ToString();
                        sBox.Text = row[13].ToString();
                        pCodeBox.Text = row[12].ToString();
                        regionBox.Text = row[15].ToString();
                        notesBox.Text = row[7].ToString();
                        idBox.Text = row[1].ToString();
                        isUp = false;
                    }
                }
                if(isUp)
                    {
                        idBox.Text = getID().ToString();
                    }
            }
            if (isShipper)
            {
                foreach (DataRow row in shipper.Rows)
                {
                    if(row[0].ToString().Equals(nameLbl.Text)){
                        companyBox.Text = row[0].ToString();
                        fNameBox.Text = row[2].ToString();
                        lNameBox.Text = row[3].ToString();
                        emailBox.Text = row[4].ToString();
                        bPhoneBox.Text = row[5].ToString();
                        jTitleBox.Text = row[6].ToString();
                        notesBox.Text = row[7].ToString();
                        hPhoneBox.Text = row[8].ToString();
                        mPhoneBox.Text = row[9].ToString();
                        fNumberBox.Text = row[10].ToString();
                        streetBox.Text = row[11].ToString();
                        pCodeBox.Text = row[12].ToString();
                        sBox.Text = row[13].ToString();
                        cityBox.Text = row[14].ToString();
                        regionBox.Text = row[15].ToString();
                        idBox.Text = row[1].ToString();
                        isUp = false;
                    }
                }
                if (isUp)
                {
                    idBox.Text = getID().ToString();
                }

            }
            if (isSupplier)
            {
                foreach (DataRow row in supplier.Rows)
                {
                    if (row[0].ToString().Equals(nameLbl.Text))
                    {
                        companyBox.Text = row[0].ToString();
                        fNameBox.Text = row[2].ToString();
                        lNameBox.Text = row[3].ToString();
                        emailBox.Text = row[4].ToString();
                        bPhoneBox.Text = row[5].ToString();
                        jTitleBox.Text = row[6].ToString();
                        notesBox.Text = row[7].ToString();
                        hPhoneBox.Text = row[8].ToString();
                        mPhoneBox.Text = row[9].ToString();
                        fNumberBox.Text = row[10].ToString();
                        streetBox.Text = row[11].ToString();
                        pCodeBox.Text = row[12].ToString();
                        sBox.Text = row[13].ToString();
                        cityBox.Text = row[14].ToString();
                        regionBox.Text = row[15].ToString();
                        idBox.Text = row[1].ToString();
                        isUp = false;
                    }
                }
                if (isUp)
                {
                    idBox.Text = getID().ToString();
                }
            }
        }
        private int getID()
        {
            if (isEmployee)
            {
                employee.DefaultView.Sort = "EmployeeID";
                string id = employee.Rows[employee.Rows.Count - 1][2].ToString();
               
                int i = int.Parse(id);

                i += 1;
                return i;
            }
            if (isCustomer)
            {
                customer.DefaultView.Sort = "CustomerID";
                string id = customer.Rows[customer.Rows.Count - 1][1].ToString();
                
                int i = int.Parse(id);

                i += 1;
                return i;
            }
            if (isShipper)
            {
                shipper.DefaultView.Sort = "ShipperID";
                shipper = shipper.DefaultView.ToTable();
                string id = shipper.Rows[shipper.Rows.Count - 1][1].ToString();
                
                int i = int.Parse(id);
                
                i += 1;
                return i;
            }
            else
            {
                int max = -1000000;
                foreach (DataRow row in supplier.Rows)
                {
                    int u = int.Parse(row[1].ToString());
                    if (max < u)
                        max = u;
                }
                max+=1;
                return max;

            }
        }
        private void nameLbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
