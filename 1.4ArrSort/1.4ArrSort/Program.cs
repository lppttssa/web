using System;

namespace _1._4ArrSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int size = 20;
            int[] arr = new int[size];
            for (int i = 0; i <size; i++)
            {
                arr[i] = random.Next(1, 31);
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Как Вы хотите отсортировать массив? " +
                "Введите max - от максимального, min - от минимального: ");
            string how = Console.ReadLine();

            int temp;
            if (how == "min")
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = size - 1; j > i; j--)
                    {
                        if (arr[j - 1] > arr[j])
                        {
                            temp = arr[j - 1];
                            arr[j - 1] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            } 
            else
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = size - 1; j > i; j--)
                    {
                        if (arr[j - 1] < arr[j])
                        {
                            temp = arr[j - 1];
                            arr[j - 1] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
           
            for (int j = 0; j < size; j++)
            {
                Console.Write(arr[j] + " ");
            }
        }
    }
}
