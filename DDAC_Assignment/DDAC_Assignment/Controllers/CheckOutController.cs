using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDAC_Assignment.Data;
using DDAC_Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace DDAC_Assignment.Controllers
{
    public class CheckOutController : Controller
    {
        //Create variable to link to db
        private readonly DDAC_AssignmentContext _context;

        //Constructor to initialize the db connection
        public CheckOutController(DDAC_AssignmentContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var cartlist = await _context.Cart.ToListAsync();
            var temp = 0m;
            foreach(var item in cartlist)
            {
                if(item.UserID == 123)
                {
                    temp = temp + item.ProductSubTotal;
                }
            }
            ViewBag.total = temp;
            return View(cartlist);
        }

        //Function: Place order
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CheckOut(Order order)
        {
            order.UserID = "123";

            var cartlist = await _context.Cart.ToListAsync();
            var total = 0m;
            foreach (var item in cartlist)
            {
                if (item.UserID == 123)
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
                if (item.UserID == 123.ToString())
                {
                    newOrderID = item.OrderID;
                }
            }

            //Remove all from cart
            foreach (var item in cartlist)
            {
                if (item.UserID == 123)
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

            //If form no issue, proceed
            /*if (ModelState.IsValid)
            {
                _context.Order.Add(new Order{
                    DatePlacedOn = DateTime.Now,
                    UserID = "123",
                    TotalPrice = 100,
                    PaymentMethod = "Payment",
                    PaymentStatus = "Completed",
                    DeliveryStatus = "Pending",
                    DeliveryContact = "0123208378",
                    DeliveryAddress = "Some address",
                    EstimatedArrivalDate = currentDate.AddMinutes(30)
                }); //Add
                await _context.SaveChangesAsync(); //Save
                return RedirectToAction("Index", "Cart");
            }*/

            /*//If form have issue, send back with error message
            return View("Index", cartlist);*/
        }
    }
}
