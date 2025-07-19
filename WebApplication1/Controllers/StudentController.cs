using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            /*ViewBag.Message = "Hello from controller";
            ViewBag.AAA = "AAA";
            ViewData["Message"] = "Hello From Controller View Data";
            return View();*/

            /*TempData["Status"] = "Saved Successfully";
            return Redirect("/Home/Privacy");*/

            //var student1 = new StudentModel();

            //student1.Id = 1;
            //student1.Name = "Test";

            //return View(student1);


            var students = new List<StudentModel>();
            students.Add(new StudentModel { Id = 1, Name = "Student 1" });
            students.Add(new StudentModel { Id = 2, Name = "Student 2" });
            students.Add(new StudentModel { Id = 3, Name = "Student 3" });

            return View(students);
        }
    }
}
