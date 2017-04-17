//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToltekLMSPortal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Department()
        {
            this.Lesson = new HashSet<Lesson>();
        }
    
        public int CompanyId { get; set; }
        public int FacultyId { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string ImportKey { get; set; }
        public System.Guid UniqueKey { get; set; }
        public int CountLesson { get; set; }
        public int CountCourse { get; set; }
        public int CountMap { get; set; }
        public int CountStudent { get; set; }
        public int CUId { get; set; }
        public System.DateTime CDate { get; set; }
        public string CUName { get; set; }
        public int UUId { get; set; }
        public System.DateTime UDate { get; set; }
        public string UUName { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Faculty Faculty { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lesson> Lesson { get; set; }
    }
}
