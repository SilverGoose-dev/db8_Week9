using Microsoft.AspNetCore.Mvc;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient.Authentication;
using MySql.Data.MySqlClient;
using BusinessPortal.Models;

namespace BusinessPortal.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            // List all of the departments
            var db = new MySqlConnection("Server=127.0.0.1;Database=business;Uid=root;Pwd=abc123;");
            IEnumerable<Department> depts = db.GetAll<Department>();

            return View(depts);
        }


        // C(R)UD - View a single department
        public IActionResult Detail(string id)
        {
            //started with Content(ID) to make sure the correct value is coming out
            //return Content(id);
            var db = new MySqlConnection("Server=127.0.0.1;Database=business;Uid=root;Pwd=abc123;");
            Department dep = db.Get<Department>(id);
            // Now let's get a list of people in the dept.
            List<Employee> emps = db.Query<Employee>($"select * from employee where department = '{id}'").ToList();
            ViewData["employees"] = emps;
            return View(dep);
        }

        // View that presents a form for adding a new department
        public IActionResult AddForm()
        {
            return View();
        }

        // (C)RUD An action that responds to the form for adding a new department

        // CRU(D) Delete a department
        public IActionResult Delete(string id)
        {
            var db = new MySqlConnection("Server=127.0.0.1;Database=business;Uid=root;Pwd=abc123;");
            Department dep = new Department() { ID = id };
            db.Delete<Department>(dep);
            return Content("Deleted!");
        }

        // CR(U)D Edit a department 
    }
}
