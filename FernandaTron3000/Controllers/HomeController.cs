using FernandaTron3000.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FernandaTron3000.Controllers
{
    public class HomeController : Controller
    {
        private Context db = new Context(); 
        public ActionResult Index()
        {            
            return View();
        }
    }
}