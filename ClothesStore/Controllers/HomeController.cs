using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothesStore.Controllers
{
   public class HomeController : Controller
   {
      public ActionResult Index()
      {
         return View();
      }

      public ActionResult About()
      {
         
         return View();
      }

      public ActionResult Contact()
      {
         //ViewBag.Title = "Contact";

         return View();
      }

      public ActionResult Item()
      {
         return View();
      }
      public ActionResult Chat()
      {
         return View();
      }
   }
}