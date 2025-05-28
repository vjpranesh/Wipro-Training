//Dsiplay Total Sales by Category (GROUP BY + Aggregation)

using System;
using System.Data;
using System.Data.SqlClient;

class TotalSalesByCategory
{
    static void Main()
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NorthWind;Integrated Security=True");
        try
        {
            //open the connection 
            conn.Open();

            //pass the connection to command 
            string query = @"SELECT P.CategoryID, SUM(OD.UnitPrice * OD.Quantity) AS TotalSales
                           FROM [Order Details] OD
                           INNER JOIN Products P ON OD.ProductID = P.ProductID
                           GROUP BY P.CategoryID";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();

            adapter.Fill(table);

            foreach (DataRow row in table.Rows) 
            {
                int categoryId = Convert.ToInt32(row["CategoryID"]);
                decimal totalSales = Convert.ToDecimal(row["TotalSales"]);

                Console.WriteLine($"CategoryID: {categoryId}, Total Sales:{totalSales:C}");
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