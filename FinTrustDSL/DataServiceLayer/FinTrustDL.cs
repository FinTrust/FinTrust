using System;
using System.Collections.Generic;
using System.Text;
using FinTrustDTO.DataTransferObject;
using FinTrustDSL.Helper;
using System.Data.SqlClient;

namespace FinTrustDSL.DataServiceLayer
{
    public class FinTrustDL
    {
		public static int InsertTransactionDetails(Transaction objTransaction)
		{
			int output = 0;
			string sql = "";
			SqlConnection con = null;
			SqlCommand cmd = null;
			try
			{
				sql = "insert into transaction_table(transactionId,transactionType,transactionDate,transactionAmount,accountNumber,balanceAmount) values(";
				sql = sql + "'" + objTransaction.TransactionId + "',";
				sql = sql + "'" + objTransaction.TransactionType + "',";
				sql = sql + "'" + objTransaction.TransactionDate + "',";
				sql = sql + "" + objTransaction.TransactionAmount + ",";
				sql = sql + "'" + objTransaction.AccountNumber + "',";
				sql = sql + "" + objTransaction.BalanceAmount + ")";

				con = DBHelper.GetConnection();
				con.Open();
				cmd = new SqlCommand(sql, con);
				output = cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.Out.WriteLine("Error : FinTrustDL : InsertTransactionDetails() " + ex.Message.ToString());
			}
			finally
			{
				con.Close();
				cmd.Dispose();
			}
			return output;
		}

	}
}
