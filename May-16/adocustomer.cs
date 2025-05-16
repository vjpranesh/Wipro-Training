using System;
using System.Data;
using System.Data.SqlClient;

class SqlConnectionDemo
{
    static void Main()
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NorthWind;Integrated Security=SSPI");
        SqlDataReader rdr = null;

        try
        {
            open the connection
            conn.Open();

            pass the connection to a command object
            SqlCommand cmd = new SqlCommand("Select * from Customers", conn);

            use the connection
            get query results

            rdr = cmd.ExecuteReader();

            print the customerid of each record
            while (rdr.Read())
            {
                Console.WriteLine(rdr[1]);
            }
        }
        catch
        {

        }
        finally
        {
            close the reader
            if (rdr != null)
            {
                rdr.Close();
            }

            close the connection
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}