using System;

namespace Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CityManager.Add(0, "Paris");
            CityManager.GetAll();
            Console.WriteLine();
            CityManager.Change(0, 1);
            CityManager.Add(2, "Moscow");
            CityManager.Add(3, "Tokyo");
            CityManager.Add(4, "Berlin");
            CityManager.GetAll();
            Console.WriteLine();
            CityManager.Delete(4);
            CityManager.GetAll();
            CityManager.Add(4, "Berlin");
            Console.WriteLine();
            CityManager.GetById(1);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            CompanyManager.Add(0, "Aeroflot");
            CompanyManager.GetAll();
            Console.WriteLine();
            CompanyManager.Change(0, 1);
            CompanyManager.Add(2, "Air France");
            CompanyManager.Add(3, "Korean Air");
            CompanyManager.Add(4, "Air Japan");
            CompanyManager.GetAll();
            Console.WriteLine();
            CompanyManager.Delete(4);
            CompanyManager.GetAll();
            CompanyManager.Add(4, "Air Japan");
            Console.WriteLine();
            CompanyManager.GetById(1);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            PilotManager.Add(0, 2, "Egor Drozd", 3);
            PilotManager.GetAll();
            Console.WriteLine();
            PilotManager.ChangeId(0, 1);
            PilotManager.ChangeName(1, "Igor Drozd");
            PilotManager.ChangeCId(1, 1);
            PilotManager.ChangeExp(1, 6);
            PilotManager.Add(2, 2, "Lui Mua", 10);
            PilotManager.Add(3, 3, "Jon Nji", 15);
            PilotManager.Add(4, 4, "Hiro Soki", 15);
            PilotManager.GetAll();
            Console.WriteLine();
            PilotManager.Delete(4);
            PilotManager.GetAll();
            PilotManager.Add(4, 4, "Hiro Soki", 15);
            Console.WriteLine();
            PilotManager.GetById(1);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            TicketManager.Add(0, 1, 2, 2019, 10, 05, 18, 30, 00, 150, 2, 2);
            TicketManager.GetAll();
            Console.WriteLine();
            TicketManager.ChangeId(0, 1);
            TicketManager.ChangePrice(1, 100);
            TicketManager.Add(2, 4, 1, 2019, 10, 06, 11, 00, 00, 200, 1, 1);
            TicketManager.Add(3, 3, 4, 2019, 10, 07, 12, 25, 00, 300, 3, 3);
            TicketManager.Add(4, 2, 3, 2019, 10, 08, 13, 45, 00, 400, 4, 4);
            TicketManager.Add(5, 1, 2, 2019, 10, 05, 17, 45, 00, 400, 4, 4);
            TicketManager.Add(6, 1, 2, 2019, 10, 05, 19, 45, 00, 230, 3, 3);
            TicketManager.Add(7, 1, 2, 2019, 10, 05, 14, 45, 00, 340, 1, 1);
            TicketManager.Add(8, 1, 2, 2019, 11, 05, 14, 45, 00, 340, 1, 1);
            TicketManager.GetAll();
            Console.WriteLine();
            TicketManager.Delete(8);
            TicketManager.GetAll();
            TicketManager.Add(8, 1, 2, 2019, 11, 05, 14, 45, 00, 340, 1, 1);
            Console.WriteLine();
            TicketManager.GetById(1);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            TicketFinder.Select("Paris", "Moscow", 2019, 10, 05);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            TicketSeller.Buy(1);
            Console.WriteLine();
            TicketSeller.Buy(15);
            Console.WriteLine();
            TicketManager.GetAll();

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            Bank.GetCredit();
            Console.WriteLine();
            Bank.GetCredit();
            Console.WriteLine();
            Bank.GetCredit();
            Console.WriteLine();
            Bank.GetCredit();
            Console.WriteLine();
            Bank.GetCredit();
        }
    }
}
