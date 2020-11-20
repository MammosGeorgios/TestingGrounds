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
                command = new SqlCommand(sql,connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);

                adapter.Dispose();
                command.Dispose();
                connection.Close();


                for (int i = 0; i< ds.Tables[0].Rows.Count; i++)
                {
                    Console.WriteLine(ds.Tables[0].Rows[i].ItemArray[0] + " --- " + ds.Tables[0].Rows[i].ItemArray[1]);
                }



            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




        }
    }
}
