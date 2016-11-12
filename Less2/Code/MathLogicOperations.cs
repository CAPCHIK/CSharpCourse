using System;

class MathLogicOperations
{
    static void Examples(string[] args)
    {
        //Умножение (И)
        int x1 = 2; //010
        int y1 = 5; //101
                    //000
        Console.WriteLine(x1 & y1); // выведет 0

        int x2 = 4; //100
        int y2 = 5; //101
                    //100

        Console.WriteLine(x2 & y2); // выведет 4
        
        //Сложение (ИЛИ)
        x1 = 2; //010
        y1 = 5; //101
                //111
        Console.WriteLine(x1|y1); // выведет 7 - 111
        
        
        x2 = 4; //100
        y2 = 5; //101
                //101
        Console.WriteLine(x2 | y2); // выведет 5 - 101

        //Исключяющее ИЛИ (XOR)
        int x = 45; // Значение, которое надо зашифровать - в двоичной форме 101101
        int key = 102; //Пусть это будет ключ - в двоичной форме 1100110
        int encrypt = x ^ key; //Результатом будет число 1001011 или 75
        Console.WriteLine("Зашифрованное число: " +encrypt);
 
        int decrypt = encrypt ^ key; // Результатом будет исходное число 45
        Console.WriteLine("Расшифрованное число: " + decrypt);



        //Отрицание (НЕ)
        x = 9;  //1001
                //0110
        Console.WriteLine(~x);

        //Сдвиг

        x = 4 << 1;
        //4 : 100
        //0000100
        //100 << 1
        //0001000
        //1000
        //x = 8

        x = 4 >> 1;
        //4 : 100
        //0000100
        //100 >> 1
        //0000010
        //10
        //x = 2
    }
}