using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetDuds.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetDuds.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //use the category model to create & populate a list of 10 mock category objects for display
            var categories = new List<Category>();

            //use a loop to make 10 fake objects
            for (var i = 1; i <=10; i++)
            {
                categories.Add(new Category() { Id = 1, Name = "Category" + i.ToString() });
            }
            return View(categories);
        }

        public IActionResult Browse(string category)
        {
            //pass the incoming category back to the browse view by using viewBag.
            ViewBag.category = category;
            return View();
        }
    }
}
