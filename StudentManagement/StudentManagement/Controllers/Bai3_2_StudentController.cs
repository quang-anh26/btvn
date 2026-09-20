using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        // GET: /Student/Info
        public ActionResult Info()
        {
            ViewBag.Name = "Nguyễn Văn A";      // ViewBag
            ViewData["Age"] = 20;                // ViewData

            var model = new StudentModel { Major = "CNTT" }; // Model

            return View("Bai3_3_Info", model);
        }
    }
}