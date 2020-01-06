using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _6._3.Models;
using Microsoft.EntityFrameworkCore;

namespace _6._3.Controllers
{
    public class HomeController : Controller
    {
        noodlestoredbContext db;
        public HomeController(noodlestoredbContext context)
        {
            this.db = context;
            // добавляем начальные данные
            if (db.Noodles.Count() == 0)
            {
                Noodles SeaFood = new Noodles { Name = "SeaFood", Company = "Lala", Price = 100, City = "Tokyo" };
                Noodles Sea = new Noodles { Name = "Sea", Company = "La", Price = 10, City = "Soul" };
                db.Noodles.AddRange(SeaFood, Sea);
                db.SaveChanges();
                Orders order1 = new Orders { User = "Yury Noskov", Address = "Moscow", ContactPhone = "6", Noodle = SeaFood };
                Orders order2 = new Orders { User = "Yury Mous", Address = "Vladivostok", ContactPhone = "7", Noodle = Sea };

                db.Orders.AddRange(order1, order2);
                db.SaveChanges();
            }
        }

        public IActionResult IndexEagerLoading()
        {
            var orders = db.Orders
                    .Include(u => u.Noodle)  // добавляем данные по компаниям
                    .ToList();
            return View(orders.ToList());
        }

        public IActionResult IndexExplicitLoading()
        {
            db.Noodles.Load();
            db.Orders.Load();
            return View(db.Orders.ToList());
        }

        public IActionResult IndexLazyLoading()
        {
            var orders = db.Orders.ToList();
            var noodles = db.Noodles.ToList();
            return View(orders.ToList());
        }

    }
}
