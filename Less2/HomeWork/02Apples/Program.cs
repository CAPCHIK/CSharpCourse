

using System;

namespace ConsoleApplication
{
    public class Program
    {
		//Задача 2 о яблоках

    	//N школьников делят K яблок поровну, неделящийся остаток остается в корзинке. Сколько яблок останется в корзинке?
        //С клавиатуры вводятся N и K
    	//Пример входных данных:
    	//3
        //14
    	

    	//Выходные:
    	//2

        public static void Main(string[] args)
        {
            int k;
            int n;
            k = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(k%n);
            Console.ReadLine();
        }
    }
}
