
//Abstract Product
//Concrete Factory
class MySqlDatabaseFactory : DatabaseFactory
{
    public override Command CreateCommand()
    {
        MySqlCommand command = new();
        return command;
    }

    public override Connection CreateConnection()
    {
        MySqlConnection connection = new();
        //connection string set
        return connection;
    }
}
