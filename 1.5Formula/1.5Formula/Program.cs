using System;

namespace _1._5Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; 
            Console.Write("Введите переменную: ");
            string input = Console.ReadLine();
            Int32.TryParse(input, out x);

            Console.WriteLine(Math.Asin(6 - x) + Math.Log(x));
            Console.WriteLine((double)1 / (1 + x) - (double)2 / Math.Pow(x, 2) + (double)1 / (1 - x));
            Console.WriteLine(3 * Math.Sin(x / 2 + x / 4) * Math.Sqrt(x - 1));
            Console.WriteLine(Math.Cos(x) + 1 / 2 * Math.Cos(2 * x) + 1 / 3 * Math.Cos(3 * x));
            Console.WriteLine(Math.Sqrt(Math.Pow(x, 2) + 1 / x) - Math.Sqrt(x));
        }
    }
}
