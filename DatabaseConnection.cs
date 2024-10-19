using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsPOS
{
    public class DatabaseConnection
    {
        private static DatabaseConnection instance = null;

        private string connectionString = "Server=localhost,1400;Database=PointOfSale;User Id=sa;Password=S2V@Cs2JOWgQ;TrustServerCertificate=True;";

        private SqlConnection connection;

        private DatabaseConnection() {
            try { 
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch(Exception ex) {
                Console.WriteLine($"Errir al abrir la conexión: {ex.Message}");
            }
        }

        public static DatabaseConnection GetInstance() {
            if (instance == null) {
                instance = new DatabaseConnection();
            }
            return instance;
        }

        public SqlConnection GetConnection() {
            return connection;
        }
    }
}
