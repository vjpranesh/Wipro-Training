//SqlDataAdapater + Dataset 

using System;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

class Disconnected
{
    static void Main()
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NorthWind;Integrated Security=True");

      
        try
        {
            //open the connection 
            conn.Open();

            string query = "SELECT * FROM Products WHERE UnitsInStock > 20";

            //dataset
            DataSet dataset = new DataSet();

            //SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

            //Load the products
            adapter.Fill(dataset, "Products");

            //results
            Console.WriteLine("ProductID\tProductName\tUnitsInStock");

            foreach (DataRow row in dataset.Tables["Products"].Rows)
            {
                Console.WriteLine($"{row["ProductID"]}\t\t{row["ProductName"]}\t\t{row["UnitsInStock"]}");
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
    
    
}