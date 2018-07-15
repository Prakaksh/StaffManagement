using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HCS.StaffManagement.Models
{
    [Table("Students")]
    public class OrganizationModel
    {
        public string OrganizationID { get; set; }
        
        [Required]
        public string OrganizationName { get; set; }
        [Required]
        public string GSTIN { get; set; }
        public string ESCINO { get; set; }
        public string EPFNO { get; set; }
        public string OrganizationAddr1 { get; set; }
        public string OrganizationAddr2 { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ContactNO { get; set; }
        public string MobileNO { get; set; }

        [Required]
        public string EmailID { get; set; }
        public string InvoicePrefix { get; set; }
        //public string Logo { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

    }
}