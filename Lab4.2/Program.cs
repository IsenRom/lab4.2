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
            Console.WriteLine("Число A:");
            a = Console.ReadLine();
            Console.WriteLine("Число B:");
            b = Console.ReadLine();
            Console.WriteLine("Действия");
            Console.WriteLine($"{a}+{b}={plus(int.Parse(a), int.Parse(b))}");
            Console.WriteLine($"{a}-{b}={minus(int.Parse(a), int.Parse(b))}");
            Console.WriteLine($"{a}*{b}={multi(int.Parse(a), int.Parse(b))}");
            Console.WriteLine($"{a}div{b}={div(int.Parse(a), int.Parse(b))}");
        }
    }
}
