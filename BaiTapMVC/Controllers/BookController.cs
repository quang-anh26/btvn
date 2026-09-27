using Microsoft.AspNetCore.Mvc;
using BaiTapMVC.Models;

namespace BaiTapMVC.Controllers
{
    public class BookController : Controller
    {
        // Danh sách sách "cứng" (giả lập dữ liệu, chưa dùng database)
        private static List<BookModel> books = new List<BookModel>
        {
            new BookModel { Id = 1, Name = "Clean Code", Price = 20 },
            new BookModel { Id = 2, Name = "ASP.NET MVC", Price = 15 },
            new BookModel { Id = 3, Name = "Design Pattern", Price = 25 },
        };

        // Chức năng 1: GET /Book/Index -> Danh sách sách
        public IActionResult Index()
        {
            return View(books);
        }

        // Chức năng 2: GET /Book/Detail/1 -> Chi tiết sách
        public IActionResult Detail(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // Chức năng 3: GET /Book/Create -> Hiển thị form thêm sách
        [HttpGet]
        public IActionResult Create()
        {
            return View(new BookModel());
        }

        // Chức năng 3: POST /Book/Create -> Xử lý thêm sách
        [HttpPost]
        public IActionResult Create(BookModel model)
        {
            if (!ModelState.IsValid)
            {
                // Bài 3: trả lại form kèm thông báo lỗi (Data Annotation + ModelState)
                return View(model);
            }

            model.Id = books.Max(b => b.Id) + 1;
            books.Add(model);

            ViewBag.Message = "Thêm thành công";
            return View("Create", new BookModel());
        }
    }
}
