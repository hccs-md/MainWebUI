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
    
    public partial class Campus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Campus()
        {
            this.Classrooms = new HashSet<Classroom>();
        }
    
        public int CampusID { get; set; }
        public string CampusName { get; set; }
        public string CampusAddress { get; set; }
        public System.DateTime Created { get; set; }
        public int CreatedByID { get; set; }
        public Nullable<System.DateTime> Updated { get; set; }
        public Nullable<int> UpdatedByID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Classroom> Classrooms { get; set; }
    }
}
