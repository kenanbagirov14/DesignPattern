//Database msSQL = new();
//msSQL.Connection = new();
//msSQL.Connection.ConnectionString = "...";
//msSQL.Command = new();

//var result = msSQL.Connection.Connect();
//if (result && msSQL.Connection.State == ConnectionState.Open)
//{
//    msSQL.Command.Execute("Select * from ....");
//}
//msSQL.Connection.Disconnect();


//Database oracle = new();
//oracle.Connection = new();
//oracle.Connection.ConnectionString = "...";
//oracle.Command = new();



//Cretor
class DatabaseCreator
{
    AbstractConnection _connection;
    AbstractCommand _command;

    public Database Create(DatabaseFactory databaseFactory)
    {
        _connection = databaseFactory.CreateConnection();
        _command = databaseFactory.CreateCommand();

        var TAW = databaseFactory.GetType().Name;
        var TA = databaseFactory.GetType().Name.Replace("DatabaseFactory", "");
        Database db = new Database()
        {
            Command = _command,
            Connection = _connection,
            Type = (DatabaseType)Enum.Parse(typeof(DatabaseType), databaseFactory.GetType().Name.Replace("DatabaseFactory", ""))
        };

        return db;
    }
}