using BookStoreMVCWeb.Data;
using BookStoreMVCWeb.Models;
using BookStoreMVCWeb.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BookStoreMVCWeb.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        private readonly BookStoreMVCWebContext _context;
        public CheckoutController(BookStoreMVCWebContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Checkout()
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Email);
            if (userEmail == null)
            {
                return RedirectToAction("Login","Account");
            }
            else
            {
                var orderCode = Guid.NewGuid().ToString();
                var orderItem = new Order();
                orderItem.OrderCode = orderCode;
                orderItem.UserName = userEmail;
                orderItem.Status = 1;
                orderItem.CreatedDate = DateTime.Now;
                _context.Add(orderItem);
                _context.SaveChanges();
                //TempData["success"] = "Đơn hàng đã được tạo";
                //return RedirectToAction("Index", "Cart");
                List<CartItem> cartItems = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();
                foreach(var cartitem in cartItems)
                {
                    var orderDetail = new OrderDeatails();
                    orderDetail.UserName = userEmail;
                    orderDetail.OrderCode = orderCode;
                    orderDetail.Quantity = cartitem.Quantity;
                    orderDetail.Price = cartitem.Book.Price;
                    _context.Add(orderDetail);
                    _context.SaveChanges();
                }
                HttpContext.Session.Remove("Cart");
                TempData["success"] = "Checkout thành công, chờ duyệt ";
				return RedirectToAction("Index", "Cart");
			}
          
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Ordertails() 
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Email);
            if (userEmail == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var cartItems = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            var viewModel = new OrderDetailsViewModel()
            {
                UserName=userEmail,
                Email=userEmail,
                CartItems=cartItems
            };
            return View(viewModel);
        }
    }
}
