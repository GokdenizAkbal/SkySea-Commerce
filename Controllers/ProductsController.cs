using Microsoft.AspNetCore.Mvc;

namespace SkySea_Commerce;

public class ProductsController : Controller
{
    // localhost:5081/products
    public ActionResult Index()
    {
        return View(); // Views/Products/Index.cshtml
    }

    // localhost:5081/products/list
    public ActionResult List()
    {
        return View(); // Views/Products/List.cshtml
    }

    // localhost:5081/products/details
    public ActionResult Details()
    {
        return View(); // Views/Products/Details.cshtml
    }

    
}