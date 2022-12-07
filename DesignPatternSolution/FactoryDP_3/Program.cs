DatabaseCreator creator = new DatabaseCreator();
Database mysql = creator.Create(new MySqlDatabaseFactory());
Database mssql = creator.Create(new MsSqlDatabaseFactory());

Console.WriteLine();
//Abstract Product
enum ConnectionState
{
    Open, Close
}
