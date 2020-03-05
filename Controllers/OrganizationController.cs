using SampleAjaxDemo.Models;
using SampleAjaxDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleAjaxDemo.Controllers
{
    public class OrganizationController : Controller
    {
        // GET: Organization
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Save(OrganizationVM model) {
            model.SaveOrUpdateOrganization(model.organizationMasterDto);
            return Json(model, JsonRequestBehavior.AllowGet);

        }
    }
}