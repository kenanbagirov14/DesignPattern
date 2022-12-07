
//Abstract Product
abstract class Connection
{
    public abstract bool Connect();
    public abstract bool DisConnect();
    abstract public ConnectionState State { get; set; }

}
