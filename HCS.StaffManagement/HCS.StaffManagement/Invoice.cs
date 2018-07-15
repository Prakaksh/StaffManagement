//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HCS.StaffManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            this.InovoiceDetails = new HashSet<InovoiceDetail>();
        }
    
        public string InvoiceNO { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public Nullable<System.DateTime> InvoiceMonth { get; set; }
        public Nullable<System.DateTime> InvoicePeriod { get; set; }
        public string InvoiceTo { get; set; }
        public Nullable<int> CGST { get; set; }
        public Nullable<int> SGST { get; set; }
        public Nullable<long> SubTotalAmount { get; set; }
        public Nullable<int> TaxAmount { get; set; }
        public Nullable<long> GrandTotal { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual CustomerDetail CustomerDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InovoiceDetail> InovoiceDetails { get; set; }
    }
}