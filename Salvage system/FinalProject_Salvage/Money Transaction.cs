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
    public partial class Money_Transaction : Form
    {
        public Money_Transaction()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AMHome back22 = new AMHome();
            back22.ShowDialog();
        }
        SqlConnection sq1 = new SqlConnection("Data Source=MUSHFIQ80\\SQLEXPRESS;Initial Catalog=AManage;Persist Security Info=True;User ID=sa;Password=roo");
        private void Money_Transaction_Load(object sender, EventArgs e)
        {

        }
        void ShowTran()
        {
            SqlCommand sC = new SqlCommand("select * from money_tran",sq1);
            SqlDataAdapter s1 = new SqlDataAdapter(sC);
            DataTable data = new DataTable();
            s1.Fill(data);
            dataGridView1.DataSource = data;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*sq1.Open();
            SqlCommand sC = new SqlCommand("INSERT INTO money_tran VALUES ( '" + int.Parse(textBox1.Text) + "' ,' " + textBox2.Text + " ', '" + int.Parse(textBox3.Text) + "','" + int.Parse(textBox4.Text) + "', '" + textBox5.Text + "','" + float.Parse(textBox6.Text) + "','" + float.Parse(textBox7.Text)+"','"+float.Parse(textBox8.Text)+ "')", sq1);
            sC.ExecuteNonQuery();
            MessageBox.Show("Insert Successful");
            ShowTran();
            sq1.Close();
            */
        }
    }
}
