using EmployeesApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeesApi.Services
{
    public interface IEmployeeCollectionService : ICollectionService<Employee>
    {
        Task<List<Employee>> GetEmployeeByTeamLeaderId(Guid teamLeaderId);
    }
}
