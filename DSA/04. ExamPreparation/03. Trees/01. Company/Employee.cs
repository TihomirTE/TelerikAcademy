﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Company
{
    public class Employee
    {
        public Employee(string name)
        {
            this.Name = name;
            this.Salary = 1;
            this.Subordinates = new List<Employee>();
        }

        public List<Employee> Subordinates { get; private set; }

        public int Salary { get; set; }

        public string Name { get; set; }

        public void AddEmployee(Employee employee)
        {
            this.Subordinates.Add(employee);
        }
    }
}
