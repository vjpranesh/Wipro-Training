using System;
using System.Data;
using System.Data.SqlClient;

class SqlJoinDemo
{
    static void Main()
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NorthWind;Integrated Security=SSPI");

        SqlDataReader rdr = null;

        try
        {
            conn.Open();

            //INNER JOIN 

            string query = @"
                SELECT o.OrderID, c.ContactName, c.CompanyName, o.OrderDate
                FROM Orders o
                INNER JOIN Customers c ON o.CustomerID = c.CustomerID";

            SqlCommand cmd = new SqlCommand(query, conn);
            rdr = cmd.ExecuteReader();

            // Column widths
            int orderIdWidth = 10;
            int contactWidth = 25;
            int companyWidth = 35;
            int dateWidth = 15;

            // Print headers
            Console.WriteLine(
                "{0,-" + orderIdWidth + "}  {1,-" + contactWidth + "}  {2,-" + companyWidth + "}  {3,-" + dateWidth + "}",
                "Order ID", "Contact Name", "Company Name", "Order Date");


            // Print data
            while (rdr.Read())
            {
                int orderId = rdr.GetInt32(0);
                string contactName = rdr["ContactName"].ToString();
                string companyName = rdr["CompanyName"].ToString();
                string orderDate = Convert.ToDateTime(rdr["OrderDate"]).ToShortDateString();

                Console.WriteLine(
                    "{0,-" + orderIdWidth + "}  {1,-" + contactWidth + "}  {2,-" + companyWidth + "}  {3,-" + dateWidth + "}",
                    orderId, contactName, companyName, orderDate);
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
