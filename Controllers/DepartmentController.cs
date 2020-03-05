using SampleAjaxDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleAjaxDemo.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(DepartmentVM model)
        {
            model.SaveOrupdateDepartment(model.DepartmentMasterDto);
            return Json(model, JsonRequestBehavior.AllowGet);

        }
    }
}