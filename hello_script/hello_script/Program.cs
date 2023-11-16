using System;

namespace hello_script
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("hello everyone");
            GreetWhite();
            GreetBlack();
        }

        public static void GreetWhite()
        {
            Console.WriteLine("hello white");
        }

        public static void GreetBlack()
        {
            Console.WriteLine("hello black");
        }
    }
}