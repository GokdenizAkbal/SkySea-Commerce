using Microsoft.AspNetCore.Mvc;

namespace SkySea_Commerce;

public class ProductsController : Controller
{
       public ActionResult Index()
    {
        return View(); 
    }

    
    public ActionResult List()
    {
        return View(); 
    }

        public ActionResult Details()
    {

        string productTitle = "iPhone 13";
        string productDescription = "iPhone 13 128GB, White";
        string productPrice = "30.000";
        string productImage = "iphone-13.jpg";
        
        bool isAvailable = true;

        ViewData["ProductTitle"] = productTitle;
        ViewData["ProductDescription"] = productDescription;
        ViewData["ProductPrice"] = productPrice;
        ViewData["ProductImage"] = productImage;
        ViewData["IsAvailable"] = isAvailable;







        return View(); 
    }

    
}