using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    class PilotManager
    {
        public static List<Pilot> pilots = new List<Pilot>();
        public static void Add(int id, int c_id, string name, int exp)
        {
            if (pilots.FindIndex(x => x.id == id) == -1)
            {
                pilots.Add(new Pilot(id, c_id, name, exp));
                return;
            }
            Console.WriteLine("Sorry, couldn't add the pilot!");
        }

        public static void ChangeId(int current_id, int new_id)
        {
            if (pilots.FindIndex(x => x.id == new_id) != -1)
            {
                Console.WriteLine("Sorry, the new id is not appropriate!");
                return;
            }

            var index = pilots.FindIndex(x => x.id == current_id);

            try
            {
                pilots[index].id = new_id;
            }
            catch
            {
                Console.WriteLine("Sorry, couldn't find the pilot with such id!");
            }
        }

        public static void ChangeCId(int i, int new_id)
        {
            if (CompanyManager.companies.FindIndex(x => x.id == new_id) == -1)
            {
                Console.WriteLine("Sorry, the id is not appropriate!");
                return;
            }

            var index = pilots.FindIndex(x => x.id == i);

            try
            {
                pilots[index].c_id = new_id;
            }
            catch
            {
                Console.WriteLine("Sorry, couldn't find the pilot with such id!");
            }
        }

        public static void ChangeExp(int i, int new_exp)
        {
            var index = pilots.FindIndex(x => x.id == i);
           
            try
            {
                pilots[index].exp = new_exp;
            }
            catch
            {
                Console.WriteLine("Sorry, couldn't find the pilot with such id!");
            }
        }

        public static void Delete(int id)
        {
            var index = pilots.FindIndex(x => x.id == id);
            try
            {
                pilots.RemoveAt(index);
            }
            catch
            {
                Console.WriteLine("Sorry, couldn't delete the pilot with such id!");
            }
        }
        public static void GetAll()
        {
            for (var i = 0; i < pilots.Count; i++)
            {
                Console.Write($"{pilots[i].id} {pilots[i].c_id} {pilots[i].name} {pilots[i].exp}");
                Console.WriteLine();
            }
        }

        public static void GetById(int i)
        {
            try
            {
                Console.WriteLine($"{pilots[i - 1].id} {pilots[i - 1].c_id} {pilots[i - 1].name} {pilots[i - 1].exp}");
            }
            catch
            {
                Console.WriteLine("Sorry, couldn't find the pilot with such id!");
            }
        }
    }
}
