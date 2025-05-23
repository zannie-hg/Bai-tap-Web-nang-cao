using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebsiteBanHangHutech.Models;
using WebsiteBanHangHutech.Repository;

namespace WebsiteBanHangHutech.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
      
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        // Display a list of products
        public IActionResult Index()
        {
            var products = _productRepository.GetAll();
            return View(products);
        }

   
    }
}
