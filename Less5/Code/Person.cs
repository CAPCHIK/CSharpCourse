public class Person
{
    protected string name;
    public string Name
    {
        get {return name;}
        set {name = value;}
    }

    public Person(string name)
    {
        this.name = name;
    }

    public virtual void Say()
    {
        System.Console.WriteLine("I am Person, " + name);
    }
}