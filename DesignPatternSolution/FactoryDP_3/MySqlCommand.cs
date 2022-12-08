
//Abstract Product
//Concrete Product
class MySqlCommand : ACommand
{
    public override void Execute(string query)
    {
        Console.WriteLine(query);
    }
}
