using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bm_homepage
{
    public partial class New_Product_Line : Form
    {
        public New_Product_Line()
        {
            InitializeComponent();
        }

        

        private void New_Product_Line_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
