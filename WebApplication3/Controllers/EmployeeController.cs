using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Mohan",
                    Department = "IT",
                    Salary = 50000
                },
                new Employee
                {
                    Id = 2,
                    Name = "Rahul",
                    Department = "HR",
                    Salary = 40000
                }
            };

            return Ok(employees);
        }
    }
}