namespace SkySea_Commerce.Models;

public class Product
{
    public string? productTitle { get; set; }
    public string productDescription { get; set; } = null!;
    public double productPrice { get; set; }
    public string? productImage { get; set; }
    public bool isAvailable { get; set; }

}