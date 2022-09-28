using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using DapperConsole2;


var db = new MySqlConnection("Server=127.0.0.1;Database=grocerystore;Uid=root;Pwd=abc123");
List<category> categories = db.GetAll<category>().ToList();
//Console.WriteLine("Categories\n");
//foreach (category category in categories)
//{
//    Console.WriteLine(category);
//}

//Console.WriteLine();
//Console.WriteLine();

List<product> prods = db.GetAll<product>().ToList();
Console.WriteLine("Products\n");
//product ptest = new product() { name = "Beer", description = "Cold and refreshing", price = 8.99m, inventory = 10, category = "BEVERAGE" };
//db.Insert(ptest);

//db.Delete(new product() { id = 14 });


foreach (product product in prods)
{
    Console.WriteLine(product);
}


product test = db.Get<product>(13);
test.name = "Craft Beer";

Console.WriteLine(test);

