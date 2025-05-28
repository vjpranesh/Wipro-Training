//Join Orders and Customers (INNER JOIN)

using System;
using System.Data.SqlClient;

class JoinOrdersCustomers
{
    static void DisplayOrderDetails()
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NorthWind;Integrated Security=True");
        try
        {
            //open the connection 
            conn.Open();

            //pass the connection to command INNER JOIN
            string query = @"SELECT Orders.OrderID,Customers.CompanyName,Orders.OrderDate FROM Orders
                           INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID";

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader rdr = null;

            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                int orderId = (int)rdr["OrderID"];
                string companyName = rdr["CompanyName"].ToString();
                DateTime orderDate = (DateTime)rdr["OrderDate"];


                //get query results
                Console.WriteLine($"OrderID: {orderId}, CompanyName: {companyName},{orderDate.ToShortDateString()}");
            }
            

        }
        catch (Exception ex) 
        {
            Console.WriteLine(" error occured: " + ex.Message);

        }
        finally
        {
            
            //close the connection
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
    static void Main()
    {
        DisplayOrderDetails();
    }   
}