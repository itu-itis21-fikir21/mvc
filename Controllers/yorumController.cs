using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using uygulama1.Models;

namespace uygulama1.Controllers
{
    public class yorumController : Controller
    {
        caglaEntities db = new caglaEntities();

        // GET: yorum
        public ActionResult Index()
        {
            var yorumlar = db.user_comment.ToList();
            return View(yorumlar);
        }
    }
}