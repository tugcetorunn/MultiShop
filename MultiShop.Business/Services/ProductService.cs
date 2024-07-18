using MultiShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Business
{
    public class ProductService : IProductService
    {
        private readonly MultiShopContext context;
        public ProductService(MultiShopContext _context)
        {
            context = _context;
        }
        public List<Product> GetProducts()
        {
            var list = context.Products.ToList();
            return list;
        }

        public Product? GetProductByCategory(int id)
        {
            var product = context.Products.Where(c => c.CategoryId == id).FirstOrDefault();
            return product;
        }
    }
}
