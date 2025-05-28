//search orders by Customerid (parameterized query)

using System;
using System.Data.SqlClient;

class SqlConnectionDemo
{
    static void Main()
    {
        Console.WriteLine("Enter CustomerID:");
        string customerId = Console.ReadLine();
        GetOrdersByCustomer(customerId);
    }
    static void GetOrdersByCustomer(string customerId)
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NorthWind;Integrated Security=SSPI");
        SqlDataReader rdr = null;

        try
        {
            //open the connection 
            conn.Open();

            //pass the connection to command 
            SqlCommand cmd = new SqlCommand("SELECT OrderID,OrderDate,ShipCountry from Orders WHERE CustomerID = @CUSTOMERId", conn);

            cmd.Parameters.AddWithValue("@customerId", customerId);
         



            //get query results
            rdr = cmd.ExecuteReader();
            if (!rdr.HasRows)
            {
                Console.WriteLine("No orders found for CustomerID:" + customerId);
            }

            while (rdr.Read())
            {
                int orderId = (int)rdr["OrderID"];
                DateTime orderDate = (DateTime)rdr["OrderDate"];
                string shipCountry = rdr["ShipCountry"].ToString();

                Console.WriteLine($"OrderID: {orderId}, OrderDate: {orderDate},ShipCountry:{shipCountry}");
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