using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReactMVC.Models;

namespace ReactMVC.Controllers
{
    public class HomeController : Controller
    {
        private static List<Comment> comments;

        public HomeController()
        {
            comments = new List<Comment>()
            {
                new Comment
                {
                    Id = 1,
                    Author = "Daniel Lo Nigro",
                    Text = "Hello ReactJS.NET World!"
                },
                new Comment
                {
                    Id = 2,
                    Author = "Pete Hunt",
                    Text = "This is one comment"
                },
                new Comment
                {
                    Id = 3,
                    Author = "Jordan Walke",
                    Text = "This is *another* comment"
                }
            };
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Comments()
        {
            return Json(comments, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult AddComment(Comment model)
        {
            model.Id = comments.Max(c => c.Id) + 1;
            comments.Add(model);
            return Content("Success :)");
        }
    }
}