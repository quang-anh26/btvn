using Microsoft.AspNetCore.Mvc;
using BaiTapMVC.Models;

namespace BaiTapMVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Login
        // Hiển thị form đăng nhập
        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginModel());
        }

        // POST: /Account/Login
        // Nhận dữ liệu từ form (Model Binding) và kiểm tra
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            var username = (model.Username ?? "").Trim();
            var password = (model.Password ?? "").Trim();

            if (username == "admin" && password == "123")
            {
                ViewBag.Message = "Login success";
                ViewBag.Success = true;
            }
            else
            {
                ViewBag.Message = "Login failed";
                ViewBag.Success = false;
            }

            return View(model);
        }
    }
}
