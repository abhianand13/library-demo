using LibraryDemo.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LibraryDemo.Service
{
    public class LibraryService : ILibraryService
    {
        private const string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryDemo;Integrated Security=True";

        public List<TransactionType> GetTransactionTypes()
        {
            List<TransactionType> transactionTypes = new List<TransactionType>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string commandText = "SELECT * FROM LibraryTransactionType";
                    SqlCommand cmd = new SqlCommand(commandText, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TransactionType transactionType = new TransactionType();
                            transactionType.Code = reader["Code"].ToString();
                            transactionType.Description = reader["Description"].ToString();
                            transactionTypes.Add(transactionType);
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                // TODO - Implement logging
            }

            return transactionTypes;
        }
    }
}
