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
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT ContactName, City, CompanyName FROM Customers", conn);
            rdr = cmd.ExecuteReader();

            Console.WriteLine("Customer List:\n");

            while (rdr.Read())
            {
                string contactName = rdr["ContactName"].ToString();
                string city = rdr["City"].ToString();
                string companyName = rdr["CompanyName"].ToString();

                Console.WriteLine($"- ContactName: {contactName} City: {city} CompanyName: {companyName}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
            if (rdr != null)
                rdr.Close();

            if (conn != null)
                conn.Close();
        }
    }
}




