using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using uygulama1.Models;

namespace uygulama1.Controllers
{
    public class ListeController : Controller
    {
        // GET: Urun
        caglaEntities db = new caglaEntities();
        public ActionResult Liste() {
            var filmler = db.film_list.ToList();
            return View(filmler);
        }
    }
}