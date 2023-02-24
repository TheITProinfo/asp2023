using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Cstdemo2
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            LoadUserInfos();
        }

        /// <summary>
        /// load userdata from database with dataAdapter
        /// </summary>
        private void LoadUserInfos()
        {
            //
            //MessageBox.Show("data loading!!");


            String connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                
                string strSql = "select * From UserInfo where DelFlag=0 ";

                using (SqlDataAdapter adapter = new SqlDataAdapter(strSql,conn))
                {
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);
                    //this.dgvUserInfo.DataSource = dt;

                    List<UserInfo> userList = new List<UserInfo>();

                    UserInfo userInfo = new UserInfo();
                    // convert data to userInfo 
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        userInfo.UserID = int.Parse(dataRow["UserId"].ToString());
                        userInfo.UserName = dataRow["UserName"].ToString();
                        userInfo.UserEmail = dataRow["UserEmail"].ToString();
                        userInfo.UserMobile = dataRow["UserMobile"].ToString();
                        userList.Add(userInfo);

                    }

                    this.dgvUserInfo.DataSource = userList;


                }

               

                

            }

        }  
    }
}
