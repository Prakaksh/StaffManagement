using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HCS.StaffManagement.Models
{
    public class CustomerDetailsModel
    {
        [Required]
        public string CustomerName { get; set; }

        [Required]
        public string GSTIN { get; set; }
        public string CustomerAddr1 { get; set; }
        public string CustomerAddr2 { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ContactNO { get; set; }
        public string MobileNO { get; set; }
        public string EmailID { get; set; }
        

    }
}