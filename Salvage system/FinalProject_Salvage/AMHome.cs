using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_Salvage
{
    public partial class AMHome : Form
    {
        public AMHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void prod_col_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product_Col p1 = new Product_Col();
            p1.ShowDialog();

        }

        private void checknew_Click(object sender, EventArgs e)
        {
            this.Hide();
            Check_Req p2 = new Check_Req();
            p2.ShowDialog();
        }

        private void additem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_item item = new Add_item();
            item.ShowDialog();
        }
        
        private void money_Click(object sender, EventArgs e)
        {
            this.Hide();
            Money_Transaction p4 = new Money_Transaction();
            p4.ShowDialog();
        }
    }
}
