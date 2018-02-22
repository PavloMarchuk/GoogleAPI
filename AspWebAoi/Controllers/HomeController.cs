using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspWebAoi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
			Dictionary<string, string> dict = new Dictionary<string, string>();
			dict.Add("DRIVING", "Автомобіль");
			dict.Add("BICYCLING", "Лісапед");
			dict.Add("TRANSIT", "на метро");
			dict.Add("WALKING", "Пішки");

			ViewBag.TravelMode = new SelectList(dict, "Key", "Value");
			
            return View();
        }
    }
}