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
    
    public partial class Invoice
    {
        public int InvoiceID { get; set; }
        public int AccountID { get; set; }
        public System.DateTime InvoiceDt { get; set; }
        public string Schoolyear { get; set; }
        public string Semester { get; set; }
        public Nullable<short> FamilyDiscountCount { get; set; }
        public Nullable<decimal> FamilyDiscount { get; set; }
        public Nullable<short> BilingualDiscountCount { get; set; }
        public Nullable<decimal> BilingualDiscount { get; set; }
        public Nullable<decimal> TotalInvoiceAmount { get; set; }
        public Nullable<short> PaymentStatus { get; set; }
        public Nullable<int> PaymentID { get; set; }
        public Nullable<System.DateTime> PaymentDt { get; set; }
        public Nullable<decimal> PaymentAmount { get; set; }
        public Nullable<decimal> RefundOnDropFamilyDsctAmount { get; set; }
        public Nullable<decimal> RefundOnDropBilingualDsctAmount { get; set; }
        public Nullable<decimal> TotalBalanceAmount { get; set; }
        public string InvoiceNotes { get; set; }
        public System.DateTime Created { get; set; }
        public string CreatedByID { get; set; }
        public Nullable<System.DateTime> Updated { get; set; }
        public string UpdatedByID { get; set; }
    
        public virtual Account Account { get; set; }
    }
}
