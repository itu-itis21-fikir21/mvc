using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using uygulama1.Models;

namespace uygulama1.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        caglaEntities db = new caglaEntities();
        public ActionResult Index()
        {
            var comments = db.user_comment.ToList();
            return View(comments);
        }
    }
}