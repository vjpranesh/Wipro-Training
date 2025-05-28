using System;
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
            //open the connection 
            conn.Open();

            //pass the connection to command 
            SqlCommand cmd = new SqlCommand("Select CustomerID,CompanyName,Country from Customers", conn);

            //get query results
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string customerId = rdr["CustomerID"].ToString();
                string companyName = rdr["CompanyName"].ToString();
                string country = rdr["Country"].ToString();

                Console.WriteLine($"CustomerID; {customerId},CompanyName: {companyName},Country: {country}");
            }
        }
        catch (Exception ex) 
        {
            Console.WriteLine(" error occured: " + ex.Message);

        }
        finally
        {
            //close the reader 
            if (rdr != null)
            {
                rdr.Close();
            }
            
            //close the connection
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}