using Microsoft.AspNetCore.Mvc;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using Lab_9._2_Coffeeshop_Product_List.Models;

namespace Lab_9._2_Coffeeshop_Product_List.Controllers
{
    public class CoffeeController : Controller
    {
        public IActionResult Index()
        {
            var db = new MySqlConnection("Server=127.0.0.1;Database=coffee;Uid=root;Pwd=abc123");
            List<Coffee> prods = db.GetAll<Coffee>().ToList();
            return View(prods);
        }

        public IActionResult Details(string id)
        {
            var db = new MySqlConnection("Server=127.0.0.1;Database=coffee;Uid=root;Pwd=abc123");
            Coffee coffee = db.Get<Coffee>(id);
            List<Coffee> details = db.Query<Coffee>($"select * from product where description = '{id}'").ToList();
            return View(coffee);
        }
    }
}
