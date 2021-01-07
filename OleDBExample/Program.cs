using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OleDBExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // OleDbExample();

        }

        private static void OleDbExample()
        {

            // The connection string assumes that the Access 
            // Northwind.mdb is located in the c:\Data folder.
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + "C:\\Users\\Mammbos 2020\\Documents\\Northwind.mdb;User Id=admin;Password=;";


            // Provide the query string with a parameter placeholder.string 
            string queryString = "SELECT ProductID, UnitPrice, ProductName from products " + "WHERE UnitPrice > ? " + "ORDER BY UnitPrice DESC;";
            // Specify the parameter value.
            int paramValue = 5;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.Parameters.AddWithValue("@pricePoint", paramValue);
                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}", reader[0], reader[1], reader[2]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }
    }
}
