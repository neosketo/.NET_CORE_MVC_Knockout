using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SketoProductionAuthentication.Data;
using SketoProductionAuthentication.Models.Home;

namespace SketoProductionAuthentication.Controllers
{
    public class HomeController : Controller
    {
        private readonly MasterContext _db = new MasterContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            var modmodel = new HomeViewModel { Sent = false};
            return View(modmodel);

        }

        [HttpPost]
        public IActionResult Contact( HomeViewModel model)
        {
            model.Sent = true;


            return View(model);

        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
