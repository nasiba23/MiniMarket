using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MiniMarket.Db;
using MiniMarket.Models;
using MiniMarket.Repositories.Product;

namespace MiniMarket.Controllers
{
    public class ProductController: Controller
    {
        private IProductRepository _productRep;
        private DataContext _db;

        public ProductController(IProductRepository productRep, DataContext db)
        {
            _productRep = productRep;
            _db = db;
        }
        public IActionResult ShowAdd()
        {
            ViewBag.Categories = _db.Categories.ToList();
            return View();
        }

        public IActionResult Add(Product product)
        {
            _productRep.Create(product);
            return RedirectToAction("Index", "Home");
        }
    }
}