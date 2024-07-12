using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Data
{
    public class Product : BaseEntity
    {
        public int ProductId { get; set; }
        public required string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal? SalePrice { get; set; }
        public int Stock { get; set; }
        public required string Description { get; set; }
        public string? Detail { get; set; }
        public string? Information { get; set; }
        public Size? Size { get; set; } // ürüne göre size olup olmayacağı belli olacak
        public Color? Color { get; set; } // ürüne göre color olup olmayacağı belli olacak
        public int CategoryId { get; set; }
        public required Category Category { get; set; }
        public List<ProductImage>? ProductImages { get; set; }
        public List<ProductComment>? ProductComments { get; set; }


    }
}
