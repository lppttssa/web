using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _3._8MVC.Models;

namespace _3._8MVC.Controllers
{
    public class HomeController : Controller
    {
        NoodleContext db;
        public HomeController(NoodleContext context)
        {
            db = context;
        }
        public IActionResult Index() //передача данных пользователю
        {
            return View(db.Noodles.ToList()); //генерирует представление
        }

        [HttpGet] //указывают, какой тип запроса обрабатывается
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index"); //переадресация на индекс
            ViewBag.NoodleId = id; //передаем в представление
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();// сохраняем в бд все изменения
            return "Пасиба, " + order.User + ", за покупку, дотвиданя!";
        }
    }

}
