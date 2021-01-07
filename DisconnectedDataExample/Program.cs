using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DisconnectedDataExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // SelectCustomers();

            SelectCategoriesAndProducts();

        }

        private static void SelectCategoriesAndProducts()
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            //int i = 0;
            string connectionString = "Server=.; Database= Northwind; Trusted_Connection=True;";
            string sql = "SELECT Categories.CategoryName, Products.ProductName FROM Categories JOIN Products ON  Categories.CategoryID = Products.CategoryID";

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);

                adapter.Dispose();
                command.Dispose();
                connection.Close();

                Console.WriteLine($"{ds.Tables[0].Columns[0].ColumnName,-30}  {ds.Tables[0].Columns[1].ColumnName}\n");
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Console.WriteLine($"{ds.Tables[0].Rows[i].ItemArray[0],-30}  {ds.Tables[0].Rows[i].ItemArray[1]}");
                }





            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void SelectCustomers()
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            //int i = 0;
            string connectionString = "Server=.; Database= Northwind; Trusted_Connection=True;";
            string sql = "SELECT * FROM Customers";

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);

                adapter.Dispose();
                command.Dispose();
                connection.Close();


                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Console.WriteLine(ds.Tables[0].Rows[i].ItemArray[0] + " --- " + ds.Tables[0].Rows[i].ItemArray[1]);
                }





            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
