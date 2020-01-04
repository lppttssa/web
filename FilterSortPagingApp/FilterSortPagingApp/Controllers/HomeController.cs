using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FilterSortPagingApp.Models;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FilterSortPagingApp.Controllers
{
    public class HomeController : Controller
    {
        PilotsContext db;
        public HomeController(PilotsContext context)
        {
            this.db = context;
            // добавляем начальные данные
            if (db.Cities.Count() == 0)
            {
                City Moscow = new City { Name = "Moscow" };
                City Tokyo = new City { Name = "Tokyo" };
                City Paris = new City { Name = "Paris" };

                Pilot pilot1 = new Pilot { name = "Yury Noskov", City = Moscow, exp = 6 };
                Pilot pilot2 = new Pilot { name = "Leonid Babich", City = Tokyo, exp = 4 };
                Pilot pilot3 = new Pilot { name = "Temofey Trubyts", City = Tokyo, exp = 5 };
                Pilot pilot4 = new Pilot { name = "Ivan Ivanov", City = Moscow, exp = 10 };
                Pilot pilot5 = new Pilot { name = "Si Lee", City = Paris, exp = 3 };
                Pilot pilot6 = new Pilot { name = "Honsol Keity", City = Paris, exp = 2 };
                Pilot pilot7 = new Pilot { name = "Mickael Keity", City = Moscow, exp = 11 };
                Pilot pilot8 = new Pilot { name = "Lee Keity", City = Moscow, exp = 8 };
                Pilot pilot9 = new Pilot { name = "Boris Keity", City = Paris, exp = 1 };

                db.Cities.AddRange(Moscow, Tokyo, Paris);
                db.Pilots.AddRange(pilot1, pilot2, pilot3, pilot4, pilot5, pilot6, pilot7, pilot8, pilot9);
                db.SaveChanges();
            }
        }
        public async Task<IActionResult> Index(int? city, string name, int page = 1,
            SortState sortOrder = SortState.NameAsc)
        {
            int pageSize = 3;

            //фильтрация
            IQueryable<Pilot> pilots = db.Pilots.Include(x => x.City);

            if (city != null && city != 0)
            {
                pilots = pilots.Where(p => p.CityId == city);
            }
            if (!String.IsNullOrEmpty(name))
            {
                pilots = pilots.Where(p => p.name.Contains(name));
            }

            // сортировка
            switch (sortOrder)
            {
                case SortState.NameDesc:
                    pilots = pilots.OrderByDescending(s => s.name);
                    break;
                case SortState.ExpAsc:
                    pilots = pilots.OrderBy(s => s.exp);
                    break;
                case SortState.ExpDesc:
                    pilots = pilots.OrderByDescending(s => s.exp);
                    break;
                case SortState.CompanyAsc:
                    pilots = pilots.OrderBy(s => s.City.Name);
                    break;
                case SortState.CompanyDesc:
                    pilots = pilots.OrderByDescending(s => s.City.Name);
                    break;
                default:
                    pilots = pilots.OrderBy(s => s.name);
                    break;
            }

            // пагинация
            var count = await pilots.CountAsync();
            var items = await pilots.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            // формируем модель представления
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = new PageViewModel(count, page, pageSize),
                SortViewModel = new SortViewModel(sortOrder),
                FilterViewModel = new FilterViewModel(db.Cities.ToList(), city, name),
                Pilots = items
            };
            return View(viewModel);
        }
    }
}