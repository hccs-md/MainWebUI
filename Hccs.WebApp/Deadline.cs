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
    
    public partial class Deadline
    {
        public short DeadlineType { get; set; }
        public System.DateTime DeadlineDt { get; set; }
        public string Schoolyear { get; set; }
        public string Semester { get; set; }
        public System.DateTime Created { get; set; }
        public int CreatedByID { get; set; }
        public Nullable<System.DateTime> Updated { get; set; }
        public Nullable<int> UpdatedByID { get; set; }
    }
}