using Store.Data;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Services
{
    public class DataBaseServices : IDataBaseServices
    {
        private readonly StoreDbContext context;

        public DataBaseServices(StoreDbContext context)
        {
            this.context = context;
        }

        public void SaveProduct(Product product)
        {
            context.Products.Add(product);

            context.SaveChanges();
        }

        public Product bindProduct(ProductCreateBindingMode productCreateBinding)
        {
            return new Product
            {
                ProductName = productCreateBinding.Name,
                Price = productCreateBinding.Price
            };
        }
    }
}
