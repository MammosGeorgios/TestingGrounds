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
            //SelectCustomers();

            //InsertCategory();

            //DeleteCategory();

            Procedure_CustOrderHist();
            Object obj = new Object();

        }

        private static void Procedure_CustOrderHist()
        {
            using (SqlConnection conn = new SqlConnection("Server =.; Database = Northwind; Trusted_Connection = True;"))
            {

                conn.Open();
                using (SqlCommand cmd = new SqlCommand("CustOrderHist", conn))
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    string custID = "CACTU";
                    cmd.Parameters.Add(new SqlParameter("@CustomerID", custID));

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {

                        if (rdr != null)
                        {
                            while (rdr.Read())
                            {
                                Console.WriteLine("\t{0,-30}\t{1}", rdr[0], rdr[1]);
                            }
                        }
                    }


                }
            }
        }

        private static void DeleteCategory()
        {
            using (SqlConnection conn = new SqlConnection("Server =.; Database = Northwind; Trusted_Connection = True;")){
                
                conn.Open();
                string deleteString = "DELETE FROM Categories WHERE CategoryName = 'Miscellaneous'";
                using (SqlCommand cmd = new SqlCommand(deleteString, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static void InsertCategory()
        {
            SqlConnection conn = new SqlConnection("Server =.; Database = Northwind; Trusted_Connection = True;");
            
            conn.Open();
            string insertString = "INSERT INTO Categories (CategoryName, Description) VALUES ('Miscellaneous', 'Whatever, it doesnt matter')";
            SqlCommand cmd = new SqlCommand(insertString, conn);
            cmd.ExecuteNonQuery();
        }

        private static void SelectCustomers()
        {
            SqlConnection conn = new SqlConnection("Server =.; Database = Northwind; Trusted_Connection = True;");
            SqlDataReader rdr = null;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", conn);
                rdr = cmd.ExecuteReader();
                if (rdr != null)
                {
                    while (rdr.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}", rdr[0], rdr[1], rdr[2]);
                    }
                }



                
            }
            catch (Exception ex)
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
