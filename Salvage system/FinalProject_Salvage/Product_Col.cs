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
    public partial class Product_Col : Form
    {

        public Product_Col()
        {
            InitializeComponent();
            Show01();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Product_Col_Load(object sender, EventArgs e)
        {

        }
        SqlConnection sq = new SqlConnection("Data Source = MUSHFIQ80\\SQLEXPRESS; Initial Catalog = AManage; Persist Security Info=True;User ID = sa; Password=root");
        
       
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AMHome back11 = new AMHome();
            back11.ShowDialog();
        }
        void Show01()
        {
            SqlCommand sC = new SqlCommand("select * from Product_Col", sq);
            SqlDataAdapter sA = new SqlDataAdapter(sC);
            DataTable dT = new DataTable();
            sA.Fill(dT);
            dataGridView1.DataSource = dT;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sC = new SqlCommand("INSERT INTO Product_Col VALUES ( '" + int.Parse(textBox1.Text) + "' ,' " + textBox2.Text + " ', '" + textBox3.Text + "','" + int.Parse(textBox4.Text) + "', '" + int.Parse(textBox5.Text) + "','" + textBox6.Text + "','" + int.Parse(textBox7.Text) + "')", sq);
            sC.ExecuteNonQuery();
            MessageBox.Show("Insert Successful");
            sq.Close();
            Show01(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sC = new SqlCommand("Delete Product_Col where Productid= ('" +int.Parse(textBox1.Text)+ "')",sq);
            sC.ExecuteNonQuery();
            sq.Close();
            Show01();
            MessageBox.Show("deletion complete");
        }
    }
}
