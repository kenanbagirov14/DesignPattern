
//Abstract Product
//Concrete Factory
class MsSqlDatabaseFactory : DatabaseFactory
{
    public override Command CreateCommand()
    {
        MsSqlCommand command = new();
        return command;
    }

    public override Connection CreateConnection()
    {
        MsSqlConnection connection = new();
        //connection string set
        return connection;
    }
}
