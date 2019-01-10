using MasGlobal.Core.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MasGlobal.Core.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public IEnumerable<Employee> GetAllEmployee()
        {
            using (var client = new HttpClient())
            {
                string apiEndpoint = "http://masglobaltestapi.azurewebsites.net/api/";

                client.BaseAddress = new Uri(apiEndpoint);
                //HTTP GET
                var responseTask = client.GetAsync("Employees");
                responseTask.Wait();

                var responseResult = responseTask.Result;
                if (responseResult.IsSuccessStatusCode)
                {
                    var result = responseResult.Content.ReadAsStringAsync().Result;
                    var employess = JsonConvert.DeserializeObject<IEnumerable<Employee>>(result);
                    return employess;
                }
                else
                {
                    throw new ApplicationException(responseResult.StatusCode.ToString());
                }
            }
        }
    }
}
