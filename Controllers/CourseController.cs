using Microsoft.AspNetCore.Mvc;

namespace SkySea_Commerce.Controllers
{
    public class CourseController : Controller
    {
        // localhost:5081/course
        public ActionResult Index()
        {
            return View(); // Views/Course/Index.cshtml
        }



        // localhost:5081/course/list
        public ActionResult  List()
        {
            return View(); // Views/Course/List.cshtml
        }
        // localhost:5081/course/details
        public ActionResult  Details()
        {
            return View(); // Views/Course/Details.cshtml
        }
    }
} 