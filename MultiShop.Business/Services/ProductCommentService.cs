using MultiShop.Business.Interfaces;
using MultiShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Business.Services
{
    public class ProductCommentService : IProductCommentService
    {
        private readonly MultiShopContext context;
        public ProductCommentService(MultiShopContext _context)
        {
            context = _context;
        }

        public List<ProductComment> GetProductComments()
        {
            var comments = context.ProductComments.ToList();
            return comments;
        }
    }
}
