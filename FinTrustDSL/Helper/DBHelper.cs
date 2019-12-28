using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FinTrustDSL.Helper
{
    class DBHelper
    {
        public static SqlConnection GetConnection()
        {

            SqlConnection con = null;
            string connectionString = null;

            try
            {
                connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\1028270\\Desktop\\ancysunny\\FinTrustRepo\\FinTrustDSL\\DataBase\\FinTrustDB.mdf;Integrated Security=True";
                con = new SqlConnection(connectionString);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("******Error:DBHelper.cs:GetConnection" + ex.Message.ToString());
            }
            return con;

        }
    }
}
