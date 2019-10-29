using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    class TicketManager
    {
        static public List<Ticket> tickets = new List<Ticket>();

        static public void Add(int id, int id_out, int id_in, int y, int mon, int d, int h, 
            int min, int s, int price, int id_c, int id_p)
        {
            DateTime date = new DateTime(y, mon, d, h, min, s);
            tickets.Add(new Ticket(id, id_out, id_in, date, price, id_c, id_p));
        }

        static public void ChangeId(int current_id, int new_id)
        {
            var index = tickets.FindIndex(x => x.id == current_id);
            tickets[index].id = new_id;
        }

        static public void ChangePrice(int current_id, int new_price)
        {
            var index = tickets.FindIndex(x => x.id == current_id);
            tickets[index].price = new_price;
        }

        static public void Delete(int id)
        {
            var index = tickets.FindIndex(x => x.id == id);
            tickets.RemoveAt(index);
        }

        static public void GetAll()
        {
            for (var i = 0; i < tickets.Count; i++)
            {
                Console.Write($"{tickets[i].id} | {CityManager.cities.Find(x => x.id == tickets[i].id_out).city} => " +
                    $"{CityManager.cities.Find(x => x.id == tickets[i].id_in).city} | {tickets[i].date} | " +
                    $"{tickets[i].price}$ | {CompanyManager.companies.Find(x => x.id == tickets[i].id_com).company} | " +
                    $"{PilotManager.pilots.Find(x => x.id == tickets[i].id_pil).name}");
                Console.WriteLine();
            }
        }

        static public void GetById(int i)
        {
            Console.Write($"{tickets[i - 1].id} | {CityManager.cities.Find(x => x.id == tickets[i - 1].id_out).city} => " +
                $"{CityManager.cities.Find(x => x.id == tickets[i - 1].id_in).city} | {tickets[i - 1].date} | " +
                $"{tickets[i - 1].price}$ | {CompanyManager.companies.Find(x => x.id == tickets[i - 1].id_com).company} | " +
                $"{PilotManager.pilots.Find(x => x.id == tickets[i - 1].id_pil).name}");
            Console.WriteLine();
        }
    }

}
