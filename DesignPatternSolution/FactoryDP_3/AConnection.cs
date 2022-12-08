
//Abstract Product
abstract class AConnection
{
    public abstract bool Connect();
    public abstract bool DisConnect();
    abstract public ConnectionState State { get; set; }

}
