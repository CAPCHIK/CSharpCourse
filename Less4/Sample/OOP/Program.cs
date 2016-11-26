using System;


namespace Less4.Sample.OOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Section EmptyClass
            /*            
            //Мы имеем возможность создавать переменные типа<Наш класс>
            EmptyClass newVar = new EmptyClass();
            //теперь newVar хранит !ссылку! на только что созданный объект типа EmptyClass
            
            //Можем вызвать е же методы, что и у любого другого объекта, такие как ToString()
            newVar.ToString();
            */

            //Section Caculator
            Calculator calc = new Calculator();

            int summa = calc.Sum(12, 41);
            Console.WriteLine(summa);
            
            double devide = calc.Divide(23, 3);
            //Деление целых чисел
            Console.WriteLine(devide);

            //Деление дробных чиселб в том же методе!
            Console.WriteLine(calc.Divide(3.6, 1.3));
            //Можем вызвать один метод, с разными параметрами!
            calc.ShowResult(summa);
            calc.ShowResult(devide);


        }
    }
}
