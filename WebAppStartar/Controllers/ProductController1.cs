using Microsoft.AspNetCore.Mvc;
using WebAppStartar.Models;

namespace WebAppStartar.Controllers
{
    public class ProductController1 : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product A", Price = 10.99m },
                new Product { Id = 2, Name = "Product B", Price = 19.99m },
                new Product { Id = 3, Name = "Product C", Price = 5.99m }
            };
            return View(products);
        }
    }
}
