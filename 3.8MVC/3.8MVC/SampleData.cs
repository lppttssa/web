using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _3._8MVC.Models;

namespace _3._8MVC
{
    public class SampleData
    {
        public static void Initialize(NoodleContext context)
        {
            if (!context.Noodles.Any())
            {
                context.Noodles.AddRange(
                    new Noodle
                    {
                        Name = "SeaFood",
                        Company = "Cup Noodle",
                        Price = 4.10
                    },
                    new Noodle
                    {
                        Name = "Twigim Udon",
                        Company = "Nongshim",
                        Price = 1.25
                    },
                    new Noodle
                    {
                        Name = "Samyang",
                        Company = "Nongshim",
                        Price = 1.30
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
