using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDog.Data;

namespace WebAppDog
{
    public class DogsController : Controller
    {

        private readonly ApplicationDbContext context;

        public DogsController(ApplicationDbContext context)
        {
            this.context = context;
        }
    
        public IActionResult Create()
        {
            return this.View();
        }

    }
}
