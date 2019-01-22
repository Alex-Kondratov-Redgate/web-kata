using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProductsApi.Model;

namespace ProductsApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private static List<Product> _products;

        public ProductsController()
        {
            _products = new List<Product>();
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _products;
        }
    }
}