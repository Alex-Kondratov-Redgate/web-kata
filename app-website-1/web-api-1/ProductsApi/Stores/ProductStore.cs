
using System.Collections.Generic;
using ProductsApi.Model;
using System.Linq;

namespace ProductsApi.Stores
{
    public class ProductStore
    {
        private readonly List<Product> _products = new List<Product>();

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public IEnumerable<Product> GetByName(string name)
        {
            return _products.Where(p => p.Name == name);
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }
    }
}