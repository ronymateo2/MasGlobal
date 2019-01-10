﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MasGlobal.Core.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ContractTypeName ContractTypeName { get; set; }

        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public string RoleDescription { get; set; }

        public double HourlySalary { get; set; }

        public double MonthlySalary { get; set; }
    }
}
