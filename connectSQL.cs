CREATE TABLE Login
(
    uname NVARCHAR(50),
    passwd NVARCHAR(50)
);

INSERT INTO Login (uname, passwd) VALUES
('PMD', 'pwd'),
('admin', 'Csharp'),
('Dipankar', 'Adhikary'),
('guest', 'visitor');







using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // Connection string to your SQL Server
        string connectionString = "Data Source=YourServer;Initial Catalog=YourDatabase;Integrated Security=True";

        // Prompt the user for username and password
        Console.Write("Enter Username: ");
        string username = Console.ReadLine();
        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        // Query to check if the provided username and password exist in the database
        string query = "SELECT COUNT(*) FROM Login WHERE uname = @username AND passwd = @password";

        using (SqlConnection connection = new SqlConnection(connectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            // Add parameters to the query to prevent SQL injection
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            connection.Open();
            int count = (int)command.ExecuteScalar(); // ExecuteScalar returns the count

            if (count > 0)
            {
                Console.WriteLine("Login successful");
            }
            else
            {
                Console.WriteLine("Login Not Successful");
            }
        }
    }
}
