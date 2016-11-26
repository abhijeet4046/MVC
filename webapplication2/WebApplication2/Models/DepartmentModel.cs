using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class DepartmentModel
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public virtual List<EmployeeModel> Employees { get; set; }
    }
}