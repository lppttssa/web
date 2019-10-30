using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    class Bank
    {
        static public void GetCredit()
        {
            Random random = new Random();

            List<string> banks = new List<string>();
            banks.Add("Sberbank");
            banks.Add("Sovcombank");
            banks.Add("VTB Bank");
            banks.Add("Gazprombank");
            banks.Add("Alfa-Bank");
            banks.Add("Rosbank");
            banks.Add("Tinkoff Bank");

            int credit = random.Next(0, 2);
            if (credit == 0)
            {
                Console.WriteLine("Sorry, your credit request hasn't been accepted!");
                return;
            }
            int b = random.Next(0, 7);
            int p = random.Next(1, 16);

            Console.WriteLine($"Your credit request has been accepted! \n Your bank is {banks[b]} with loan rate {p}");

        }
    }
}
