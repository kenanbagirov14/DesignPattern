
//Abstract Product
//Concrete Factory
class MySqlDatabaseFactory : ADatabaseFactory
{
    public override ACommand CreateCommand()
    {
        MySqlCommand command = new();
        return command;
    }

    public override AConnection CreateConnection()
    {
        MySqlConnection connection = new();
        //connection string set
        return connection;
    }
}
