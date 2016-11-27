using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        DepartmentContext DbContext = new DepartmentContext();
        public ActionResult Index()
        {
            
            return View(DbContext.Employees.ToList());
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            ViewBag.DeptId = new SelectList( DbContext.Departments,"DeptID","DeptName");
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            try
            {
                // TODO: Add insert logic here
                DbContext.Employees.Add(emp);
                DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.DeptId = new SelectList(DbContext.Departments, "DeptID", "DeptName");
            var employee= DbContext.Employees.Where(x => x.EmpId == id).FirstOrDefault();
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EmployeeModel emp)
        {
            try
            {
                // TODO: Add update logic here
                DbContext.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
