using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind
{
    public partial class Form3 : Form
    {
        Form1 f;
        string emp;
        public Form3()
        {
            
            InitializeComponent();
            f = new Form1();
            f.selectTable("employee");
            DataTable dt = f.getCurrentTable();
            //Login
            foreach (DataRow dtRow in dt.Rows)
            {
                employeeLogin.Items.Add(dtRow[1] + " " + dtRow[3]);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void employeeLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            emp = employeeLogin.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f.setEmployee(emp);
            f.Show();
            this.Hide();
        }
    }
}
