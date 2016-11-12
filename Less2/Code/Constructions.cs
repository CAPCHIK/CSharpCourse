using System;

class Constructions
{
    static void ExamplesIf(string[] args)
    {

        string input = Console.ReadLine();
        int a = int.Parse(input);

        if (a == 0)
        {
            Console.WriteLine("Число равно нулю");
        }
        if (a < 0)
        {
            Console.WriteLine("Число меньше нуля");
        }
        if (a > 0)
            Console.WriteLine("Число больше нуля");            
                






        string myStr;
        Console.WriteLine("Введите строку: ");

        myStr = Console.ReadLine();

        if (myStr.Length < 5)
        {
            Console.WriteLine("В данной строке меньше 5 символов");
        }
        else if ((myStr.Length >= 5) && (myStr.Length <= 12))
        {
            Console.WriteLine("В данной строке {0} символов", myStr.Length);
        }
        else
        {
            Console.WriteLine("В данной строке больше 12 символов");
        }

        Console.ReadLine();

    }
}