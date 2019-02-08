using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace AvanadeAPI.Controllers
{
   
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            List<String> lst = new List<string>();
            lst.Add("lkjhjlkh");

            foreach (String s in lst)
            {

            }

            String[] lst_s = lst.ToArray();
            return View();
        }

        public ActionResult NewPage()
        {
            return View();
        }
    }
}
