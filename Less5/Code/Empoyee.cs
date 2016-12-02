public class Employee : Person
{
    public override void Say()
    {
        base.Say();
        System.Console.WriteLine("I am Employee " + name);
    }

    public Employee(string name) : base(name)
    {}

    public void Fire()
    {
        System.Console.WriteLine("I'm fired :'(");
    }
}