using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        /*
        public ViewResult Index()
        {
            /*
            List<string> results = new List<string>();
            
            foreach(Product p in Product.GetProducts())
            {
                string name = p?.Name ?? "<No Name>";
                string category = p?.Category ?? "<No Name>";
                decimal? price = p?.Price ?? 0;
                string relatedName = p?.Related?.Name ?? "<None>";
                results.Add($"Name: {name}, Category: {category}, Price: {price}, Related: {relatedName}");
            }
            return View(results);
            */
        /*
        ShoppingCart cart
                  = new ShoppingCart { Products = Product.GetProducts() };
        decimal cartTotal = cart.TotalPrices();
        return View("Index", new string[] { $"Total: {cartTotal:C2}" });
    */
        /*   // return View(Product.GetProducts().Select(p => p?.Name));
           var products = new[] {
               new { Name = "Kayak", Price = 275M },
               new { Name = "Lifejacket", Price = 48.95M },
               new { Name = "Soccer ball", Price = 19.50M },
               new { Name = "Corner flag", Price = 34.95M },
               };
           //return View(products.Select(p => p?.Name));
           return View(products.Select(p => p.GetType().Name));
       }
       */
        /*
         public async Task<ViewResult> Index()
         {
             long? length = await MyAsyncMethods.GetPageLength();
             return View(new string[] { $"Length: {length}" });
         }
         */

        public ViewResult Index()
        {
            var products = new[] {
                new { Name = "Kayak", Price = 275M },
                new { Name = "Lifejacket", Price = 48.95M },
                new { Name = "Soccer ball", Price = 19.50M },
                new { Name = "Corner flag", Price = 34.95M }
                };
            return View(products.Select(p =>
            $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }
    }
}
