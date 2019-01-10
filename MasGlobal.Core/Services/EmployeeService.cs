using MasGlobal.Core.Entities;
using MasGlobal.Core.Repository;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MasGlobal.Core.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository respository;

        public EmployeeService() : this(new EmployeeRepository())
        {

        }


        public EmployeeService(IEmployeeRepository respository)
        {
            this.respository = respository;
        }

        public IEnumerable<EmployeeInfo> GetAllEmployes()
        {
            var factory = new EmployeeFactory();

            IEnumerable<Employee> employees = this.respository.GetAllEmployee();

            List<EmployeeInfo> employeeInfos = new List<EmployeeInfo>();

            foreach (var item in employees)
            {
                var employeeInfo  =  factory.Create(item);
                employeeInfos.Add(employeeInfo);
            }

            return employeeInfos;
        }

        public EmployeeInfo GetEmployeeById(int id)
        {
            var factory = new EmployeeFactory();
            
            IEnumerable<Employee> employees = this.respository.GetAllEmployee();

            var emp = (from e in employees
                    where e.Id == id
                    select e).FirstOrDefault();

            return factory.Create(emp);

        }
    }
}
