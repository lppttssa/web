using System;

namespace _1._2Calc
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите операцию: ");
            string oper = Console.ReadLine();

            while (oper != "exit")
            {
                while ((oper != "+") && (oper != "-") && (oper != "*") && (oper != "/"))
                {
                    Console.Write("Ошибка! Введите допустимую операцию: ");
                    oper = Console.ReadLine();
                }

                double a;
                Console.Write("Введите первое число: ");
                while (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.Write("Ошибка! Введите подходящее первое число: ");
                }

                double b;
                Console.Write("Введите второе число: ");
                while (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.Write("Ошибка! Введите подходящее второе число: ");
                }

                double res = 0;
                if (oper == "/" && b == 0)
                {
                    Console.WriteLine("А на ноль делить нельзя! Пока!");
                }
                else
                {
                    switch (oper)
                    {
                        case "+": res = a + b; break;
                        case "-": res = a - b; break;
                        case "*": res = a * b; break;
                        case "/": res = a / b; break;
                    }

                    Console.WriteLine(a + " " + oper + " " + b + " = " + res);
                }
                Console.WriteLine("Введите exit, если хотите закончить, " +
                    "операцию - если хотите продолжить");
                oper = Console.ReadLine();
            }
        }
    }
}
