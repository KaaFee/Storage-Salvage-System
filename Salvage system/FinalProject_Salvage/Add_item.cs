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
    public partial class Add_item : Form
    {
        public Add_item()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AMHome back22 = new AMHome();
            back22.ShowDialog();
        }

        private void Add_item_Load(object sender, EventArgs e)
        {

        }
        SqlConnection sq = new SqlConnection("Data Source = MUSHFIQ80\\SQLEXPRESS; Initial Catalog = AManage; Persist Security Info=True;User ID = sa; Password=root");
        void Show02()
        {
            SqlCommand sC = new SqlCommand("select * from Add_new ", sq);
            SqlDataAdapter sA = new SqlDataAdapter(sC);
            DataTable dT = new DataTable();
            sA.Fill(dT);
            dataGridView1.DataSource = dT;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sq.Open();
            SqlCommand sC = new SqlCommand("INSERT INTO Add_new VALUES ( '" + int.Parse(textBox1.Text) + "' ,' " + textBox2.Text + " ', '" + textBox3.Text + "','" + int.Parse(textBox4.Text) + "', '" + int.Parse(textBox5.Text) + "','" + textBox6.Text + "','" + int.Parse(textBox7.Text) + "')", sq);
            sC.ExecuteNonQuery();
            MessageBox.Show("Insert Successful");
            sq.Close();
            Show02();
        }
    }
}
