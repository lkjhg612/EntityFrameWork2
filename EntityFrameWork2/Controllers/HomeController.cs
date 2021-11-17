using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameWork2.Controllers
{
    public class HomeController : Controller
    {
        QuanCaPheEntities pheEntities = new QuanCaPheEntities();
        public ActionResult Index()
        {
            var cf = pheEntities.MatHangs.ToList(); 
            return View(cf);
        }
    }
}