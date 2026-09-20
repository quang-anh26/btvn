using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class ProductController : Controller
    {
        // GET: /Product/Detail/5
        public string Detail(int? id)
        {
            if (id == null)
            {
                return "Lỗi: Vui lòng truyền Product ID. Ví dụ: /Product/Detail/5";
            }

            return $"Product ID = {id}";
        }

        // GET: /Product/Category?name=Laptop
        public string Category(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return "Lỗi: Vui lòng truyền tên category. Ví dụ: /Product/Category?name=Laptop";
            }

            return $"Category = {name}";
        }
    }
}