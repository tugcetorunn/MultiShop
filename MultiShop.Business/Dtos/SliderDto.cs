using MultiShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Business.Dtos
{
    public class SliderDto
    {
        public int SliderId { get; set; }
        public required string Header { get; set; }
        public required string Content { get; set; }
        public required string Image { get; set; }
        public required Position Position { get; set; }
    }
}
