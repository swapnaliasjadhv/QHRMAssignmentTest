using Microsoft.AspNetCore.Mvc;
using QHRMAssiTest.Models;
using QHRMAssiTest.Repository;

namespace QHRMAssiTest.Controllers
{
    public class ProductsController : Controller
    {
       

        private readonly ProductRepository _productRepository;

        public ProductsController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var products = _productRepository.GetAllProducts();
            return View(products);
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
            return RedirectToAction("Index");
        }

        public IActionResult EditProduct(int id)
        {
            var product = _productRepository.GetAllProducts().FirstOrDefault(p => p.Id == id);
            return View(product);
        }

        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            _productRepository.UpdateProduct(product);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
            return RedirectToAction("Index");
        }

       
        [HttpGet]
        public IActionResult View(int id)
        {
            var product = _productRepository.GetAllProducts().FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

    }

}

