using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Data;
using Store.Models;
using Store.Services;

namespace Store.Controllers
{
    public class OperationController : Controller
    {
        private readonly IDataBaseServices dataBaseServices;

        public OperationController(IDataBaseServices dataBaseServices)
        {
            this.dataBaseServices = dataBaseServices;
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(ProductCreateBindingMode bindingMode)
        {
            if (this.ModelState.IsValid)
            {
                Product product = dataBaseServices.bindProduct(bindingMode);

                dataBaseServices.SaveProduct(product);

                return this.RedirectToAction("Create");
            }

            return this.View();
        }
    }
}
