﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            //sq.Open();
            // SqlCommand sC = new SqlCommand("Delete Request_Product where Product_id= '" + int.Parse(textBox1.Text) + "'", sq);
            // sC.ExecuteNonQuery();
            // sq.Close();
            //ShowMe();
            // MessageBox.Show("deletion complete");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
