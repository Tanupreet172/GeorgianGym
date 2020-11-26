using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeorgianGym.Data;
using Microsoft.AspNetCore.Mvc;

namespace GeorgianGym.Controllers
{
    public class ServicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServicesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Product.OrderBy(p => p.Name).ToList();
            return View(products);
        }
        
    }
}
