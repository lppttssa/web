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
            if (db.Companies.Count() == 0)
            {
                Company Aeroflot = new Company { Name = "Aeroflot" };
                Company KoreanAir = new Company { Name = "Korean Air" };
                Company S7 = new Company { Name = "S7" };

                Pilot pilot1 = new Pilot { name = "Yury Noskov", Company = Aeroflot, exp = 6 };
                Pilot pilot2 = new Pilot { name = "Leonid Babich", Company = S7, exp = 4 };
                Pilot pilot3 = new Pilot { name = "Temofey Trubyts", Company = S7, exp = 5 };
                Pilot pilot4 = new Pilot { name = "Ivan Ivanov", Company = Aeroflot, exp = 10 };
                Pilot pilot5 = new Pilot { name = "Si Lee", Company = KoreanAir, exp = 3 };
                Pilot pilot6 = new Pilot { name = "Honsol Keity", Company = KoreanAir, exp = 2 };

                db.Companies.AddRange(Aeroflot, KoreanAir, S7);
                db.Pilots.AddRange(pilot1, pilot2, pilot3, pilot4, pilot5, pilot6);
                db.SaveChanges();
            }
        }
        public async Task<IActionResult> Index(int? company, string name, int page = 1,
            SortState sortOrder = SortState.NameAsc)
        {
            int pageSize = 3;

            //фильтрация
            IQueryable<Pilot> pilots = db.Pilots.Include(x => x.Company);

            if (company != null && company != 0)
            {
                pilots = pilots.Where(p => p.CompanyId == company);
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
                    pilots = pilots.OrderBy(s => s.Company.Name);
                    break;
                case SortState.CompanyDesc:
                    pilots = pilots.OrderByDescending(s => s.Company.Name);
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
                FilterViewModel = new FilterViewModel(db.Companies.ToList(), company, name),
                Pilots = items
            };
            return View(viewModel);
        }
    }
}