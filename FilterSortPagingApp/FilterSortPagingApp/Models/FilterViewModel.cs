using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FilterSortPagingApp.Models
{
    public class FilterViewModel
    {
        public FilterViewModel(List<City> cities, int? city, string name)
        {
            // устанавливаем начальный элемент, который позволит выбрать всех
            cities.Insert(0, new City { Name = "Все", Id = 0 });
            Cities = new SelectList(cities, "Id", "Name", city);
            SelectedCity = city;
            SelectedName = name;
        }
        public SelectList Cities { get; private set; } // список компаний
        public int? SelectedCity { get; private set; }   // выбранная компания
        public string SelectedName { get; private set; }    // введенное имя
    }

    public enum SortState
    {
        NameAsc,    // по имени по возрастанию
        NameDesc,   // по имени по убыванию
        ExpAsc, // по возрасту по возрастанию
        ExpDesc,    // по возрасту по убыванию
        CompanyAsc, // по компании по возрастанию
        CompanyDesc // по компании по убыванию
    }
}