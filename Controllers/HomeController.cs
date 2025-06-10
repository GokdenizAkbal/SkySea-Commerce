using Microsoft.AspNetCore.Mvc;
namespace SkySea_Commerce.Controllers;

public class HomeController : Controller

{
    // localhost:5081/home
    public ActionResult Index()
    {
        return View(); // View /Home/Index.cshtml

    }



    // localhost:5081/home/about
    public ActionResult About()
    {
        return View(); // View /Home/About.cshtml
    }

    // localhost:5081/home/contact
    public ActionResult Contact() // View /Home/Contact.cshtml
    {
        return View();
    }



}
