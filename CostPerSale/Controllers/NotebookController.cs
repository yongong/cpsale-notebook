using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CostPerSale.Controllers
{
    public class NotebookController : Controller
    {
        public ActionResult VideoGame()
        {
            return View();
        }

        public ActionResult BusinessOffice()
        {
            return View();
        }

        public ActionResult Hot()
        {
            return View();
        }
    }
}
