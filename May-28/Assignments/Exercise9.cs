//Simulate Transaction - Insert order and details

using System;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

class Transaction
{
    static void Main()
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NorthWind;Integrated Security=True");

        SqlTransaction transaction = null;
        try
        {
            //open the connection 
            conn.Open();

            //
            transaction = conn.BeginTransaction();


            //Insert into Orders
            string insertOrderQuery = @"INSERT INTO Orders (CustomerID,OrderDate,ShipCountry)
                                      VALUES (@CustomerID, @OrderDate, @ShipCountry);
                                      SELECT SCOPE_IDENTITY();";

            SqlCommand orderCmd = new SqlCommand(insertOrderQuery, conn, transaction);
            orderCmd.Parameters.AddWithValue("@CustomerID", "ALFKI");
            orderCmd.Parameters.AddWithValue("@OrderDate",DateTime.Now);
            orderCmd.Parameters.AddWithValue("@ShipCountry", "USA");

            int newOrderId = Convert.ToInt32(orderCmd.ExecuteScalar());


            //Insert into OrderDetails
            string insertDetailQuery = @"INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice,Quantity,Discount)
                                       VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount);";

            SqlCommand detailCmd = new SqlCommand(insertDetailQuery, conn, transaction);
            detailCmd.Parameters.AddWithValue("@OrderID", newOrderId);
            detailCmd.Parameters.AddWithValue("@ProductID", 1);
            detailCmd.Parameters.AddWithValue("@UnitPrice", 18.00m);
            detailCmd.Parameters.AddWithValue("@Quantity", 2);
            detailCmd.Parameters.AddWithValue("@Discount", 0.0f);

            detailCmd.ExecuteNonQuery();
            
            //commit 
            transaction.Commit();
            Console.WriteLine("Transaction committed successfully");
        }
        catch (Exception ex) 
        {
            Console.WriteLine(" error occured: " + ex.Message);
            

            //rollback
            if (transaction != null)
            {
                transaction.Rollback();
                Console.WriteLine("Transaction rolled back");
            }

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