﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeWebApp.Data;
using EmployeeWebApp.Model;

namespace EmployeeWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly EmployeeWebApp.Data.EmployeeWebAppContext _context;

        public IndexModel(EmployeeWebApp.Data.EmployeeWebAppContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Employee != null)
            {
                Employee = await _context.Employee.ToListAsync();
            }
        }
    }
}
