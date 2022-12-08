
//Abstract Product
//Creator
class DatabaseCreator
{
    public Database Create(ADatabaseFactory databaseFactory)
    {
        return new Database()
        {
            Command = databaseFactory.CreateCommand(),
            Connection = databaseFactory.CreateConnection()
        };
    }
}
