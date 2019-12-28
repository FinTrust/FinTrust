using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

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

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("******Error:DBHelper.cs:GetConnection" + ex.Message.ToString());
            }
            return con;

        }
    }
}
