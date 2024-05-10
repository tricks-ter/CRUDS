using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form2 : Form
    {
        private const string connectionString = "Data Source=DESKTOP-L2B1K6F\\SQLEXPRESS;Integrated Security=True;Encrypt=False";
        private string databaseName = "NewUser";

        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = user2.Text;
            string updateUsername = update_username.Text;
            string updatePassword = update_password.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a username to update.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString + $";Initial Catalog={databaseName}"))
            {
                try
                {
                    connection.Open();

                    if (string.IsNullOrWhiteSpace(updateUsername) && string.IsNullOrWhiteSpace(updatePassword))
                    {
                        MessageBox.Show("Both update fields are empty. Nothing to update.");
                        return;
                    }

                    if (!string.IsNullOrWhiteSpace(updateUsername))
                    {
                        string queryUsername = "UPDATE users SET Username = @UpdateUsername WHERE Username = @Username";
                        SqlCommand commandUsername = new SqlCommand(queryUsername, connection);
                        commandUsername.Parameters.AddWithValue("@UpdateUsername", updateUsername);
                        commandUsername.Parameters.AddWithValue("@Username", username);
                        int rowsAffectedUsername = commandUsername.ExecuteNonQuery();
                        if (rowsAffectedUsername > 0)
                        {
                            MessageBox.Show("Username updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Username not found!");
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(updatePassword))
                    {
                        string queryPassword = "UPDATE users SET Password = @UpdatePassword WHERE Username = @Username";
                        SqlCommand commandPassword = new SqlCommand(queryPassword, connection);
                        commandPassword.Parameters.AddWithValue("@UpdatePassword", updatePassword);
                        commandPassword.Parameters.AddWithValue("@Username", username);
                        int rowsAffectedPassword = commandPassword.ExecuteNonQuery();
                        if (rowsAffectedPassword > 0)
                        {
                            MessageBox.Show("Password updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Username not found!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating user: {ex.Message}");
                }
            }
        }
    }
}
