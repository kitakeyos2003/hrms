using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>(); 

        [HttpGet]
        public  IActionResult GetAll()
        {
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var employee = employees.SingleOrDefault(x => x.Id == id);
            if (employee == null)
            {
                return NotFound();
            } else
            {
                return Ok(employee);
            }
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            var emp = new Employee
            {
                Id = employee.Id,
                Name = employee.Name,
            };
            employees.Add(emp);
            return Ok(new
            {
                Success = true,
                Data = emp
            }); 
        }


        [HttpPut("{id}")]
        public IActionResult Edit(int id, Employee emp)
        {

            var employee = employees.SingleOrDefault(x => x.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            if (emp.Id != employee.Id)
            {
                return BadRequest();
            }
            employee.Name = emp.Name;
            return Ok();
        }

    }
}
