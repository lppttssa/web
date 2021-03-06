﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    class CityManager
    {
        public static List<City> cities = new List<City>(); 
        public static void Add(int id, string name)
        {
            if (cities.FindIndex(x => x.id == id) == -1 && cities.FindIndex(x => x.name == name) == -1)
            {
                cities.Add(new City(id, name));
                return;
            }

            Console.WriteLine("Sorry, couldn't add the name!");
        }

        public static void Change(int current_id, int new_id)
        {
            if (cities.FindIndex(x => x.id == new_id) != -1)
            {
                Console.WriteLine("Sorry, the new id is not appropriate!");
                return;
            }
            var index = cities.FindIndex(x => x.id == current_id);
            try
            {
                cities[index].id = new_id;
            }
            catch
            {
                Console.WriteLine("Sorry, couldn't find the name with such id!");
            }
            
        }

        public static void Delete(int id)
        {
            var index = cities.FindIndex(x => x.id == id);

            try
            {
                cities.RemoveAt(index);
            }
            catch
            {
                Console.WriteLine("Sorry, couldn't delete the name with such id!");
            }  
        }
        public static void GetAll()
        {
            for (var i = 0; i < cities.Count; i++)
            {
                Console.WriteLine($"{cities[i].id} {cities[i].name}");
            }
        }

        public static void GetById(int i)
        {
            try
            {
                int index = cities.FindIndex(x => x.id == i);
                Console.WriteLine($"{cities[index].id} {cities[index].name}");
            }
            catch
            {
                Console.WriteLine("Sorry, couldn't find the name with such id!");
            }           
        }
    }

}
