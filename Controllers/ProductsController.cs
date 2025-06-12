using SkySea_Commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace SkySea_Commerce.Controllers;

public class ProductsController : Controller
{
    public ActionResult Index()
    {
        string[] courses = { "C# Programming", "Python Programming", "Java Programming" };

        return View(courses);
    }


    public ActionResult List()
    {
        List<Product> products = new List<Product>
        {
            new Product{
                productTitle = "iPhone 16",
                productDescription = "iPhone 16 128GB, Ultramarine",
                productPrice = 70.000,
                productImage = "iphone-16.jpeg",
                isAvailable = true
            },
            new Product{
                productTitle = "iPhone 16e",
                productDescription = "iPhone 16e 128GB, White",
                productPrice = 50.000,
                productImage = "iphone-16e.jpeg",
                isAvailable = true
            },
            new Product{
                productTitle = "iPhone 16 Pro",
                productDescription = "iPhone 16 Pro 128GB, Desert Titanium",
                productPrice = 90.000,
                productImage = "iphone-16-pro.jpeg",
                isAvailable = false
            },



        };

        return View(products);
    }

    public ActionResult Details()
    {

        Product product1 = new Product()
        {

            productTitle = "iPhone 13",
            productDescription = "iPhone 13 128GB, White",
            productPrice = 30.000,
            productImage = "iphone-13.jpg",
            isAvailable = true,
            productQuantity = 0

        };
        return View(product1);
    }


}