using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    class CityManager
    {
        static public List<City> cities = new List<City>(); 
        static public void Add(int id, string name)
        {
            cities.Add(new City(id, name));
        }

        static public void Change(int current_id, int new_id)
        {
            var index = cities.FindIndex(x => x.id == current_id);
            cities[index].id = new_id;
        }

        static public void Change(string current_city, int new_city)
        {
            var index = cities.FindIndex(x => x.city == current_city);
            cities[index].id = new_city;
        }

        static public void Delete(int id)
        {
            var index = cities.FindIndex(x => x.id == id);
            cities.RemoveAt(index);
        }
        static public void GetAll()
        {
            for (var i = 0; i < cities.Count; i++)
            {
                Console.Write($"{cities[i].id} {cities[i].city}");
                Console.WriteLine();
            }
        }

        static public void GetById(int i)
        {
            Console.Write($"{cities[i-1].id} {cities[i - 1].city}");
            Console.WriteLine();
        }
    }

}
