using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HCS.StaffManagement.Models
{
    [Table("GetStateList")]
    public class MstStateModel
    {
        public int StateID { get; set;}
        public string Name { get; set; }
        public int CountryID{ get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
        [NotMapped]
        public SelectList GetStateList { get; set; }

    }
}