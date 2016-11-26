using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpDesignation { get; set; }
        public DateTime EmpDob { get; set; }
        public int age { get; set; }
        public int DeptId { get; set; }

        public virtual DepartmentModel DepartmentModel { get; set; }
    }
}