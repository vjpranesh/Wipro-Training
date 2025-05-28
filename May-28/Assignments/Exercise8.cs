//Dsiplay Total Sales by Category (GROUP BY + Aggregation)

using System;
using System.Data;
using System.Data.SqlClient;

class ExecuteStoredProcedure
{
    static void GetCustomerOrderHistory(string customerId)
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NorthWind;Integrated Security=True");
        try
        {
            //open the connection 
            conn.Open();

            //pass the connection to command 
            SqlCommand cmd = new SqlCommand("CustOrderHist", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CustomerID", customerId);

            SqlDataReader rdr = cmd.ExecuteReader();

            Console.WriteLine("Product Name\tTotal");

            while (rdr.Read())
            {
                string productName = rdr["ProductName"].ToString();
                int total = Convert.ToInt32(rdr["Total"]);

                
                Console.WriteLine($"{productName}\t{total}");
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
        //get results
        Console.Write("Enter CustomerID:");
        string customerId = Console.ReadLine();

        GetCustomerOrderHistory (customerId);
    }
    
}