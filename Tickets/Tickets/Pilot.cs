using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    class Pilot
    {
        public int id;
        public int c_id;
        public string name;
        public int exp;

        public Pilot(int i, int c_i, string n, int e) { id = i; c_id = c_i; name = n; exp = e; }
    }
}
