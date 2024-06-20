using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shlykovich.Services;

namespace Shlykovich.Controllers
{
    public class ProductController1 : Controller
    {
        private readonly IProductService _productService;

        public ProductController1(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();  
        }
    }
       
}
