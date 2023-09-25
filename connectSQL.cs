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
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseADODay28
{
    internal class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Console.WriteLine("Enter your Username: ");
                string username = Console.ReadLine();

                Console.WriteLine("Enter your Password: ");
                string password = Console.ReadLine();

                string cn = @"Data Source=DESKTOP-O7LF2JA;Initial Catalog=training;Integrated Security=True";



                SqlConnection connection = new SqlConnection(cn);

                connection.Open();

                string q = "Select count(*) from Login where uname=@username and passwd=@password";
                SqlCommand command = new SqlCommand(q, connection);

                command.Parameters.AddWithValue("username", username);
                command.Parameters.AddWithValue("password", password);

                int ch = (int)command.ExecuteNonQuery();
                if (ch > 0)
                {
                    Console.WriteLine("Login Successful.");

                }
                else
                {
                    Console.WriteLine("Login Not Successful.");
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            Console.ReadLine();
        }
    }

}
