using System;
using System.Collections.Generic;

namespace _6._3
{
    public partial class Noodles
    {
        public Noodles()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public double Price { get; set; }
        public string City { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
