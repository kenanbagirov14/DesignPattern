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



//Concrete Product
class Connection : AbstractConnection
{
    string _connectionString;
    public Connection() { }
    public Connection(string connectionString) 
    {
        _connectionString = connectionString;
    }
    public override string ConnectionString { get => _connectionString; set => _connectionString = value; }
    public override ConnectionState State { get; set; }
    public override bool Connect()
    {
        //...işlemler yürütülüyor...
        State = ConnectionState.Open;
        return true;
    }
    public override bool Disconnect()
    {
        //..işlemler yürütülüyor...
        State = ConnectionState.Close;
        return true;
    }
}
