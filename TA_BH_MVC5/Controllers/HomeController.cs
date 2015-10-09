using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TA_BH_MVC5.Models;

namespace TA_BH_MVC5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetCommands(string term)
        {
            using (var db = new ApplicationDbContext())
            {
                var results = (from c in db.Commands
                               select new
                               {
                                   val = c
                               });

                return Json(results, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public Command GetCommand(string code)
        {
            using (var db = new ApplicationDbContext())
            {
                return (from c in db.Commands.Where(x => x.Code == code) select c).FirstOrDefault();
            }
        }
        public ActionResult DoCommand(string goCommand, string service, string handler)
        {
            Command result;
            if (goCommand != null)
            {
                result = GetCommand(goCommand);
            }

            if (result == null)
            {
                result = new Command {Controller = service, Action = handler};
            }
            return RedirectToActionPermanent(result.Action, result.Controller);
        }

    }
}