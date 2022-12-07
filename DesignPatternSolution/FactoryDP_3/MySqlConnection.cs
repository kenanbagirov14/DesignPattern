
//Abstract Product
//Concrete Product
class MySqlConnection : Connection
{
    public override ConnectionState State { get; set; }

    public override bool Connect()
    {
        Console.WriteLine("MySqlConnection bağlantısı gerçekleştirildi.");
        State = ConnectionState.Open;
        return true;
    }

    public override bool DisConnect()
    {
        Console.WriteLine("MySqlConnection bağlantısı koparıldı.");
        State = ConnectionState.Close;
        return true;
    }
}
