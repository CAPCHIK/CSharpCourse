﻿using System;

namespace ConsoleApplication
{
    public class Program
    {
        //Задача 14 про лабиринт

        //Требуется вычислить площадь комнаты в квадратном лабиринте.

        //Входные данные 
        //В первой строке  вводится число N – размер лабиринта (3 <= N <= 10). 
        //В следующих N строках задан лабиринт (‘.’ – пустая клетка, ‘*’ – стенка). 
        //И наконец, последняя строка содержит  два числа – номер строки и столбца клетки, находящейся в комнате,
        //площадь которой необходимо вычислить. 
        //Гарантируется, что эта клетка пустая и что лабиринт окружен стенками со всех сторон.
        
        //Выходные данные 
        //Требуется вывести единственное число – количество пустых клеток в данной комнате.

        //Примеры
        //Входные данные
        //5
        //*****
        //**..*
        //*.*.*
        //*..**
        //*****
        //2 4
        
        //Выходные данные
        //3

        //подсказка
        //https://vk.cc/5Rrx66
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
