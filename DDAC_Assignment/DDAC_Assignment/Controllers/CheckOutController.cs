using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDAC_Assignment.Data;
using DDAC_Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using DDAC_Assignment.Areas.Identity.Data;

namespace DDAC_Assignment.Controllers
{
    public class CheckOutController : Controller
    {
        //Create variable to link to db
        private readonly DDAC_AssignmentContext _context;
        private readonly UserManager<RT_Pastry_User> _userManager;

        //Constructor to initialize the db connection
        public CheckOutController(DDAC_AssignmentContext context, UserManager<RT_Pastry_User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var cartlist = await _context.Cart.ToListAsync();
            var temp = 0m;
            foreach(var item in cartlist)
            {
                if(item.UserID == _userManager.GetUserId(User))
                {
                    temp = temp + item.ProductSubTotal;
                }
            }
            ViewBag.total = temp;
            ViewBag.userid = _userManager.GetUserId(User);
            return View(cartlist);
        }

        //Function: Place order
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CheckOut(Order order)
        {
            order.UserID = _userManager.GetUserId(User);

            var cartlist = await _context.Cart.ToListAsync();
            var total = 0m;
            foreach (var item in cartlist)
            {
                if (item.UserID == _userManager.GetUserId(User))
                {
                    total = total + item.ProductSubTotal;
                }
            }
            order.TotalPrice = total;

            var currentDate = DateTime.Now;
            order.DatePlacedOn = currentDate;
            order.EstimatedArrivalDate = currentDate.AddMinutes(30);
            order.DeliveryStatus = "Pending";
            order.PaymentStatus = "Completed";

            //Add to order
            _context.Order.Add(order);
            await _context.SaveChangesAsync();

            var orderlist = await _context.Order.ToListAsync();
            var newOrderID = new int();
            foreach (var item in orderlist)
            {
                if (item.UserID == _userManager.GetUserId(User))
                {
                    newOrderID = item.OrderID;
                }
            }

            //Remove all from cart
            foreach (var item in cartlist)
            {
                if (item.UserID == _userManager.GetUserId(User))
                {
                    _context.OrderProduct.Add(new OrderProduct
                    {
                        OrderID = newOrderID,
                        ProductID = item.ProductID,
                        ProductName = item.ProductName,
                        ProductQuantity = item.ProductQuantity,
                        ProductUnitPrice = item.ProductPrice,
                        OrderRating = 0,
                        OrderComment = ""
                    });

                    _context.Cart.Remove(item);
                }
            }


            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Cart");
        }
    }
}
