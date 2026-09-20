using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/Index
        public string Index()
        {
            return "Welcome to ASP.NET MVC";
        }

        // GET: /Home/About
        public string About()
        {
            return "Sinh viên: Nguyễn Văn A";
        }

        // GET: /Home/Contact
        public string Contact()
        {
            return "Email: nguyenvana@student.edu.vn";
        }
    }
}