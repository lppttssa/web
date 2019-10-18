using System;

namespace _1._3GenArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int size, min, max;
            Console.Write("Введите размер массива: ");
            string input = Console.ReadLine();
            Int32.TryParse(input, out size);
            Console.Write("Введите минимальный элемент: ");
            input = Console.ReadLine();
            Int32.TryParse(input, out min);
            Console.Write("Введите максимальный элемент: ");
            input = Console.ReadLine();
            Int32.TryParse(input, out max);

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(min, max + 1);
                Console.Write(arr[i] + " ");
            }
        }
    }
}
