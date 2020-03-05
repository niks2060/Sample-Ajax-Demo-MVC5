using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SampleAjaxDemo.Models.Entities
{
    public class OrganizationMasterEntity
    {
        [Key]
        [Column("OId",TypeName ="int")]
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}