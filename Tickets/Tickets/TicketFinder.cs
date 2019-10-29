using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    class TicketFinder
    {
        public void TheCheapest(string from, string to)
        {
            Ticket t;
            var index_from = CityManager.cities.FindIndex(x => x.city == from);
            var index_to = CityManager.cities.FindIndex(x => x.city == to);
            if (index_from == -1 || index_to == -1)
            {
                Console.WriteLine("No tickets for such cities available");
            }
            for (int i = 0; i < TicketManager.tickets.Count; i++)
            {
                if (TicketManager.tickets[i].id_out == CityManager.cities[index_from].id)
            }
        }

    }
}
