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
    public partial class Stock_Managing : Form
    {
        public Stock_Managing()
        {
            InitializeComponent();
        }

        

        private void Stock_Managing_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
