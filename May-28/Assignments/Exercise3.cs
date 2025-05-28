//Insert a New Product (ExecuteNonQuery)

using System;
using System.Data.SqlClient;

class InsertProduct
{
    
    static void InsertNewProduct(string productName, int supplierId, int categoryId, decimal unitPrice)
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NorthWind;Integrated Security=SSPI");
      

        try
        {
            //open the connection 
            conn.Open();

            //pass the connection to command 
            string query = @"INSERT INTO Products (ProductName, SupplierID, CategoryID, UnitPrice)
                              VALUES (@ProductName, @SupplierID, @CategoryID, @UnitPrice)";

            SqlCommand cmd = new SqlCommand(query, conn);



            cmd.Parameters.AddWithValue("@ProductName", productName);
            cmd.Parameters.AddWithValue("@SupplierID", supplierId);
            cmd.Parameters.AddWithValue("@CategoryID", categoryId);
            cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);

            //get query results
            int rowsAffected = cmd.ExecuteNonQuery();
            Console.WriteLine(rowsAffected > 0 ? "Product inserted successfully" : "Insert failed.No rows affected");
         
            
    
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
        InsertNewProduct("Test Product", 1, 1, 25);
    }
}