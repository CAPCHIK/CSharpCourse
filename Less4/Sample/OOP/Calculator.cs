using System;
namespace Less4.Sample.OOP
{
    //Класс, имитирующий калькулятор
    //Он содержит некоторые методы
    //показывает возмжность перегрузки методов по передаваемому аргументу


    // А как еще можно перегрузить метод? Напиши мне ответ на этот вопрос!
    public class Calculator
    {
        //Метод класса.
        public int Sum(int a, int b)
        {
            return a + b;
        }
        

        //Деление first на second
        public double Divide(double first, double second)
        {
            return first / second;
        }
        //Перегруженый метод для деления, для целых чисел
        public double Divide(int first, int second)
        {
            return Divide((double)first, (double)second);
        }


        //Метод для вывода результата
        public void ShowResult(int value)
        {
            Console.WriteLine("Релутьтат есть целое число: " + value);
        }
        //Перегруженный метод для вывода дробных чисел
        public void ShowResult(double value)
        {
            Console.WriteLine("Релутьтат есть дробное число: " + value);
        }
        //Таких перегруженных методов может быть много
        //Главное, чтобы типы входных параметров отличались.
        //Или их количество
    }
}