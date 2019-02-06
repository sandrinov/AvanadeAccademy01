using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace AvanadeAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class WetherController : Controller
    {
        // GET: Wether
        public ActionResult Index()
        {
            return View();
        }

       
    }
}