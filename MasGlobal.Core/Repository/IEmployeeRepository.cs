using MasGlobal.Core.Entities;
using System.Collections.Generic;

namespace MasGlobal.Core.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployee();
    }
}