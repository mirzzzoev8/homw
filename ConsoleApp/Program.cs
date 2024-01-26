using Domain.Models;
using Infrastructure.Servises;

// EmployeeServises
var employeeServise = new EmployeeServises();
var emp1 = new Employee()
{
    Id = 1,
    FirstName = "Ysuuf",
    LastName = "Mirzoev",
    BirthDate = new DateTime(1990,02,02),
    Salary = 1245m,
    Department = new Department()
    {
        Name = "It",
        Description = "this is test",
    }
};
employeeServise.AddEmployees(emp1);

var emp2 = new Employee()
{
    Id = 2,
    FirstName = "YM",
    LastName = "Mirzoevv",
    BirthDate = new DateTime(1990,02,02),
    Salary = 1245m,
    Department = new Department()
    {
        Name = "It",
        Description = "this is test",
    }
};
employeeServise.AddEmployees(emp2);
var emp3 = new Employee()
{
    Id = 3,
    FirstName = "YMMM",
    LastName = "Mirzoevv",
    BirthDate = new DateTime(1990,02,02),
    Salary = 1245m,
    Department = new Department()
    {
        Name = "It",
        Description = "this is test",
    }
};
employeeServise.AddEmployees(emp3);
System.Console.WriteLine(employeeServise.CountEmployee());

System.Console.WriteLine(employeeServise.GetEmployees());
foreach (var item in employeeServise.GetEmployees())
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.LastName);
    System.Console.WriteLine(item.Salary);
    System.Console.WriteLine("---------------------");
    

}
employeeServise.DeleteEmployee(2);
// DepartmentServises
var departmentservises = new DepartmentServises();
System.Console.WriteLine(departmentservises.CountDepartments());

var dep1 = new Department()
{
    Id = 1,
    Name = "Ysuuf",
    Description = "Mirzoev",
    Manager = emp1,
};
departmentservises.AddDepartments(dep1);
var dep2 = new Department()
{
    Id = 2,
    Name = "Ysuuf",
    Description = "Mirzoev",
    Manager = emp2,
};
departmentservises.AddDepartments(dep2);
var dep3 = new Department()
{
    Id = 3,
    Name = "Ysuuf",
    Description = "Mirzoev",
    Manager = emp3,
};
departmentservises.AddDepartments(dep3);
System.Console.WriteLine(departmentservises.CountDepartments());
System.Console.WriteLine(departmentservises.GetDepartments());
foreach (var item in departmentservises.GetDepartments())
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.Name);
    System.Console.WriteLine(item.Description);
    System.Console.WriteLine(item.Manager);
    System.Console.WriteLine("---------------------");
    

}

departmentservises.DeleteDepartments(4);