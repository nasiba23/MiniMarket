using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiniMarket.Models;
using MiniMarket.Repositories.Product;

namespace MiniMarket.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository _productRep;

        public HomeController(IProductRepository productRep)
        {
            _productRep = productRep;
        }
        public IActionResult Index()
        {
            return View(_productRep.GetAll());
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}