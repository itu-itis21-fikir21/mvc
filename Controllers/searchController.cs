using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using uygulama1.Models;

namespace uygulama1.Controllers
{
    public class searchController : Controller
    {
        // GET: search
        caglaEntities db = new caglaEntities();
        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(string film_)
            {
            var film = db.film_list.Select(x => x.film_name);
            if (!string.IsNullOrEmpty(film_))
            {
                film = film.Where(x => x.Contains(film_));  
            }
            return View(film.ToList());
        }
    }
}