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
    public partial class Check_Req : Form
    {
        public Check_Req()
        {
            InitializeComponent();
            Show03();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            AMHome back22 = new AMHome();
            back22.ShowDialog();
        }
        SqlConnection sq = new SqlConnection("Data Source = MUSHFIQ80\\SQLEXPRESS; Initial Catalog = AManage; Persist Security Info=True;User ID = sa; Password=root");


        private void Check_Req_Load(object sender, EventArgs e)
        {

        }
        void Show03()
        {
            SqlCommand sC = new SqlCommand("select * from Product_Col", sq);
            SqlDataAdapter sA = new SqlDataAdapter(sC);
            DataTable dT = new DataTable();
            sA.Fill(dT);
            dataGridView1.DataSource = dT;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
