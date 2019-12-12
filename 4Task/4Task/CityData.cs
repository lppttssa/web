using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _4Task.Models;

namespace _4Task
{
    public static class CityData
    {
        public static void Initialize(CityContext context)
        {
            if (!context.Cities.Any())
            {
                context.Cities.AddRange(
                    new City
                    {
                        name = "Paris"
                    },
                    new City
                    {
                        name = "Tokyo"
                    },
                    new City
                    {
                        name = "Soul"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
