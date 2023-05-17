﻿using System.ComponentModel.DataAnnotations;

namespace EmployeeWebApp.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int age { get; set; }
        
        public string? Designation { get; set; }
        public decimal salary { get; set; }
    }
}
