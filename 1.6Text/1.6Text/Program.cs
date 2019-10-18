using System;

namespace _1._6Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свой текст: ");
            string s = Console.ReadLine();

            int symbol_count = 0;
            string ll_word = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    symbol_count++;
                }
                
            }

            //s = s.Trim(new char[] { '.', ',', '-', '!', '?', ':', ';', '"','(', ')' });
            s = s.Replace(".", "").Replace(",", "").Replace("-", "").Replace("!", "").Replace("?", "").Replace(":", "").Replace(";", "").Replace("(", "").Replace(")", "").Replace("\"", "").Replace("  ", " ");

            string[] sarr = s.Split(new char[] {' '});
            for (int i = 0; i < sarr.Length; i++)
            {
                ll_word += sarr[i][sarr[i].Length - 1];
            }

            Console.WriteLine("Количество слов: " + sarr.Length + ";");
            Console.WriteLine("Количество символов без пробелов: " + symbol_count + ";");
            Console.WriteLine("Соотношение количество символов без пробелов к количеству слов: " + (double)symbol_count/ sarr.Length + ";");
            Console.WriteLine("Слово из последних символов слов: " + ll_word + ";");
        }
    }
}
