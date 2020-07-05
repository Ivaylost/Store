﻿using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Services
{
    public interface IDataBaseServices
    {
        void SaveProduct(Product product);

        Product bindProduct(ProductCreateBindingMode productCreateBinding);
    }
}
