using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bm_homepage
{
    public partial class Request_Product : Form
    {
        public Request_Product()
        {
            InitializeComponent();
        }

        SqlConnection sq = new SqlConnection("Data Source=DESKTOP-98FN3EK\\SQLEXPRESS;Initial Catalog=BM;User ID=sa;Password=Aryastark ");
        void ShowMe()
        {
            SqlCommand sC = new SqlCommand("select * from Request_Product", sq);
            SqlDataAdapter sA = new SqlDataAdapter(sC);
            DataTable dT = new DataTable();
            sA.Fill(dT);
            dataGridView1.DataSource = dT;

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Request_Product_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Product id can not be empty");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Product name can not be empty");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("BM ID can not be empty");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Branch name can not be empty");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Quantity can not be empty");
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("Advance payment can not be empty");
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show("Due amount can not be empty");
            }

            sq.Open();
            SqlCommand sC = new SqlCommand("INSERT INTO Request_Product VALUES ( '" + int.Parse(textBox1.Text) + "' ,' " + textBox2.Text + " ', '" + int.Parse(textBox3.Text) + "','" + textBox4.Text + "', '" + int.Parse(textBox5.Text) + "','" + int.Parse(textBox6.Text) + "','" + int.Parse(textBox7.Text) + "')", sq);
            sC.ExecuteNonQuery();
            MessageBox.Show("insertion complete");
            sq.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sC = new SqlCommand("Delete Request_Product where Product_id= '" + int.Parse(textBox1.Text) + "'", sq);
            sC.ExecuteNonQuery();
            sq.Close();
            ShowMe();
            MessageBox.Show("deletion complete");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sC = new SqlCommand("Update Request_Product set Quantity='" + int.Parse(textBox5.Text) + "',Advance_payment='" + int.Parse(textBox6.Text) + "',Due_amount='" + int.Parse(textBox7.Text) + "'where  Product_id='" + int.Parse(textBox1.Text) + "'",sq);

            sC.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully");
            sq.Close();
            ShowMe();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowMe();
        }
    }
}
