using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class ProductController:Controller
    {
        private IProductRepository repasitory;

        public ProductController(IProductRepository repo)
        {
            repasitory = repo;
        }

        public ViewResult List() => View(repasitory.Products);
    }
}
