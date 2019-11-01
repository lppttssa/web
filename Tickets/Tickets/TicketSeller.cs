using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    class TicketSeller
    {
        public static void Buy(int id)
        {
            var index = TicketManager.tickets.FindIndex(x => x.id == id);
            
            try
            {
                Console.WriteLine($"You have bought a ticket {TicketManager.tickets[index].id} | {CityManager.cities.Find(x => x.id == TicketManager.tickets[index].id_out).name} => " +
                    $"{CityManager.cities.Find(x => x.id == TicketManager.tickets[index].id_in).name} | {TicketManager.tickets[index].date} | " +
                    $"{TicketManager.tickets[index].price}$ | {CompanyManager.companies.Find(x => x.id == TicketManager.tickets[index].id_com).name} | " +
                    $"{PilotManager.pilots.Find(x => x.id == TicketManager.tickets[index].id_pil).name}");
                TicketManager.Delete(TicketManager.tickets[index].id);
            }
            catch
            {
                Console.WriteLine($"Sorry! No tickets with such id: {id}");
            }
            
        }
    }
}
