using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleAjaxDemo.Models
{

    public class OrganizationMasterDto
    {
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }

    public class DepartmentMasterDto
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public string Slogan { get; set; }
        public int OrganizationId { get; set; }
        public OrganizationMasterDto OrganizationMasterDto { get; set; }

    }
    public class EmployeeMasterDto
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ContactNo { get; set; }
        public int DepartmentId { get; set; }
        public DepartmentMasterDto DepartmentMasterDto { get; set; }
    }


}