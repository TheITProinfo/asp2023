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

namespace CstDemo2
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()) || string.IsNullOrEmpty(txtPwd.Text.Trim()))
            {
                MessageBox.Show("Username or Password is empty!");
            }

            // connect to database, retrieve user's crendentials
            string connStr = "server=192.168.2.18;uid=sa;pwd=Cst001.com;database=market";

            using (SqlConnection conn=new SqlConnection(connStr))
            {

                using (SqlCommand cmd =conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = @"select count(*) from UserInfo where UserName=  '" + txtUserName.Text + "' and UserPassword='" + txtPwd.Text + "'";

                    /*
                                        '"+txtUserName.Text +"'
                                            '"+txtPwd.Text+"'

                    */

                    object result=cmd.ExecuteScalar();

                    int rows=int.Parse(result.ToString());
                    if (rows >= 1)
                    {
                        MessageBox.Show("Login in successfully!");
                    }
                    else
                    {
                        MessageBox.Show("your username or password is invalid!!");
                    }



                }


            }


        }
    }
}
