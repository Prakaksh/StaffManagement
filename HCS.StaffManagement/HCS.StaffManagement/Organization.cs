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
    
    public partial class Organization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organization()
        {
            this.Users = new HashSet<User>();
        }
    
        public System.Guid OrganizationID { get; set; }
        public string OrganizationName { get; set; }
        public string GSTIN { get; set; }
        public string ESCINO { get; set; }
        public string EPFNO { get; set; }
        public string OrganizationAddr1 { get; set; }
        public string OrganizationAddr2 { get; set; }
        public Nullable<int> State { get; set; }
        public string City { get; set; }
        public string ContactNO { get; set; }
        public string MobileNO { get; set; }
        public string EmailID { get; set; }
        public string InvoicePrefix { get; set; }
        public byte[] Logo { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IslockedOut { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual MstState MstState { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
