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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            printLbl.Parent = pictureBox1;
            previewLbl.Parent = pictureBox1;
            closeLbl.Parent = pictureBox1;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
