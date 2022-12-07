
//Abstract Product
//Concrete Product
class MsSqlCommand : Command
{
    public override void Execute(string query)
    {
        Console.WriteLine(query);
    }
}
