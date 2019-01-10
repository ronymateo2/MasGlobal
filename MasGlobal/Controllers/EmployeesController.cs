using MasGlobal.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MasGlobal.Controllers
{
    public class EmployeesController : ApiController
    {
        private readonly IEmployeeService service;

        // TODO: Apply Dependecy Injection
        public EmployeesController()
            :this(new EmployeeService())
        {
           
        }

        public EmployeesController(IEmployeeService service)
        {
            this.service = service;
        }

        // GET api/Employees
        public IEnumerable<Object> Get()
        {
            return this.service.GetAllEmployes();
          
        }

        // GET api/Employees/5
        public Object Get(int id)
        {
            return this.service.GetEmployeeById(id);
        }


    }
}
