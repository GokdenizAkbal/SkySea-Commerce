using SkySea_Commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace SkySea_Commerce.Controllers;

public class ProductsController : Controller
{
    List<Product> products =
        [
            new Product{
                Id = 1,
                productTitle = "iPhone 16",
                productDescription = "iPhone 16 128GB, Ultramarine",
                productPrice = 70.000,
                productImage = "iphone-16.jpeg",
                isAvailable = true,
                IsHome = true
            },
            new Product{
                Id = 2,
                productTitle = "iPhone 16e",
                productDescription = "iPhone 16e 128GB, White",
                productPrice = 50.000,
                productImage = "iphone-16e.jpeg",
                isAvailable = true,
                IsHome = true
            },
            new Product{
                Id = 3,
                productTitle = "iPhone 16 Pro",
                productDescription = "iPhone 16 Pro 128GB, Desert Titanium",
                productPrice = 90.000,
                productImage = "iphone-16-pro.jpeg",
                isAvailable = true,
                IsHome = false
            },



        ];
    public ActionResult Index()
    {
        List<Product> productS = products.Where(p => p.IsHome).ToList();
        return View(productS);
    }


    public ActionResult List()
    {

        return View(products);
    }

    public ActionResult Details(int id)
    {

        Product? product = products.Where(p => p.Id == id).FirstOrDefault();

        return View(product);
    }


}