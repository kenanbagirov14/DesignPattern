namespace ObjectClone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() {Id=1,Name="Kenan",Age=33 };
            Person p1 = (Person)p.Clone();
            Person p2 = p.Copy1();
            Person p3 = p.Copy2();
            Person p4 = p.Copy3();

            Console.WriteLine(p.Equals(p1));
            Console.WriteLine(p.Equals(p2));
            Console.WriteLine(p.Equals(p3));
            Console.WriteLine(p.Equals(p4));
            Console.Read();
        }
    }

    public class Person : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int  Age { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Person Copy1()
        {
            var p1 = new Person();
            p1.Id = this.Id+1;
            p1.Name = this.Name;    
            p1.Age = this.Age;

            return p1;
        }

        public Person Copy2()
        {
            var p2 = (Person)this.MemberwiseClone();

            return p2;
        }

        public Person Copy3()
        {
            var p2 = new Person();
            p2 = this;

            return p2;
        }
    }
}