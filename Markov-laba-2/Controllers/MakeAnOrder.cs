using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Markov_laba_2.Data;
using Markov_laba_2.Models;
namespace Markov_laba_2.Controllers
{
    public class MakeAnOrder : Controller
    {
        private readonly Markov_laba_2Context _context;

        public MakeAnOrder(Markov_laba_2Context context)
        {
            _context = context;
        }

        // GET: Clients
        public async Task<IActionResult> Index()
        {
            return View(await _context.Restaurant.ToListAsync());
        }
    }
}
