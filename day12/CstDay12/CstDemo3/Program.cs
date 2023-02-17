using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CstDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "server=192.168.2.18;database=market;pwd=Cst001.com;uid=sa";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd=new SqlCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = "INSERT [dbo].[userInfo]([UserName], [UserPassword], [UserAge], [UserEmail], [UserMobile], [CreateDate], [LastLogin], [LastErrDateTime], [DelFlag])VALUES('Ron', '87654321', 23, '', '', '', '', '', 0);";
                    int nums=cmd.ExecuteNonQuery();
                    if (nums != 0)
                    {
                        Console.WriteLine("{0} records inset successfully!!",nums);
                    } 


                }
            }
        }
    }
}
