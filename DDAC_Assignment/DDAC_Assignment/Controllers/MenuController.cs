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
    public class MenuController : Controller
    {
        //Create variable to link to db
        private readonly DDAC_AssignmentContext _context;

        //Constructor to initialize the db connection
        public MenuController(DDAC_AssignmentContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var goods = from m in _context.Product
                        select m;

            if(!string.IsNullOrEmpty(searchString))
            {
                goods = goods.Where(s => s.ProductName.Contains(searchString));
            }
            return View(await goods.ToListAsync());
        }

        //Function: Process the selected product
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> processCart(Cart cart)
        {
            cart.ProductSubTotal = cart.ProductPrice * cart.ProductQuantity;

            //If form no issue, proceed
            if (ModelState.IsValid)
            {
                _context.Cart.Add(cart); //Add
                await _context.SaveChangesAsync(); //Save
                return RedirectToAction("Index", "Menu");
            }

            //If form have issue, send back with error message
            return View("Index", cart);
        }
    }
}
