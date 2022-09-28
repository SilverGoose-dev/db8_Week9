using Dapper;
using Dapper.Contrib.Extensions;
using DapperConsole;
using MySql.Data.MySqlClient;


var db = new MySqlConnection("Server=127.0.0.1;Database=business;Uid=root;Pwd=abc123");
List<Employee> emps = db.GetAll<Employee>().ToList();

foreach (Employee emp in emps)
{
    Console.WriteLine(emp);
}

//Let's add a new employee
//Leave out the ID. Let the DB creat that for use
//Employee e1 = new Employee()
//{
//    firstname = "Al",
//    lastname = "Camargo",
//    phone = "555-555-1234",
//    email = "n@n.com",
//    department = "ACCT"
//};

//db.Insert(e1);        //comment out when done using so it won't add again


// Let's delete the instance at 28
//db.Delete(new Employee(){ id = 28 });
Console.WriteLine();
Console.WriteLine("Let's just read a single entry by ID. Let's do ID 5");

Employee e2 = db.Get<Employee>(5);
Console.WriteLine(e2);


//Noew let's change the spelling from Emily to Emilie.

//e2.firstname = "Emilie";
//db.Update<Employee>(e2);

Console.WriteLine();
Console.WriteLine("Let's get all employees who work in the IT dept");

//List<Employee> emps2 = db.Query<Employee>("select * from employee where department = 'IT").ToList();
//foreach (Employee emp in emps2)
//{
//    Console.WriteLine(emp);
//}

List<Department> dept = db.GetAll<Department>().ToList();

foreach (Department depts in dept)
{
    Console.WriteLine(depts);
}