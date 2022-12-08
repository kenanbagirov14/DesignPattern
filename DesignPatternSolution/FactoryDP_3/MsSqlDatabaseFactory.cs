
//Abstract Product
//Concrete Factory
class MsSqlDatabaseFactory : ADatabaseFactory
{
    public override ACommand CreateCommand()
    {
        MsSqlCommand command = new();
        return command;
    }

    public override AConnection CreateConnection()
    {
        MsSqlConnection connection = new();
        //connection string set
        return connection;
    }
}
