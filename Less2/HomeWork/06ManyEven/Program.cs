﻿using System;

namespace ConsoleApplication
{
    public class Program
    {
    	//Задача 6, список четных чисел
    	//Входные данные
		//Вводятся целые числа a и b. Гарантируется, что a не превосходит b

		//Выходные данные
		//Выведите (через пробел) все четные числа от a до b (включительно).

		//Примеры
		//входные данные
		//2
		//5
		
		//выходные данные
		//2 4 
        public static void Main(string[] args)
        {
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());

			for (int i = a ; i <= b; i++){
				if(i % 2 == 0){
					Console.WriteLine(i + " ");
				}
			}

        
        }
    }
}
