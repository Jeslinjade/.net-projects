using System.Data;
using Microsoft.Data.SqlClient;

namespace AdoDotNetCoreCrudOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            try
            {

                string connectionString = "Server=KESHIKA\\MSSQLSERVER1;User Id=sa;Password=user123;Database=employeedb;Trusted_Connection=True;TrustServerCertificate=True";
                //Console.WriteLine("Connection successful");
                GetAllEmployees(connectionString);
                int employeeid = 1;
                GetEmployeeById(connectionString, employeeid);
                string firstname = "Jeslin";
                string lastname = "jade";
                string email = "kesh3keshika@gmail.com";
                string street = "Dhamodaran nagar"; 
                string city = "Thoothukudi";
                string states = "Tamil Nadu";
                string postalcode = "628003";
                CreateEmployeeWithAddress(connectionString, firstname, lastname, email, street, city, states, postalcode);
                employeeid = 3;
                firstname = "Rakesh";
                lastname = "sharma";
                email = "rakisharma@gmail.com";
                street = "jawaharlal nagar";
                city = "delhi";
                states = "north india";
                postalcode = "567338";

                int addressid = 3;
                UpdateEmployeeWithAddress(connectionString, employeeid, firstname, lastname, email, street, city, states, postalcode, addressid);
                employeeid = 3;
                DeleteEmployee(connectionString, employeeid);
            }
            catch (Exception ex) {
                Console.WriteLine($"Something went wrong:{ex.Message}");
            }

        }
        static void GetAllEmployees(string connectionString) {
            Console.WriteLine("GetAllEmployees Stored Procedure Called");
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                SqlCommand command = new SqlCommand("GetAllEmployees", connection);
                command.CommandType=CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"employeeid:{reader["employeeid"]},FirstName:{reader["firstname"]},LastName:{reader["lastname"]},Email:{reader["email"]},");
                    Console.WriteLine($"Address:{reader["street"]},{reader["city"]},{reader["states"]},{reader["postalcode"]}\n");
                }
                reader.Close();
                connection.Close();
            }
        }
        static void GetEmployeeById(string connectionString,int employeeId)
        {
            Console.WriteLine("GetEmployeeById Stored Procedure Called");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("GetEmployeeById", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@employeeid",employeeId);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"FirstName:{reader["firstname"]},LastName:{reader["lastname"]},Email:{reader["email"]},");
                    Console.WriteLine($"Address:{reader["street"]},{reader["city"]},{reader["states"]},{reader["postalcode"]}\n");
                }
                reader.Close();
                connection.Close();
            }
        }
        static void CreateEmployeeWithAddress(string connectionString, string firstname, string lastname, string email, string street, string city, string states, string postalcode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("CreateEmployeeWithAddress Stored Procedure Called");
                SqlCommand command = new SqlCommand("CreateEmployeeWithAddress", connection);
                command.CommandType = CommandType.StoredProcedure;
                // Add parameters for Employee and Address

                command.Parameters.AddWithValue("@firstname", firstname);
                command.Parameters.AddWithValue("@lastname", lastname);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@street", street);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@states", states);
                command.Parameters.AddWithValue("@postalcode", postalcode);
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Employee and Address created successfully.");
                connection.Close();
            }
        }
        static void UpdateEmployeeWithAddress(string connectionString, int employeeid, string firstname, string lastname, string email, string street, string city, string states, string postalcode, int addressid)

        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("UpdateEmployeeWithAddress Stored Procedure Called");
                SqlCommand command = new SqlCommand("UpdateEmployeeWithAddress", connection);
                command.CommandType = CommandType.StoredProcedure;
                // Add parameters for Employee and Address
                command.Parameters.AddWithValue("@employeeid", employeeid);
                command.Parameters.AddWithValue("@firstname", firstname);
                command.Parameters.AddWithValue("@lastname", lastname);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@street", street);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@states", states);
                command.Parameters.AddWithValue("@postalcode", postalcode);
                command.Parameters.AddWithValue("@addressid", addressid);
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Employee and Addressesiupdated successfully.");
                connection.Close();
            }
        }
        static void DeleteEmployee(string connectionString, int employeeid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine(value: "Delete Employee Stored Procedure Called");
                SqlCommand command = new SqlCommand("DeleteEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;
                // Add parameter for EmployeeID
                command.Parameters.AddWithValue("@employeeid", employeeid);
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine(value: "Employee and their Address deleted successfully.");
                }
                else
                {
                    Console.WriteLine(value: "Employee not found.");
                }
                connection.Close();

            }
        }
    }
}
