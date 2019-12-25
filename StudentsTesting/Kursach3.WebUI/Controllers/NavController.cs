using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kursach3Domain.Abstract;

namespace Kursach3.WebUI.Controllers
{
    public class NavController : Controller
    {
        private ITestRepository repository;
        public NavController(ITestRepository repo)
        {
            repository = repo;
        }
        public PartialViewResult Menu(string category=null)
        {
            ViewBag.SelectedCategory = category;
            IEnumerable<string> categories=repository.TestPreview
                .Select(Test => Test.Category)
                .Distinct()
                .OrderBy(x => x );
            return PartialView(categories);
        }
    }
}
