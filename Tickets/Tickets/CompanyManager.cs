using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    class CompanyManager
    {
        static public List<Company> companies = new List<Company>();
        static public void Add(int id, string name)
        {
            if (companies.FindIndex(x => x.id == id) == -1 && companies.FindIndex(x => x.company == name) == -1)
            {
                companies.Add(new Company(id, name));
                return;
            }
            Console.WriteLine("Sorry, couldn't add the company!");
        }

        static public void Change(int current_id, int new_id)
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
                Console.WriteLine("Sorry, couldn't find the company with such id!");
            }
        }

        static public void Delete(int id)
        {
            var index = companies.FindIndex(x => x.id == id);

            try
            {
                companies.RemoveAt(index);
            }
            catch
            {
                Console.WriteLine("Sorry, couldn't delete the company with such id!");
            }
        }
        static public void GetAll()
        {
            for (var i = 0; i < companies.Count; i++)
            {
                Console.WriteLine($"{companies[i].id} {companies[i].company}");
            }
        }

        static public void GetById(int i)
        {
            try
            {
                Console.WriteLine($"{companies[i - 1].id} {companies[i - 1].company}");
            }
            catch
            {
                Console.WriteLine("Sorry, couldn't find the company with such id!");
            }
        }
    }
}
