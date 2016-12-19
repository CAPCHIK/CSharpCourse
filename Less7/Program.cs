using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TelegramBot
{
    delegate void FirstDelegate(int a);
    public class Program
    {
        static object locker = new object();
        private static void Work(object a)
        {
            lock(locker)
            {
                x = 0;
                for (int i = 0; i < (int)a; i++)
                {
                    Console.WriteLine($"In Thread {Thread.CurrentThread.Name}: " + x);
                    Thread.Sleep(1);
                    x++;
                }
            }
        }

        private static int x;
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            for (int i = 0; i < 5; i++)
            {
                Thread t = new Thread(() => 
                {
                    x = 0;
                    for (int j = 0; j < 234; j++)
                    {
                        Console.WriteLine($"In Thread {Thread.CurrentThread.Name}: " + x);
                        Thread.Sleep(1);
                        x++;
                    }
                });
                t.Name = "" + i;
                t.Start();
            }



            return;


            Thread th = new Thread(Work);
            th.Start();

            for (int i = 0; i < 50; i++)
            {   
                Console.WriteLine("In General: " + i);
                Thread.Sleep(1);
            }


            return;


            List<string> strs = new List<string>();
            strs.Add("12345");
            strs.Add("1234567");
            Console.WriteLine (
                strs.All(S => S.Length > 5) ? "Yes" : "No"
            );

            return;

            Home h = new Home();
            h.OnHomeInFire += () =>
            {
                System.Console.WriteLine("Lambda Fire");
            };
            h.OnHomeInFire += SampleFireSit;
            
            h.Podzech();
            
            return;
            int[] nums = new int[1234];
            
            ForEach(nums, Num => 
                {
                    var n = Num * Num;
                    Console.WriteLine(n);
                });

            // var h2 = new Home (() => Console.WriteLine("File :("));
            // h2.Podzech();
            // return;

            // var h1 = new Home(SampleFireSit);
            // h1.Podzech();

            // return;
            DelegateTest(OnEnd);
            
            return;

            WorkWithPerson(new P1());
            WorkWithPerson(new P2());
        }

        
        private static void OnEnd(int b)
        {
            System.Console.WriteLine(b);
        }
        private static void SampleFireSit()
        {
            System.Console.WriteLine("AAAAHH!! Fire!");
        }

        delegate void ForInt(int a);
        private static void ForEach(int[] nums, ForInt action){
            for (int i = 0; i < nums.Length; i++)
                action(nums[i]);
        }

        private static void DelegateTest(FirstDelegate callback)
        {
            int result = 0;
            for (int i = 0; i < 100; i++)
            {
                result += i;
            }
            callback(result);
        }
        private static void WorkWithPerson(ICalc calc){
            calc.Sum(2, 5);
        }     
    }
    
    delegate void ForFire();
    class Home
    {
        //private ForFire OnFire;
        public event ForFire OnHomeInFire;
        // public Home(ForFire f)
        // {
        //     OnFire = f;
        // }

        public void CalcPrice(Func<int, string,  int> operation, int priceformeter)
        {
            var resulr = operation(priceformeter, "");
        }
        public void Podzech()
        {
            //OnFire();
            if (OnHomeInFire != null)
                OnHomeInFire();
        }
    }
    class P1 : ICalc
    {
        public void Sum(int a, int b)
        {
            System.Console.WriteLine("Summ : " + (a + b));
        }
    }
    class P2 : ICalc
    {
        public void Sum(int a, int b)
        {
            System.Console.WriteLine("Summ : " + (a - b));
        }
    }
    interface ICalc
    {
        void Sum(int a, int b);
    }

}
