using BookStoreMVCWeb.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStoreMVCWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class OrderController : Controller
    {
        private readonly BookStoreMVCWebContext _context;

        public OrderController(BookStoreMVCWebContext context)
        {
            _context = context;
        }
        public async Task< IActionResult> Index()
        {
            return View(await _context.Orders.OrderByDescending(p=>p.Id).ToListAsync());
        }
    }
}
