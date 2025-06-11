using SkySea_Commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace SkySea_Commerce.Controllers
{
    public class CourseController : Controller
    {
       
        public ActionResult Index()
        {
            return View(); 
        }



        
        public ActionResult  List()
        {

            string[] courseNames = ["C# Programming", "Python for Beginners"];
            string[] courseDescriptions = [
                "Learn the fundamentals of C# programming.",
                "An introduction to Python for new programmers."
            ];

            string[] courseImages = ["c-sharp.png", "python.jpg"];

            ViewData["CourseName1"] = courseNames[0];
            ViewData["CourseName2"] = courseNames[1];
            ViewData["CourseDescription1"] = courseDescriptions[0];
            ViewData["CourseDescription2"] = courseDescriptions[1];
            ViewData["CourseImage1"] = courseImages[0];
            ViewData["CourseImage2"] = courseImages[1];
            
             




            return View();
        }
        
        public ActionResult  Details()
        {

            Course course1 = new Course();

            course1.Title = "C# Programming";
            course1.Image = "c-sharp.png";


            return View(course1); 
        }
    }
} 