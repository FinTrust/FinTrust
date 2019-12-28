using System;
using System.Collections.Generic;
using System.Text;
using FinTrustDTO.DataTransferObject;
using FinTrustDSL.DataServiceLayer;

namespace FinTrustBLL.BusinessLayer
{
    public class FinTrustBL
    {
		public static int InsertTransactionDetails(Transaction objTransaction)
		{
			int output = 0;
			try
			{
				output = FinTrustDL.InsertTransactionDetails(objTransaction);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error : FinTrustBL : InsertTransactionDetails()" + ex.Message.ToString());
			}
			return output;
		}
	}
}
