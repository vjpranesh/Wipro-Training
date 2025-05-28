using System;
using System.Data;
using System.Data.SqlClient;

class DeleteProduct
{
    static void Execute(int productId)
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NorthWind;Integrated Security=True");

        try
        {
            // Open the connection 
            conn.Open();

           
            string query = "DELETE FROM Products WHERE ProductID = @ProductID";

           
            SqlCommand cmd = new SqlCommand(query, conn);

            // Add the parameter
            cmd.Parameters.AddWithValue("@ProductID", productId);

            
            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                Console.WriteLine($"Product with ID {productId} deleted successfully.");
            }
            else
            {
                Console.WriteLine($"No product found with ID {productId}.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred: " + ex.Message);
        }
        finally
        {
            // Close the connection
            if (conn != null)
            {
                conn.Close();
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter ProductID to delete: ");
        if (int.TryParse(Console.ReadLine(), out int productId))
        {
            Execute(productId);
        }
        else
        {
            Console.WriteLine("Invalid ProductID.");
        }
    }
}
