using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HCS.StaffManagement.Models
{
    public class ItemModel
    {
        [Required(ErrorMessage ="Enter Item Type *")]
      
        public string ItemType { get; set; }
        public string GroupName { get; set; }

        [Required(ErrorMessage = "Enter Item Name *")]
        public string ItemName { get; set; }
        public string Unit { get; set; }
        public bool TaxPreference { get; set; }
    }
}