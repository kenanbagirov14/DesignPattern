
//Abstract Product
//Concrete Product
class MsSqlCommand : ACommand
{
    public override void Execute(string query)
    {
        Console.WriteLine(query);
    }
}
