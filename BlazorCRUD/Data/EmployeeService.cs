using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.Data
{
    public class EmployeeService
    {
        private readonly AppDbContext _db;

        public EmployeeService(AppDbContext db)
        {
            _db = db;
        }

        //for crus operation


        //Get All Employees

        public List<Employee> GetEmployee()
        {
            return _db.Employees.ToList();

        }

        //Inser Employee:
        public string Create(Employee employee)
        {
            _db.Employees.Add(employee);
            _db.SaveChanges();

            return "Save Successfully";
        }

        //Get Employee by ID
        public Employee GetEmployeeById(int id)
        {
            return _db.Employees.FirstOrDefault(e => e.EmployeeId == id);
        }

          //Update Employee:
          public string UpdateEmployee(Employee employee)
        {
            _db.Employees.Update(employee);
            _db.SaveChanges();

            return "Update successfully";
        }

        //Delete Employee
        public string DeleteEmployee(Employee employee)
        {
            _db.Remove(employee);
            _db.SaveChanges();

            return "delete Successfylly";
        }

    }
}
