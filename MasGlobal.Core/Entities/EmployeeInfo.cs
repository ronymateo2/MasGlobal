using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasGlobal.Core.Entities
{
    public class EmployeeInfo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ContractTypeName ContractTypeName { get; set; }

        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public string RoleDescription { get; set; }

        public double Salary { get; set; }
    }

    // TODO: FUTURE USES
    public class EmployeeInfoHourlySalary : EmployeeInfo
    {

    }

    public class EmployeeInfoMonthtlySalary : EmployeeInfo {
    }
}
