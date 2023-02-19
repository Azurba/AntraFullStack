using DotNetConcepts.Entities;
using DotNetConcepts.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DotNetConcepts.MapHelper;
using DotNetConcepts.Models.RequestModels;

namespace DotNetConcepts.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public static StudentCourseRequestModel MapToStudentCourseRequestModel(Student student, Course course)
        {
            StudentCourseRequestModel model = new StudentCourseRequestModel();
            model.StudentAge = student.Id;
            model.StudentName = student.Name;
            model.StudentAge = student.Age;
            model.CourseDifficulty = course.Difficulty;
            model.CourseId = course.Id;
            model.CourseName = course.Name;
            return model;
        }


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StudentEnrollment()
        {
            Student student = new Student { Id = 1, Age = 99, Name = "Sam" };

            var course = new Course { Id = 100, Name = "Biology", Difficulty = "Advanced" };
            var studentCourse = MapToStudentCourseRequestModel(student, course);
            return View(studentCourse);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}