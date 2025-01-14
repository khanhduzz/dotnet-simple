using ASPForSample.Data;
using ASPForSample.Models;
using ASPForSample.Models.Entitites;
using Microsoft.AspNetCore.Mvc;

namespace ASPForSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var allEmployees = dbContext.Employees.ToList();

            return Ok(allEmployees);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetEmployees(Guid id)
        {
            var employee = dbContext.Employees.Find(id);

            if (employee is null)
            {
                return NotFound("Employee not found with id: " + id);
            }

            return Ok(employee);
        }

        [HttpPost]
        public IActionResult AddNewEmployee(AddEmployeeDto addEmployeeDto)
        {
            var employeeEntity = new Employee()
            {
                Name = addEmployeeDto.Name,
                Email = addEmployeeDto.Email,
                Phone = addEmployeeDto.Phone,
                Salary = addEmployeeDto.Salary,
            };

            dbContext.Employees.Add(employeeEntity);
            dbContext.SaveChanges();

            return Ok(employeeEntity);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateEmployee(Guid id, UpdateEmployeeDto updateEmployeeDto)
        {
            var employee = dbContext.Employees.Find(id);
            
            if (employee is null)
            {
                return NotFound("Employee not found");
            }

            var employeeEntity = new Employee()
            {
                Name = updateEmployeeDto.Name,
                Email = updateEmployeeDto.Email,
                Phone = updateEmployeeDto.Phone,
                Salary = updateEmployeeDto.Salary,
            };

            dbContext.Employees.Update(employeeEntity);

            return Ok(employeeEntity);
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            var employee = dbContext.Employees.Find(id);

            if (employee is null)
            {
                return NotFound("Employee not found");
            }

            dbContext.Employees.Remove(employee);

            return NoContent();
        }
    }
}
