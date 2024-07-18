using MultiShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Business.Dtos
{
    public class CategoryDto : BaseEntityDto
    {
        public int CategoryId { get; set; }
        public int? ParentCategoryId { get; set; }
        public required string CategoryName { get; set; }
        public string? Image { get; set; }
        public List<Product>? Products { get; set; }
    }
}
