﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FilterSortPagingApp.Models
{
    public class FilterViewModel
    {
        public FilterViewModel(List<Company> companies, int? company, string name)
        {
            // устанавливаем начальный элемент, который позволит выбрать всех
            companies.Insert(0, new Company { Name = "Все", Id = 0 });
            Companies = new SelectList(companies, "Id", "Name", company);
            SelectedCompany = company;
            SelectedName = name;
        }
        public SelectList Companies { get; private set; } // список компаний
        public int? SelectedCompany { get; private set; }   // выбранная компания
        public string SelectedName { get; private set; }    // введенное имя
    }

    public enum SortState
    {
        NameAsc,    // по имени по возрастанию
        NameDesc,   // по имени по убыванию
        AgeAsc, // по возрасту по возрастанию
        AgeDesc,    // по возрасту по убыванию
        CompanyAsc, // по компании по возрастанию
        CompanyDesc // по компании по убыванию
    }
}