using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace WinformsPOS
{
    public partial class Menu : Form
    {
        private SqlConnection connection = DatabaseConnection.GetInstance().GetConnection();
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string query = "SELECT * FROM Products";

            SqlCommand command = new SqlCommand(query, this.connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    MessageBox.Show($"{reader["ProductId"]}, {reader[1]}, {reader[2]}, {reader[3]}");
                }
            }
        }

        private void btnGetProductosData_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Products";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, this.connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                productsTable.DataSource = dataTable;

                MessageBox.Show("Datos cargados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
                throw;
            }

            
        }
    }
}
