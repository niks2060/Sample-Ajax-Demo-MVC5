using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SampleAjaxDemo.Models.Entities
{
    public class DepartmentMasterEntity
    {
        [Key]
        [Column("DId", TypeName = "int")]
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public string Slogan { get; set; }
        [ForeignKey("OId")]
        public int OrganizationId { get; set; }
        public OrganizationMasterEntity OrganizationMasterEntity { get; set; }
    }
}