using System;

namespace ConsoleApplication
{
    public class Program
    {


    	//Задача 7, анализ данных

    	//Входные данные
		//Вводится число N, а затем N чисел.

		//Выходные данные
		//Подсчитайте и выведите, сколько среди данных N чисел, крвтных трем.

		//Примеры
		//входные данные
		//3
		//1
		//2
		//3
		//выходные данные
		//1


		//входные данные
		//4
		//9
		//0
		//8
		//1
		//выходные данные
		//2
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
			int count = 0;
			for(int i = 0 ; i < N ; i++ ){

				int a = int.Parse(Console.ReadLine());

				if(a % 3 == 0){
					count++;
				}

			}	
			Console.WriteLine(count);		
        }
    }
}
