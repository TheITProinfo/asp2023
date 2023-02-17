using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace CstDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            
            String connStr = "uid=sa;pwd=Cst001.com;server=192.168.2.18;database=market";
            SqlConnection conn = new SqlConnection(connStr);

            // new sql command object
            #region
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                // open database
                conn.Open();
                cmd.CommandText = "INSERT INTO [dbo].[customers]([customerContact], [customerCity], [customerBirthDay]) VALUES('Rob','Missisauga','1980-01-01 00:00:00.000')";
                int nums = cmd.ExecuteNonQuery();
                if (nums != 0)
                {
                    Console.WriteLine("insert {0}\t records succesfully", nums);
                }
            } // end of try

            catch
            {
                Console.WriteLine("something is wrong! open database failure,please check!");
            }
            finally
            {
                conn.Close();
            }

            #endregion



        }
    }
}
