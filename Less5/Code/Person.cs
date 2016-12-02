public class Person
{
    protected string name;
    public string Name
    {
        get {return name;}
        set {name = value;}
    }

    public Person(string _name)
    {
        name = _name;
    }

    public virtual void Say()
    {
        System.Console.WriteLine("I am Person, " + name);
    }
}