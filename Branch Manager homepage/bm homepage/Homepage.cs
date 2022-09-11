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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stock_Managing sm = new Stock_Managing();
            sm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            New_Product_Line np = new New_Product_Line();
            np.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Request_Product rp = new Request_Product();
            rp.Show();
            this.Hide();
        }
    }
}
