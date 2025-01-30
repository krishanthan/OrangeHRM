using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.DataBase
{
    public class DatabaseTest
    {
        private string masterConnectionString = "Server=KRISHANTHAN\\SQLEXPRESS;Database=OrangeHRM;Trusted_Connection=True;TrustServerCertificate=True";

        public void TestCreateDatabase()
        {
            string databaseName = "OrangeHRM";

            using (SqlConnection connection = new SqlConnection(masterConnectionString))
            {
                string createDbQuery = $"CREATE DATABASE [{databaseName}]";

                SqlCommand command = new SqlCommand(createDbQuery, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    // Assert: Check if the database is created by attempting to connect to it
                    string testConnectionString = $"Server=KRISHANTHAN\\SQLEXPRESS;Database=OrangeHRM;Trusted_Connection=True;TrustServerCertificate=True";
                    using (SqlConnection testConnection = new SqlConnection(testConnectionString))
                    {
                        testConnection.Open();
                        Assert.IsTrue(testConnection.State == System.Data.ConnectionState.Open, "Database creation failed.");
                    }
                }
                catch (SqlException ex)
                {
                    Assert.Fail($"Database creation failed with error: {ex.Message}");
                }
                finally
                {
                    // Cleanup: Drop the database if it was created
                    string dropDbQuery = $"DROP DATABASE IF EXISTS [{databaseName}]";
                    command = new SqlCommand(dropDbQuery, connection);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
    

