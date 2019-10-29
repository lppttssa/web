using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    class Ticket
    {
        public int id;
        public int id_out;
        public int id_in;
        public DateTime date;
        public int price;
        public int id_com;
        public int id_pil;

        public Ticket(int i, int i_out, int i_in, DateTime d, int p, int i_c, int i_p)
        {
            id = i;
            id_out = i_out; id_in = i_in; date = d; price = p; id_com = i_c; id_pil = i_p;
        }
    }
}
