using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasGlobal.Core.Entities
{
    class EmployeeFactory
    {
        private IDictionary<ContractTypeName, Func<Employee, EmployeeInfo>> _creators;

        public EmployeeFactory()
        {
            this._creators = new Dictionary<ContractTypeName, Func<Employee, EmployeeInfo>>();

            this._creators.Add(ContractTypeName.HourlySalaryEmployee, (employee) =>
            {
                // TODO: create mapper
                var employeinfo = JsonConvert.DeserializeObject<EmployeeInfoHourlySalary>(JsonConvert.SerializeObject(employee));
                employeinfo.Salary = 120 * employee.HourlySalary * 12;

                return employeinfo;
            });

            this._creators.Add(ContractTypeName.MonthlySalaryEmployee, (employee) => {

                // TODO: create mapper
                var employeinfo = JsonConvert.DeserializeObject<EmployeeInfoMonthtlySalary>(JsonConvert.SerializeObject(employee));
                employeinfo.Salary = employee.MonthlySalary * 12;

                return employeinfo;
            });

        }

        public EmployeeInfo Create(Employee employee) {

            var concreteEmployee = this._creators[employee.ContractTypeName](employee);

            return concreteEmployee;

        }
    }
}
