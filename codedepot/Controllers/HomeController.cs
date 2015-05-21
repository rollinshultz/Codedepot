using codedepot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codedepot.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "What is the Codedepot and what can it do for you?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You can contact us through the email app below.";

            return View();
        }

        public ActionResult Code()
        {
            List<Code> snippets = new List<Code>();

            ViewBag.Message = "Share your code, classes, libraries, and snippets.";

            return RedirectToAction("Index", "Code");
        }

        public ActionResult Articles()
        {
            ViewBag.Message = "Read and Post articels to learn and share knowledge.";

            return RedirectToAction("Index", "Articles");
        }

        public ActionResult Tutorials()
        {
            ViewBag.Message = "Learn how to program or help others learn.";

            return RedirectToAction("Index", "Tutorials");
        }
        public ActionResult Portfolios()
        {
            ViewBag.Message = "Learn how to program or help others learn.";

            return RedirectToAction("Index", "Portfolios");
        }
        public ActionResult Forum()
        {
            ViewBag.Message = "Learn how to program or help others learn.";

            return RedirectToAction("Index", "Forum");
        }
    }
}