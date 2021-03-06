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
    
    public partial class Group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Group()
        {
            this.Assignment = new HashSet<Assignment>();
            this.AssignmentEnrollment = new HashSet<AssignmentEnrollment>();
            this.Content = new HashSet<Content>();
            this.ContentEnrollment = new HashSet<ContentEnrollment>();
            this.Enrollment = new HashSet<Enrollment>();
            this.Announce = new HashSet<Announce>();
            this.Exam = new HashSet<Exam>();
            this.ExamEnrollment = new HashSet<ExamEnrollment>();
            this.GroupTeacher = new HashSet<GroupTeacher>();
            this.Lesson = new HashSet<Lesson>();
            this.SyncItem = new HashSet<SyncItem>();
            this.VClass = new HashSet<VClass>();
            this.VClassSchedule = new HashSet<VClassSchedule>();
        }
    
        public int CompanyId { get; set; }
        public int UnitId { get; set; }
        public int CourseId { get; set; }
        public int GroupId { get; set; }
        public System.Guid GroupKey { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<decimal> Price { get; set; }
        public decimal Payment { get; set; }
        public Nullable<System.DateTime> LastEnrollDate { get; set; }
        public Nullable<System.DateTime> ExamStartDate { get; set; }
        public Nullable<System.DateTime> ExamEndDate { get; set; }
        public bool Deleted { get; set; }
        public int CUId { get; set; }
        public System.DateTime CDate { get; set; }
        public string CUName { get; set; }
        public int UUId { get; set; }
        public System.DateTime UDate { get; set; }
        public string UUName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assignment> Assignment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssignmentEnrollment> AssignmentEnrollment { get; set; }
        public virtual Company Company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Content> Content { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContentEnrollment> ContentEnrollment { get; set; }
        public virtual Course Course { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Enrollment> Enrollment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Announce> Announce { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exam> Exam { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamEnrollment> ExamEnrollment { get; set; }
        public virtual GroupStats GroupStats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GroupTeacher> GroupTeacher { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lesson> Lesson { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SyncItem> SyncItem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VClass> VClass { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VClassSchedule> VClassSchedule { get; set; }
    }
}
