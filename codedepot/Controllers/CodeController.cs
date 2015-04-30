using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using codedepot.Models;

namespace codedepot.Controllers
{
    public class CodeController : Controller//, codedepot.Controllers.ICodeController
    {

        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Code
        public ActionResult Index()
        {
                       
            return View(db.snippets.ToList());
        }
        public ActionResult GeneralContent()
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            List<Code> snippets = new List<Code>();
            snippets = Db.snippets.ToList();
            if (!ModelState.IsValid)
            {
                return View(snippets);    
            }
            return View();
        }
    }
}