﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collegues.DatabaseModels
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FamilyName { get; set; }
        public EmployeeType Type { get; set; }
        public DateTime EmployementFrom { get; set; }
        public List<Employee> Subordinates { set; get; }
    }
}
