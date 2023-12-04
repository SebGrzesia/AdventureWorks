using AdventureWorks.Models;
using AdventureWorks.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorks.Controllers
{
    public class ProductController : Controller
    {
        private readonly AdventureWorks2019Context _context;
        public ProductController(AdventureWorks2019Context context) 
        {
            this._context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            List<ProductViewModel> productList = new List<ProductViewModel>();


            if (products != null)
            {
                foreach(var product in products)
                {
                    var ProductViewModel = new ProductViewModel()
                    {
                        ProductId = product.ProductId,
                        Name = product.Name,
                        MakeFlag = product.MakeFlag,
                        Color = product.Color,
                        StandardCost = product.StandardCost,
                        PriceDifference = product.ListPrice - product.StandardCost
                    };
                    productList.Add(ProductViewModel);
                }
                return View(productList);
            }
            return View(productList);
        }
    }
}
