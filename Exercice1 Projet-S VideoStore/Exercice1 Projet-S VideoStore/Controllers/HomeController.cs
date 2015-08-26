using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetOpenAuth.OpenId.Extensions.AttributeExchange;

namespace Exercice1_Projet_S_VideoStore.Controllers
{
    public class HomeController : Controller
    {
        // Get HomeIndex()
        public ActionResult Index()
        {
            ViewBag.Message = "Yo Bitches";

            return View();
        }

        //Get HomeAbout()

        [ActionName("APropos")]
        public ActionResult About()
        {
            ViewBag.Message = "Suprise MotherFucker::Description page.";

            return View("About");
        }

        [Authorize]
        [Authorize(Users ="jp,max")]
        [Authorize(Roles = "administrator")]
        [HandleError(View = "Shared/Error.cshtml")]
        public ActionResult Contact()
        {
            ViewBag.MonMessage = "Envoyer un commentaire";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.MonMessage = "Merci de votre commentaire";

            return View();
        }

        public ActionResult Foo()
        {
            return View("About");
        }

        public ActionResult Serie(string parameter)
        {
            var serie = "MVC and SHIT";

            if (parameter == "min")
            {
                return Content(serie.ToLower());
            }
            if (parameter == "json")
            {
                return Json(new {name = "serie" , value = serie}, JsonRequestBehavior.AllowGet);
            }

            //return Content(serie);
            return RedirectToAction("Index");
        }
    }
}
