namespace EmployeesApi.Controllers
{
    using EmployeesApi.Models;
    using EmployeesApi.Services;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="EmployeesController" />.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        /// <summary>
        /// Defines the _employeeCollectionService.
        /// </summary>
        internal IEmployeeCollectionService _employeeCollectionService;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeesController"/> class.
        /// </summary>
        /// <param name="employeeCollectionService">The employeeCollectionService<see cref="IEmployeeCollectionService"/>.</param>
        public EmployeesController(IEmployeeCollectionService employeeCollectionService)
        {
            _employeeCollectionService = employeeCollectionService ?? throw new ArgumentNullException(nameof(employeeCollectionService));
        }

        /// <summary>
        /// The GetEmployees.
        /// </summary>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            List<Employee> employees = await _employeeCollectionService.GetAll();
            if (employees.Count == 0)
            {
                return NoContent();
            }
            return Ok(employees);
        }

        /// <summary>
        /// The CreateEmployee.
        /// </summary>
        /// <param name="employee">The employee<see cref="Employee"/>.</param>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPost]
        public async Task<IActionResult> CreateEmployee([FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee cannot be null");
            }
            await _employeeCollectionService.Create(employee);
            return Ok(employee);
        }

        /// <summary>
        /// The UpdateEmployee.
        /// </summary>
        /// <param name="id">The id<see cref="Guid"/>.</param>
        /// <param name="employee">The employee<see cref="Employee"/>.</param>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(Guid id, [FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee cannot be null");
            }

            bool isUpdated = await _employeeCollectionService.Update(id, employee);
            if (!isUpdated)
            {
                return NotFound("Employee not found!");
            }

            return Ok();
        }

        /// <summary>
        /// The DeleteEmployee.
        /// </summary>
        /// <param name="id">The id<see cref="Guid"/>.</param>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(Guid id)
        {
            bool isDeleted = await _employeeCollectionService.Delete(id);
            if (!isDeleted)
            {
                return NotFound();
            }
            return Ok();
        }

        /// <summary>
        /// The GetEmployeeByTeamLeaderId.
        /// </summary>
        /// <param name="teamLeaderId">The teamLeaderId<see cref="Guid"/>.</param>
        /// <returns>The <see cref="Task{IActionResult}"/>.</returns>
        [HttpGet("{teamLeaderId}")]
        public async Task<IActionResult> GetEmployeeByTeamLeaderId(Guid teamLeaderId)
        {
            List<Employee> employees = await _employeeCollectionService.GetEmployeeByTeamLeaderId(teamLeaderId);
            if (employees.Count == 0)
            {
                return NoContent();
            }
            return Ok(employees);
        }
    }
}
