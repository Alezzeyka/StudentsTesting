using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kursach3Domain.Abstract;
using Kursach3Domain.Entities;
using Kursach3.WebUI.Models;

namespace Kursach3.WebUI.Controllers
{
    public class TestController : Controller
    {
        private ITestRepository repository;
        public int pageSize = 4;
        public TestController(ITestRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(string category, int page=1)
        {
            TestListViewModel model = new TestListViewModel
            {
                Tests = repository.TestPreview
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(TestPreview => TestPreview.Id)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = category == null ?
                    repository.TestPreview.Count() :
                    repository.TestPreview.Where(TestPreview => TestPreview.Category == category).Count()
                },
                CurrentCategory = category
            };
            return View(model);
        }
    }
    
}
