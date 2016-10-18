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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            status.Parent = pictureBox1;
            label12.Parent = pictureBox1;
            label13.Parent = pictureBox1;
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
