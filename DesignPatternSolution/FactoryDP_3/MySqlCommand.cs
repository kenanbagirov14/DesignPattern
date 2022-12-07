
//Abstract Product
//Concrete Product
class MySqlCommand : Command
{
    public override void Execute(string query)
    {
        Console.WriteLine(query);
    }
}
