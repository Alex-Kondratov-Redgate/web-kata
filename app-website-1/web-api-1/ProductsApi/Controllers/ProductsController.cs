using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProductsApi.Model;
using ProductsApi.Stores;

namespace ProductsApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private ProductStore _store;

        public ProductsController(ProductStore store)
        {
            _store = store;
        }

        [HttpGet]
        [Route("{name?}")]
        public IEnumerable<Product> Get(string name)
        {
            Console.WriteLine(name);
            return name == null ? _store.GetAll() : _store.GetByName(name);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Product product)
        {
            _store.Add(product);
            return Ok();
        }
    }
}