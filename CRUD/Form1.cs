using System;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        private const string connectionString = "Data Source=DESKTOP-L2B1K6F\\SQLEXPRESS;Integrated Security=True;Encrypt=False";
        private string databaseName = "NewUser";

        public Form1()
        {
            InitializeComponent();
            CreateDatabaseIfNotExists();
            CreateTableIfNotExists();
        }

        private void CreateDatabaseIfNotExists()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string createDbQuery = $"IF NOT EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = '{databaseName}') " +
                    $"CREATE DATABASE {databaseName}";
                SqlCommand command = new SqlCommand(createDbQuery, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating database: {ex.Message}");
                }
            }
        }

        private void CreateTableIfNotExists()
        {
            using (SqlConnection connection = new SqlConnection(connectionString + $";Initial Catalog={databaseName}"))
            {
                string createTableQuery = $"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'users') " +
                    "CREATE TABLE users (Id INT PRIMARY KEY IDENTITY, Username NVARCHAR(50), Password NVARCHAR(50))";
                SqlCommand command = new SqlCommand(createTableQuery, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating table: {ex.Message}");
                }
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string username = user.Text;
            string password = pass.Text;

            using (SqlConnection connection = new SqlConnection(connectionString + ";Initial Catalog=YourDatabaseName"))
            {
                string query = "INSERT INTO users (Username, Password) VALUES (@Username, @Password)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("User created successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating user: {ex.Message}");
                }
            }

            ClearTextBoxes();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string usernameToSearch = search_user.Text;

            using (SqlConnection connection = new SqlConnection(connectionString + ";Initial Catalog=YourDatabaseName"))
            {
                string query = "SELECT * FROM users WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", usernameToSearch);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show($"User found! Username: {reader["Username"]}, Password: {reader["Password"]}");
                    }
                    else
                    {
                        MessageBox.Show("User not found!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error searching for user: {ex.Message}");
                }
            }

            search_user.Clear();
        }

        



        private void btn_delete_Click(object sender, EventArgs e)
        {
            string usernameToDelete = delete_user.Text;

            using (SqlConnection connection = new SqlConnection(connectionString + ";Initial Catalog=YourDatabaseName"))
            {
                string query = "DELETE FROM users WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", usernameToDelete);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("User not found!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting user: {ex.Message}");
                }
            }

            delete_user.Clear();
        }

        private void ClearTextBoxes()
        {
            user.Clear();
            pass.Clear();
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
