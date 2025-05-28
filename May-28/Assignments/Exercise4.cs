//Update Employee Title (Parameter binding)

using System;
using System.Data.SqlClient;

class UpdateEmployee
{
    static void Main()
    {
        Console.WriteLine("Enter EmployeeID:");
        int employeeId = int.Parse(Console.ReadLine());

        Console.Write("Enter new Title:");
        string newTitle = Console.ReadLine();

        UpdateEmployeeTitle(employeeId, newTitle);
    }

    static void UpdateEmployeeTitle(int employeeId, string newTitle)
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NorthWind;Integrated Security=SSPI");
      

        try
        {
            //open the connection 
            conn.Open();

            //pass the connection to command 
            string query = @"UPDATE Employees   SET Title = @Title WHERE EmployeeID = @EmployeeID";
                           
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Title", newTitle);
            cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
            

            //get query results
            int rowsAffected = cmd.ExecuteNonQuery();
            Console.WriteLine(rowsAffected > 0 ? "Employee title updated sucessfully" : "Update failed.Employee not found");
         
            
    
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