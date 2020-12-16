using System;

namespace Lab4._2
{
    class Program
    {
        static int plus(int a, int b)
        {
            return a + b;
        }
        static int div(int a, int b)
        {
            return a / b;
        }
        static int minus(int a, int b)
        {
            return a - b;
        }
        static int multi(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            string a, b;
            Console.WriteLine("Input A:");
            a = Console.ReadLine();
            Console.WriteLine("Input B:");
            b = Console.ReadLine();
            Console.WriteLine(plus(int.Parse(a), int.Parse(b)));
            Console.WriteLine(minus(int.Parse(a), int.Parse(b)));
            Console.WriteLine(multi(int.Parse(a), int.Parse(b)));
            Console.WriteLine(div(int.Parse(a), int.Parse(b)));
        }
    }
}
