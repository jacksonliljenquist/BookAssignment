using BookAssignment.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAssignment.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookListRepository repository;

        public NavigationMenuViewComponent(IBookListRepository r)
        {
            repository = r;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Projects
                .Select(x => x.Classification)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
