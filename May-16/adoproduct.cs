using system.data.sqlclient;

class program
{
    static void main()
    {
        string connectionstring =
            "data source=(localdb)\\mssqllocaldb;initial catalog=northwind;"
            + "integrated security=true";

        //provide the query string with a parameter placeholder
        string querystring =
            "select productid, unitprice, productname from dbo.products "
            + "where unitprice > @pricepoint "
            + "order by unitprice desc;";

        // specify the parameter value
        int paramvalue = 5;

        //create and open the connection in a using block.this
        //ensures that all resources will be closed and disposed
        //when the code exists
        using (sqlconnection connection = new sqlconnection(connectionstring))
        {
            //create the command and parameter objects
            sqlcommand command = new sqlcommand(querystring, connection);
            command.parameters.addwithvalue("@pricepoint", paramvalue);

            try
            {
                connection.open();
                sqldatareader reader = command.executereader();
                while (reader.read())
                {
                    console.writeline("\t{0}\t{1}\t{2}",
                            reader[0], reader[1], reader[2]);
                }
                reader.close();
            }
            catch (exception ex)
            {
                console.writeline(ex.message);

                console.readline();
            }

        }
    }
