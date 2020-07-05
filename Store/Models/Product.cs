using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Product
    {
        public int id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
