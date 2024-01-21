using Microsoft.AspNetCore.Mvc;
using TillApp.Shared.Models;

namespace TillApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = new List<Product>
        {
            new Product { Name = "Pizza", Price = 10.50m },
            new Product { Name = "Burger", Price = 8.00m },
            new Product { Name = "Pasta", Price = 12.75m },
            new Product { Name = "Salad", Price = 7.50m },
            new Product { Name = "Chicken Sandwich", Price = 9.50m },
            new Product { Name = "Steak", Price = 18.50m },
            new Product { Name = "Fish and Chips", Price = 14.25m },
            new Product { Name = "Sushi", Price = 22.50m },
            new Product { Name = "Grilled Salmon", Price = 17.75m },
            new Product { Name = "Shrimp", Price = 15.75m }
            };

            return Ok(products);
        }
    }
}
