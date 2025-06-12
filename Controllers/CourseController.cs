using SkySea_Commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace SkySea_Commerce.Controllers
{
    public class CourseController : Controller
    {
        List<Course> courses = new List<Course>{
                    new Course { Title = "C# Programming", Image = "c-sharp.png"},
                    new Course { Title = "Python Programming", Image = "python.jpg"},
                    new Course { Title = "Java Programming", Image = "java.jpg"},
                    new Course { Title = "Angular Programming", Image = "angular.jpg"},
            };
        public ActionResult Index()
        {
            return View(courses);
        }




        public ActionResult List()
        {
            // Course[] courses = [course1, course2, course3];

            return View(courses);
        }

        public ActionResult Details()
        {

            Course course1 = new Course();

            course1.Title = "C# Programming";
            course1.Image = "c-sharp.png";


            return View(course1);
        }
    }
}