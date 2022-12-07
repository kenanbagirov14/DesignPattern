
//Abstract Product
//Creator
class DatabaseCreator
{
    public Database Create(DatabaseFactory databaseFactory)
    {
        return new Database()
        {
            Command = databaseFactory.CreateCommand(),
            Connection = databaseFactory.CreateConnection()
        };
    }
}
