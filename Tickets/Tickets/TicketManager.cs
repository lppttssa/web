using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    class TicketManager
    {
        public static List<Ticket> tickets = new List<Ticket>();

        public static void Add(int id, int id_out, int id_in, int y, int mon, int d, int h, 
            int min, int price, int id_c, int id_p, int s = 0)
        {
            if (tickets.FindIndex(x => x.id == id) == -1 && CityManager.cities.FindIndex(x => x.id == id_out) != -1 &&
                CityManager.cities.FindIndex(x => x.id == id_in) != -1 && CompanyManager.companies.FindIndex(x => x.id == id_c) != -1 &&
                PilotManager.pilots.FindIndex(x => x.id == id_p) != -1)
            {
                try
                {
                    DateTime date = new DateTime(y, mon, d, h, min, s);
                    tickets.Add(new Ticket(id, id_out, id_in, date, price, id_c, id_p));
                    return;
                }
                catch
                {
                    Console.WriteLine("Sorry, couldn't add!");
                }
            }

            Console.WriteLine("Sorry, couldn't add the ticket!");
        }

        public static void ChangeId(int current_id, int new_id)
        {
            if (tickets.FindIndex(x => x.id == new_id) != -1)
            {
                Console.WriteLine("Sorry, the new id is not appropriate!");
                return;
            }

            var index = tickets.FindIndex(x => x.id == current_id);

            try
            {
                tickets[index].id = new_id;
            }
            catch
            {
                Console.WriteLine("Sorry, couldn't find the ticket with such id!");
            }
        }

        public static void ChangePrice(int current_id, int new_price)
        {
            var index = tickets.FindIndex(x => x.id == current_id);
            
            try
            {
                tickets[index].price = new_price;
            }
            catch
            {
                Console.WriteLine("Sorry, couldn't find the ticket with such id!");
            }
        }

        public static void Delete(int id)
        {
            var index = tickets.FindIndex(x => x.id == id);
            
            try
            {
                tickets.RemoveAt(index);
            }
            catch
            {
                Console.WriteLine("Sorry, couldn't delete the ticket with such id!");
            }
        }

        public static void GetAll()
        {
            for (var i = 0; i < tickets.Count; i++)
            {
                Console.Write($"{tickets[i].id} | {CityManager.cities.Find(x => x.id == tickets[i].id_out).name} => " +
                    $"{CityManager.cities.Find(x => x.id == tickets[i].id_in).name} | {tickets[i].date} | " +
                    $"{tickets[i].price}$ | {CompanyManager.companies.Find(x => x.id == tickets[i].id_com).name} | " +
                    $"{PilotManager.pilots.Find(x => x.id == tickets[i].id_pil).name}");
                Console.WriteLine();
            }
        }

        public static void GetById(int i)
        {
            try
            {
                int index = tickets.FindIndex(x => x.id == i);
                Console.Write($"{tickets[index].id} | {CityManager.cities.Find(x => x.id == tickets[index].id_out).name} => " +
                $"{CityManager.cities.Find(x => x.id == tickets[index].id_in).name} | {tickets[index].date} | " +
                $"{tickets[index].price}$ | {CompanyManager.companies.Find(x => x.id == tickets[index].id_com).name} | " +
                $"{PilotManager.pilots.Find(x => x.id == tickets[index].id_pil).name}");
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Sorry, couldn't find the ticket with such id!");
            }
        }
    }

}
