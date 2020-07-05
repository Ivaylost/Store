using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Order
    {
        public int id { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
