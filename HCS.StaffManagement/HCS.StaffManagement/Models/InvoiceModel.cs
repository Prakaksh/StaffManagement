using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HCS.StaffManagement.Models
{
    public class InvoiceModel
    {
        [Required]
        public string InvoiceNO { get; set; }

        [Required]
        public DateTime InvoiceDate { get; set; }

        public DateTime InvoiceMonth { get; set; }
        public DateTime InvoicePeriod { get; set; }
        public string InvoiceTo { get; set; }
        public int CGST { get; set; }
        public int SGST { get; set; }
        public Int64 SubTotalAmount { get; set; }
        public int TaxAmount { get; set; }
        public Int64 GrandTotal { get; set; }
    }
}