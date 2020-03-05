using SampleAjaxDemo.Models;
using SampleAjaxDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleAjaxDemo.Controllers
{
    public class HomeController : Controller
    {


        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetOrganizations()
        {
            OrganizationVM organizationVM = new OrganizationVM();
            List<OrganizationMasterDto> org = organizationVM.GetAllOrganizations();
            return Json(org, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetDepartments() {            
            DepartmentVM departmentVM = new DepartmentVM();
            List<DepartmentMasterDto> depts = departmentVM.GetAllDepartments();
            return Json(depts,JsonRequestBehavior.AllowGet);    
        }

        public JsonResult GetEmployees() {
            EmployeeVM employeeVM = new EmployeeVM();
            List<EmployeeMasterDto> employees = employeeVM.GetAllEmployess();
            return Json(employees, JsonRequestBehavior.AllowGet);
        }
    }
}