using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3._7MessageSender.Models
{
    public class MessageService
    {
        IMessageSender s;
        public MessageService(IMessageSender sender)
        {
            s = sender;
        }
        public string Send()
        {
            return s.Send();
        }
    }
}
