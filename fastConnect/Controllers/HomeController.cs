using fastConnect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fastConnect.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(Table tab)
        {
            if(ModelState.IsValid)
                TableRepository.AddPerson(tab);
            return View();
        }

        [HttpGet]
        public ActionResult List()
        {
            return View(TableRepository.GetTabList());
        }
    }
}