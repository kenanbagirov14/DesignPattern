
//Abstract Product
//Abstract Factory
abstract class ADatabaseFactory
{
    public abstract AConnection CreateConnection();
    public abstract ACommand CreateCommand();
}
