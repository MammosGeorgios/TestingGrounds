using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConnectingToDB
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlConnection conn = new SqlConnection("Server =.; Database = Northwind; Trusted_Connection = True;");
            SqlDataReader rdr = null;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customers",conn);
                rdr = cmd.ExecuteReader();
                if (rdr != null)
                {
                    while (rdr.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}",rdr[0],rdr[1],rdr[2]);
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (rdr != null) rdr.Close();
                if (conn != null) conn.Close();
            }
            

        }
    }
}
