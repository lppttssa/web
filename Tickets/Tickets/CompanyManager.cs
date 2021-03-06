﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    class CompanyManager
    {
        public static List<Company> companies = new List<Company>();
        public static void Add(int id, string name)
        {
            if (companies.FindIndex(x => x.id == id) == -1 && companies.FindIndex(x => x.name == name) == -1)
            {
                companies.Add(new Company(id, name));
                return;
            }
            Console.WriteLine("Sorry, couldn't add the name!");
        }

        public static void Change(int current_id, int new_id)
        {
            if (companies.FindIndex(x => x.id == new_id) != -1)
            {
                Console.WriteLine("Sorry, the new id is not appropriate!");
                return;
            }
            var index = companies.FindIndex(x => x.id == current_id);
            try
            {
                companies[index].id = new_id;
            }
            catch
            {
                Console.WriteLine("Sorry, couldn't find the name with such id!");
            }
        }

        public static void Change(int current_id, string new_name)
        {
            if (companies.FindIndex(x => x.name == new_name) != -1)
            {
                Console.WriteLine("Sorry, the new name is not appropriate!");
                return;
            }
            var index = companies.FindIndex(x => x.id == current_id);
            try
            {
                companies[index].name = new_name;
            }
            catch
            {
                Console.WriteLine("Sorry, couldn't find the name with such id!");
            }
        }

        public static void Delete(int id)
        {
            var index = companies.FindIndex(x => x.id == id);

            try
            {
                companies.RemoveAt(index);
            }
            catch
            {
                Console.WriteLine("Sorry, couldn't delete the name with such id!");
            }
        }
        public static void GetAll()
        {
            for (var i = 0; i < companies.Count; i++)
            {
                Console.WriteLine($"{companies[i].id} {companies[i].name}");
            }
        }

        public static void GetById(int i)
        {
            try
            {
                int index = companies.FindIndex(x => x.id == i);
                Console.WriteLine($"{companies[index].id} {companies[index].name}");
            }
            catch
            {
                Console.WriteLine("Sorry, couldn't find the name with such id!");
            }
        }
    }
}
