using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Analytics.Controllers
{
    public class WebAnalyticsController : Controller
    {
        //
        // GET: /WebAnalytics/

        public ActionResult Index()
        {
            return View("Index");
        }
        public ActionResult TestPage()
        {
            return View("Test1");
        }

    }
}
