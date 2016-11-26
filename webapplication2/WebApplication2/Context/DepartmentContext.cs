using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Context
{
    public class DepartmentContext: DbContext
    {
        public DbSet<DepartmentModel> Departments { get; set; }
        public DbSet<EmployeeModel> Employees { get; set; }
    }
}