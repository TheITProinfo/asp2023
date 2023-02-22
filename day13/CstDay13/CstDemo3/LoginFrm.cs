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
using System.Configuration;

namespace CstDemo3
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            // server=127.0.0.1

            if(string.IsNullOrEmpty(txtUserName.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {

                MessageBox.Show("username or password is empty. please check");
                return;

            }

            // connect to database, read username and password from database.
            // string connStr = "server=192.168.2.18;uid=sa;pwd=Cst001.com;database=Market";

            string connStr = ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    //cmd.CommandText = @"select count(*) from UserInfo where UserName='" + txtUserName.Text + "' and UserPassword='" + txtPassword + "'";
                    //cmd.CommandText = @"SELECT count(*) from dbo.UserInfo where UserName='" + txtUserName.Text + "' and UserPassword='" + txtPassword.Text + "'";

                    // "+txtUserName.Text+"
                    // "+txtPassword.Text+"


                    // method 2

                    String strSql = string.Format(@"Select count(*) from dbo.Userinfo where UserName='{0}' and UserPassword='{1}'",txtUserName.Text,txtPassword.Text);

                    cmd.CommandText=strSql;

                    object result=cmd.ExecuteScalar();
                    int rows = int.Parse(result.ToString()); // convert it to interger
                    if (rows >= 1)
                    {
                        MessageBox.Show("Login successfully!!");
                    }
                    else
                    {
                        MessageBox.Show("login failure!!");
                    }
                
                
                }
            
            }


        }
    }
}
