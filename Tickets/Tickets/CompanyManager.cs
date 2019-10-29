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
            companies.Add(new Company(id, name));
        }

        static public void Change(int current_id, int new_id)
        {
            var index = companies.FindIndex(x => x.id == current_id);
            companies[index].id = new_id;
        }

        static public void Change(string current_company, int new_company)
        {
            var index = companies.FindIndex(x => x.company == current_company);
            companies[index].id = new_company;
        }

        static public void Delete(int id)
        {
            var index = companies.FindIndex(x => x.id == id);
            companies.RemoveAt(index);
        }
        static public void GetAll()
        {
            for (var i = 0; i < companies.Count; i++)
            {
                Console.Write($"{companies[i].id} {companies[i].company}");
                Console.WriteLine();
            }
        }

        static public void GetById(int i)
        {
            Console.Write($"{companies[i - 1].id} {companies[i - 1].company}");
            Console.WriteLine();
        }
    }
}
