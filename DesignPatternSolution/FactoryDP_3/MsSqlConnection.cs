
//Abstract Product
//Concrete Product
class MsSqlConnection : Connection
{
    public override ConnectionState State { get; set; }

    public override bool Connect()
    {
        Console.WriteLine("MsSqlConnection bağlantısı gerçekleştirildi.");
        State = ConnectionState.Open;
        return true;
    }

    public override bool DisConnect()
    {
        Console.WriteLine("MsSqlConnection bağlantısı koparıldı.");
        State = ConnectionState.Close;
        return true;
    }
}
