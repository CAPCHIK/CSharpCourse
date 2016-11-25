using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            Console.WriteLine((int)MyEnum.LOLOp);
            MyEnum en = MyEnum.FirstOp;
            MyEnum m = SomeMethod();
            
            System.Console.WriteLine("LOL operation");
           NamedParam(2, 4, s : 54);
           Console.WriteLine(f(3));
        }

        private static MyEnum SomeMethod()
        {
            return MyEnum.LOLOp;
        }

        //f(n) = f(n-1) * n
        static int f(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            else
            {
                return f(x-1) * x;
            }
        }
        static int NamedParam(int x, int y, int z=5, int s=4)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(s);
            return x + y + z + s;
        }

        static void ParamsTry(params int[] integers)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            Console.WriteLine(result);
        }

        static int Inc2(ref int number)
        {
            var k = number;
            return number + 1;
        }
                static int Inc(out int number)
        {
            
            number = 13;
            return number + 1;
        }

        static void TrySwitch(MyEnum en){
            switch(en)
            {
                case MyEnum.FirstOp :
                    Console.WriteLine("FO");
                    break;
                case MyEnum.LOLOp :
                    Console.WriteLine("LO");
                    break;
                default:
                    Console.WriteLine("What is it?");
                    break;
            }
        }
    }

    enum MyEnum
    {
        FirstOp = 34, 
        SecondOp = 0,
        LOLOp
    }

}
