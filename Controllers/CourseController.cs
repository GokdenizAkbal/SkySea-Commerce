using SkySea_Commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace SkySea_Commerce.Controllers
{
    public class CourseController : Controller
    {
        List<Course> courses = new List<Course>{
                    new Course { Id = 1 , Title = "C# Programming", Image = "c-sharp.png", IsActive = true , IsHome = true},
                    new Course { Id = 2 , Title = "Python Programming", Image = "python.jpg", IsActive = true , IsHome = true },
                    new Course { Id = 3 , Title = "Java Programming", Image = "java.jpg", IsActive = true , IsHome = false },
                    new Course { Id = 4 , Title = "Angular Programming", Image = "angular.jpg", IsActive = true , IsHome = false },
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

        public ActionResult Details(int id)
        {
            Course? course = courses.Where(a => a.Id == id).FirstOrDefault();


            return View(course);
        }
    }
}