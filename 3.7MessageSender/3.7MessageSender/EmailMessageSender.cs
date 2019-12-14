using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace _3._7MessageSender.Models
{
    public class EmailMessageSender :IMessageSender
    {
        private string text;
        public EmailMessageSender(HttpContext context)
        {
            text = context.Session.GetString("text");
            if (text == null)
            {
                context.Session.SetString("text", "Hiiiii");
            }
        }
        public string Send()
        {
            if (text == null)
            {
                return "text empty";
            }
            return text;
        }
    }
}
