using DDAC_Assignment.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DDAC_Assignment.Models;

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

        public async Task<IActionResult> SingleOrderPage(int ? OrderID)
        {
            if(OrderID == null)
            {
                return NotFound("Order ID is not Found");
            }
            else
            {
                var orderProduct = from op in _context.OrderProduct
                                   select op;
                orderProduct = orderProduct.Where(op => op.OrderID.Equals(OrderID));

                var orderProducts = await orderProduct.ToListAsync();
                var order = await _context.Order.FindAsync(OrderID);
                return View(new OrderFullInfo { order = order, orderProducts = orderProducts });
            }
            
        }
    }
}
