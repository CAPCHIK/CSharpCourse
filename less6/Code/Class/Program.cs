using System;
using System.Collections.Generic;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {    
            MyGeneric<int, string> mc = new MyGeneric<int, string>();

            return;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            ITelegramConnector connector = new WebRequestConnector();
            //
            
            try
            {
                System.Console.WriteLine(connector.GetUpdates());
            }
            finally
            {
                System.Console.WriteLine("Final");
            }
            Console.WriteLine("LOL");
            return;
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("one ");
            list.AddLast("344");
            list.AddLast("one ");
            list.Remove("344");
            foreach (string item in list)
            {                
                Console.WriteLine(item);
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
