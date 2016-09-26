using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models.ViewModels;
using KerobsLibrary;

namespace web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            VMPalendrome model = new VMPalendrome();
            return View();
        }


        [HttpPost]
        public ActionResult Index(VMPalendrome model)
        {
            IUtility _service = (IUtility)new Utility();
            List<sText> olist = _service.GetPalindromeWords(model.InputString);
            ViewBag.olist = olist;
            return View();
        }
    }
}
