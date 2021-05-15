using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class StatisticController : Controller
    {
        Context _context = new Context();

        public ActionResult Index()
        {
            int totalCategory = _context.Categories.Count();                                        // total category number were calculated.
            ViewBag.totalNumberOfCategories = totalCategory;                                        // ViewBag was used to access the view section.

            int softwareCategory = _context.Headings.Count(x => x.CategoryID == 5);                 // number of title of software category was calculated.
            ViewBag.softwareCategoryTitleNumber = softwareCategory;

            int writerName = _context.Writers.Count(x => x.WriterName.Contains("a"));               // number of authors with letter "a" in author name was calculated.
            ViewBag.writerName = writerName;

            string manyTitles = _context.Headings.Max(x => x.Category.CategoryName);                // category name with most titles was displayed.
            ViewBag.manyTitles = manyTitles;

            int categoryStatusFalse = _context.Categories.Count(x => x.CategoryStatus == false);    // wrong ones were calculated.
            ViewBag.notActiveCategory = categoryStatusFalse;

            return View();
        }
    }
}