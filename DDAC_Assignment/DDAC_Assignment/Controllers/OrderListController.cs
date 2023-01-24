using DDAC_Assignment.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DDAC_Assignment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace DDAC_Assignment.Controllers
{
    public class OrderListController : Controller
    {
        private readonly DDAC_AssignmentContext _context;

        public OrderListController(DDAC_AssignmentContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var order1 = from o in _context.Order
                         select o;
            var order = await _context.Order.ToListAsync();
            return View(order);
        }

        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> editOrderPage(int? OrderID)
        {
            if (OrderID == null)
            {
                return NotFound("Order ID not found!");
            }
            return View(await _context.Order.FindAsync(OrderID));
        }

        //function: update the edit information
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> processEditOrderPage(Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Order.Update(order);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "OrderList", new { msg = "Review is updated!" });
            }
            return View("editOrderPage", order.OrderID);
        }

        public async Task<IActionResult> Review(int? OrderProductID)
        {
            if (OrderProductID == null)
            {
                return NotFound("Order Product ID not found!");
            }

            return View(await _context.OrderProduct.FindAsync(OrderProductID));
        }

        //function: update the edit information
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> processReview(OrderProduct orderProduct)
        {
            if (ModelState.IsValid)
            {
                _context.OrderProduct.Update(orderProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "OrderList", new { msg = "Review is updated!" });
            }
            return View("Review", orderProduct);
        }

        public async Task<IActionResult> SingleOrderPage(int? OrderID)
        {
            if (OrderID == null)
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
