using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;


namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository _Product;
        public HomeController(IStoreRepository Product)
        {
            _Product = Product;
        }
        public IActionResult Index()
        {
            var Product = _Product.Products.ToList();
            return View(Product);
        }

        [HttpGet]

        public IActionResult AddToCart(int productId)
        {
            //Get this product from db
            var product = _Product.Products.Single(p => p.ProductID == productId);
            //Add new cartProduct into cart
            return View("Index");
        }
    }
}