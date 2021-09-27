using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMvcApp.Controllers
{
    public class MyFirstController : Controller
    {
        //
        // GET: /MyFirst/

        public ActionResult Index()
        {
            return View();
        }

    }
}
