using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace _3._7MessageSender.Models
{
    public class SmsMessageSender : IMessageSender
    {
        private string text;
        public SmsMessageSender(HttpContext context)
        {
            text = context.Request.Cookies["text"];
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
