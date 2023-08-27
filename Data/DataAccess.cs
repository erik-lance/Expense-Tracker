using System;
using System.Data.SQLite;
using System.IO;
using System.Transactions;

namespace Expense_Tracker.Data
{
    public class DataAccess
    {
        private readonly string _connectionString;

        public DataAccess()
        {
            // Get Directory
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string dbFilePath = Path.Combine(baseDir, "Data", "expense_data.db");
            _connectionString = $"Data Source={dbFilePath};Version=3;";
        }

        public void InsertTransaction(Transaction transaction)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            using (var command = new SQLiteCommand(connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
