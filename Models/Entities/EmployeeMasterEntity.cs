using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SampleAjaxDemo.Models.Entities
{
    public class EmployeeMasterEntity
    {
        [Key]
        [Column("EId", TypeName = "int")]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        [MaxLength(10, ErrorMessage = "Max length is 10")]
        public string ContactNo { get; set; }
        [ForeignKey("DId")]
        public int DepartmentId { get; set; }
        public DepartmentMasterEntity DepartmentMasterEntity { get; set; }
    }
}