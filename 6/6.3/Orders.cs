using System;
using System.Collections.Generic;

namespace _6._3
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public string User { get; set; }
        public string Address { get; set; }
        public string ContactPhone { get; set; }
        public int NoodleId { get; set; }

        public virtual Noodles Noodle { get; set; }
    }
}
