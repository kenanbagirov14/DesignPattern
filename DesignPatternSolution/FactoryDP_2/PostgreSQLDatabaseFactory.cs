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



//Concrete Factory
class PostgreSQLDatabaseFactory : DatabaseFactory
{
    public override AbstractCommand CreateCommand()
    {
        Command command = new Command();
        return command;
    }

    public override AbstractConnection CreateConnection()
    {
        Connection connection = new Connection();
        connection.ConnectionString = "PostgreSQL connection string";
        return connection;
    }
}
