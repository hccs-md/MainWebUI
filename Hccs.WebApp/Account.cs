//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hccs.WebApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            this.Invoices = new HashSet<Invoice>();
            this.Payments = new HashSet<Payment>();
            this.Refunds = new HashSet<Refund>();
        }
    
        public int AccountID { get; set; }
        public int PersonID { get; set; }
        public Nullable<System.DateTime> AccountConfirmedDt { get; set; }
        public short AccountStatus { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmationCode { get; set; }
        public System.DateTime Created { get; set; }
        public int CreatedByID { get; set; }
        public Nullable<System.DateTime> Updated { get; set; }
        public Nullable<int> UpdatedByID { get; set; }
    
        public virtual Person Person { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Refund> Refunds { get; set; }
    }
}
