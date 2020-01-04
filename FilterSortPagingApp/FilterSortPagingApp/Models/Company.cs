using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterSortPagingApp.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Pilot> Pilots { get; set; }
        public Company()
        {
            Pilots = new List<Pilot>();
        }
    }
}
