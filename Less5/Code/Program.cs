using System;

class Program
{
    static void Main(string[] args)
    {
        Person[] people = new Person[5];
        people[0] = new Employee("Linda");
        people[1] = new Employee("LOLMan");
        people[2] = new Employee("Kostya");
        people[3] = new Person("Barat");
        people[4] = new Person("Masha");

        for (int i = 0; i < 5; i++)
        {
            people[i].Say();
        }
        var r = people[0];

        Person p = new Employee("Sten");
        System.Console.WriteLine(p.Name);
    }
}
