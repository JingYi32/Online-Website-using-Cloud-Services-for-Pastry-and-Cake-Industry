using DDAC_Assignment.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DDAC_Assignment.Controllers
{
    public class OrderListController : Controller
    {
        private readonly DDAC_AssignmentContext _context;

        public OrderListController (DDAC_AssignmentContext context)
        {
            _context = context;
        }

        public async Task <IActionResult> Index()
        {
            var order = await _context.Order.ToListAsync();
            return View(order);
        }

        public IActionResult AddData()
        {
            return View();
        }
    }
}
