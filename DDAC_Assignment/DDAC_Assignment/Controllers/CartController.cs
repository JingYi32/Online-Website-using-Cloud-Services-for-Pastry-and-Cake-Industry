using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDAC_Assignment.Data;
using DDAC_Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace DDAC_Assignment.Controllers
{
    public class CartController : Controller
    {
        //Create variable to link to db
        private readonly DDAC_AssignmentContext _context;

        //Constructor to initialize the db connection
        public CartController(DDAC_AssignmentContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> Index()
        {
            var cartlist = await _context.Cart.ToListAsync();
            var temp = 0m;
            foreach (var item in cartlist)
            {
                if (item.UserID == 123)
                {
                    temp = temp + item.ProductSubTotal;
                }
            }
            ViewBag.total = temp;
            return View(cartlist);
        }

        public IActionResult checkOut()
        {
            return RedirectToAction("Index", "CheckOut");
        }

        public async Task<IActionResult> deleteActionCart(int CartID)
        {
            if (CartID == null)
            {
                return NotFound();
            }

            try
            {
                var cart = await _context.Cart.FindAsync(CartID);
                _context.Cart.Remove(cart);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Cart",
                    new { msg = "Cart of ID " + CartID + " is deleted from the table now!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Function: Load an edit page for product information
        public async Task<IActionResult> editActionCart(int CartID)
        {
            if (CartID == null)
            {
                return NotFound();
            }
            return View(await _context.Cart.FindAsync(CartID));
        }

        //Function: Process edit page information
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> processEditPageCart(Cart cart)
        {
            cart.ProductSubTotal = cart.ProductPrice * cart.ProductQuantity;

            if (ModelState.IsValid) //Form is valid
            {
                _context.Cart.Update(cart);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Cart",
                    new { msg = "Cart information of ID " + cart.CartID + " is updated now!" });
            }
            return View("editActionCart", cart); //Form is having error
        }
    }
}
