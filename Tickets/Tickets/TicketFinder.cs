﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    class TicketFinder
    {
        private static void TheCheapest(List<Ticket> list)
        {
            Ticket t = null;
            int price = 10000;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].price < price)
                {
                    t = list[i];
                    price = list[i].price;
                }
            }
            TicketManager.GetById(t.id);
            
        }

        private static void TheMostExperienced(List<Ticket> list)
        {
            int exp = 0;

            List<Ticket> res = new List<Ticket>();

            for (int i = 0; i < list.Count; i++)
            {
                int mem = PilotManager.pilots.Find(x => x.id == list[i].id_pil).exp;
                if (mem > exp)
                {
                    exp = mem;
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (PilotManager.pilots.Find(x => x.id == list[i].id_pil).exp == exp)
                {
                    res.Add(list[i]);
                }
            }

            Print(res);
        }

        public static void Select(string from, string to, int year,int month,int day)
        {
            var index_from = CityManager.cities.FindIndex(x => x.name == from);
            var index_to = CityManager.cities.FindIndex(x => x.name == to);
            try
            {
                List<Ticket> list = new List<Ticket>();
                list = TicketManager.tickets.FindAll(x => x.id_out == CityManager.cities[index_from].id);
                list = list.FindAll(x => x.id_in == CityManager.cities[index_to].id);
                list = list.FindAll(x => x.date.Year == year);
                list = list.FindAll(x => x.date.Month == month);
                list = list.FindAll(x => x.date.Day == day);

                if (list.Count == 0)
                {
                    Console.WriteLine("No tickets for these days");
                    return;
                }

                Print(list);

                Console.WriteLine();
                TheCheapest(list);
                Console.WriteLine();
                TheMostExperienced(list);
            }
            catch
            {
                Console.WriteLine("Sorry, couldn't select the tickets with such parameters!");
            }
            
        }

        private static void Print(List<Ticket> list)
        {
            for (var i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i].id} | {CityManager.cities.Find(x => x.id == list[i].id_out).name} => " +
                    $"{CityManager.cities.Find(x => x.id == list[i].id_in).name} | {list[i].date} | " +
                    $"{list[i].price}$ | {CompanyManager.companies.Find(x => x.id == list[i].id_com).name} | " +
                    $"{PilotManager.pilots.Find(x => x.id == list[i].id_pil).name}");
                Console.WriteLine();
            }
        }

    }
}
