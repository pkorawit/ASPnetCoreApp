using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RaiseYourHand.Models;

namespace WebApplication.Controllers
{
    public class HandController : Controller
    {
        private readonly HandDbContext _context;
        public HandController(HandDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {           
            return View(await _context.Hands.ToListAsync());
        }

        public IActionResult Create()
        {           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HandNo,UserName,Message")] Hand hand)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hand);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(hand);
        }



    }
}
