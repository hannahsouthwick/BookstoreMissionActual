using System;
using System.Linq;
using BookstoreMission.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreMission.Components
{
    // load up the data set
    public class CategoryViewComponent : ViewComponent
    {
        private IBookstoreRepository repo { get; set; }

        public CategoryViewComponent(IBookstoreRepository temp)
        {
            repo = temp;
        }

        // pull out data of distinct
        public IViewComponentResult Invoke()
        {
            // ? means that it's okay if it's null
            ViewBag.SelectedCategory = RouteData?.Values["bookCategory"];

            // based on a book category
            var categories = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(categories);
        }
    }
}