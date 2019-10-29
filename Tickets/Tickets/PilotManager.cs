using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    class PilotManager
    {
        static public List<Pilot> pilots = new List<Pilot>();
        static public void Add(int id, int c_id, string name, int exp)
        {
            pilots.Add(new Pilot(id, c_id, name, exp));
        }

        static public void ChangeId(int current_id, int new_id)
        {
            var index = pilots.FindIndex(x => x.id == current_id);
            pilots[index].id = new_id;
        }

        static public void ChangeCId(int i, int new_id)
        {
            var index = pilots.FindIndex(x => x.id == i);
            pilots[index].c_id = new_id;
        }

        static public void ChangeName(int i, string new_name)
        {
            var index = pilots.FindIndex(x => x.id == i);
            pilots[index].name = new_name;
        }

        static public void ChangeExp(int i, int new_exp)
        {
            var index = pilots.FindIndex(x => x.id == i);
            pilots[index].exp = new_exp;
        }

        static public void Delete(int id)
        {
            var index = pilots.FindIndex(x => x.id == id);
            pilots.RemoveAt(index);
        }
        static public void GetAll()
        {
            for (var i = 0; i < pilots.Count; i++)
            {
                Console.Write($"{pilots[i].id} {pilots[i].c_id} {pilots[i].name} {pilots[i].exp}");
                Console.WriteLine();
            }
        }

        static public void GetById(int i)
        {
            Console.Write($"{pilots[i - 1].id} {pilots[i - 1].c_id} {pilots[i - 1].name} {pilots[i - 1].exp}");
            Console.WriteLine();
        }
    }
}
