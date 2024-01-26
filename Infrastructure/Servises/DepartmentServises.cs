using Domain.Models;
namespace Infrastructure.Servises;

public class DepartmentServises
{
    List<Department> departments = new List<Department>();
    public List<Department> GetDepartments()
    {
        return departments;
    }
    public void AddDepartments(Department department)
    {
        departments.Add(department);
    } 
    public void UpdateDepartments(Department department)
    {
        foreach (var item in departments)
        {
            if(item.Id == department.Id)
            {
                item.Id = department.Id;
                item.Name = department.Name;
                item.Description = department.Description;
                item.Manager = department.Manager;
        
            }
        }
            
    }
    public void DeleteDepartments(int id)
    {

        foreach (var item in departments)
        {
            if(item.Id == id)
            departments.Remove(item);
            
        }
        
    }
    public int CountDepartments(){
        return departments.Count;
    }
}
