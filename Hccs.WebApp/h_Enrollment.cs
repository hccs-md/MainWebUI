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
    
    public partial class h_Enrollment
    {
        public int h_Enrollment_id { get; set; }
        public int EnrollmentID { get; set; }
        public int ScheduleID { get; set; }
        public Nullable<int> InvoiceID { get; set; }
        public int PersonID { get; set; }
        public Nullable<decimal> RegistrationFeeAmount { get; set; }
        public Nullable<System.DateTime> EnrollmentStartDate { get; set; }
        public Nullable<decimal> TuitionAmount { get; set; }
        public Nullable<decimal> TuitionProrate { get; set; }
        public Nullable<decimal> MiddlewayTuitionDiscount { get; set; }
        public Nullable<decimal> EcOrTeacherTuitionDiscount { get; set; }
        public Nullable<decimal> FinalTuitionAmount { get; set; }
        public Nullable<decimal> TextbookAmount { get; set; }
        public string TextbookNeeded { get; set; }
        public Nullable<decimal> RefundOnDropRegFeeAmount { get; set; }
        public Nullable<decimal> RefundOnDropTuitionAmount { get; set; }
        public Nullable<decimal> RefundOnDropTextbookAmount { get; set; }
        public Nullable<decimal> HccAmount { get; set; }
        public Nullable<decimal> CcbcAmount { get; set; }
        public short RegistrationStatus { get; set; }
        public System.DateTime Created { get; set; }
        public string CreatedByID { get; set; }
        public Nullable<System.DateTime> Updated { get; set; }
        public string UpdatedByID { get; set; }
        public System.DateTime h_created_date { get; set; }
        public string h_action_flag { get; set; }
        public int h_user_id { get; set; }
    }
}
