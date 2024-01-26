using Domain.Models;

namespace Infrastructure.Servises;

public class EmployeeServises
{
    List<Employee> employees = new List<Employee>();
    public List<Employee> GetEmployees()
    {
        return employees;
    }
    public void AddEmployees(Employee employee)
    {
        employees.Add(employee);
    } 
    public void UpdateEmployees(Employee employee)
    {
        foreach (var item in employees)
        {
            if(item.Id == employee.Id)
            {
                item.Id = employee.Id;
                item.FirstName = employee.FirstName;
                item.LastName = employee.LastName;
                item.BirthDate = employee.BirthDate;
                item.Salary = employee.Salary;

            
            }
        }
            
    }
    public void DeleteEmployee(int id)
    {

        foreach (var item in employees)
        {
            if(item.Id == id)
            employees.Remove(item);
            
        }
        
    }
    public int CountEmployee(){
        return employees.Count;
    }

}
