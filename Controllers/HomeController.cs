using Microsoft.AspNetCore.Mvc;
namespace SkySea_Commerce.Controllers;

public class HomeController : Controller

{
    
    public ActionResult Index()
    {
        int number1 = 10;
        int number2 = 20;
        int sum = number1 + number2;

        ViewData["Sum"] = sum; 

        return View(); 

    }
    
    public ActionResult About()
    {
        return View(); 
    }

    
    public ActionResult Contact() 
    {
        return View();
    }

}
