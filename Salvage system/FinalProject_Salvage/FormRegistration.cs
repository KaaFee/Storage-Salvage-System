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

namespace LogInPage
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Init f1 = new Init();
            f1.Show();
        }

        private void showPassReg_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassReg.Checked)
            {
                textBox4.PasswordChar = '\0';
            }
            else
            {
                textBox4.PasswordChar = '*';
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
            string name,userHandle,managerPost,email,password,organizationCode;

            name = textBox1.Text;
            userHandle = textBox5.Text;
            email = textBox3.Text;
            organizationCode = textBox2.Text;
            password = textBox4.Text;
            managerPost = "";

            if(checkBox1.Checked)
            {
                managerPost += "AM,";
            }
            if(checkBox2.Checked)
            {
                managerPost += "BM,";
            }

            try
            {
                SqlConnection sq = new SqlConnection("Data Source=DESKTOP-CJ7CVSI\\SQLEXPRESS;Initial Catalog=StorageSalvage;Persist Security Info=True;User ID=sa;Password=1234ka");

                string query = "insert into StoSalRegistration(Name,OrganizationCode,ManagerPost,UserHandle,Email,Password)values('"+ name +"','"+organizationCode+"','"+managerPost+"','"+userHandle+"','"+email+"','"+password+"')";
                sq.Open();
                SqlCommand cmd = new SqlCommand(query, sq);
                int row = cmd.ExecuteNonQuery();
                sq.Close();
                if(row>0)
                {
                    MessageBox.Show("Registration Successfull");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
