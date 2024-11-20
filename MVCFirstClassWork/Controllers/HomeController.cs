using Microsoft.AspNetCore.Mvc;
using MVCFirstClassWork.Models;
using MVCFirstClassWork.ViewModels;

namespace MVCFirstClassWork.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            List<Product> products = new List<Product>()
            {
                new Product(){ Image="https://i0.wp.com/picjumbo.com/wp-content/uploads/camping-on-top-of-the-mountain-during-sunset-free-photo.jpg?w=600&quality=80",Name="Dag",Description="so beautifullll",Price=156.2m,DisCountPrice=12m,Category="Landscape",Color="Sarii"},
                new Product(){ Image="https://i0.wp.com/picjumbo.com/wp-content/uploads/camping-on-top-of-the-mountain-during-sunset-free-photo.jpg?w=600&quality=80",Name=" Basga Dag",Description="eh iste",Price=15.2m,DisCountPrice=2.1m,Category="Landscape",Color="Ag"}

            };
            ProductVM productsVM = new ProductVM
            {
                Products = products
            };
            return View(productsVM);
        }
    }
}
