using System.Collections.Generic;
using MasGlobal.Core.Entities;

namespace MasGlobal.Core.Services
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeInfo> GetAllEmployes();
        EmployeeInfo GetEmployeeById(int id);
    }
}