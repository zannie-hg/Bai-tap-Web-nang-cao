using System.Diagnostics;
using System.Reflection;
using DemoWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HomeModel message = new HomeModel();
            return View(message);

        }
        [HttpGet]
        public IActionResult Edit()
        {
           

            return View();
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            string message = "";
            if (ModelState.IsValid)
            {
                message = $"Product created successfully! Details:\n" +
                          $"Product Name: {product.ProductName}\n" +
                          $"Unit Price: {product.UnitPrice}\n" +
                          $"Units In Stock: {product.UnitsInStock}";
            }
            else
            {
                message = "Failed to create the product. Please try again";
            }
            return Content(message);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductEditModel model)
        {
            string message = "";
            if (ModelState.IsValid)
            {
                message = "Product " + model.Name + " created successfully!";
            }
            else
            {
                message = "Failed to create the product. Please try again";
            }
            return Content(message);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
