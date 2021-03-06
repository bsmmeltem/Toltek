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
    
    public partial class ExamEnrollment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExamEnrollment()
        {
            this.ExamAnswer = new HashSet<ExamAnswer>();
            this.ExamSession = new HashSet<ExamSession>();
        }
    
        public int CourseId { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public int CEId { get; set; }
        public int ExamId { get; set; }
        public int EnrollmentId { get; set; }
        public byte Status { get; set; }
        public Nullable<decimal> Score { get; set; }
        public string ScoreDesc { get; set; }
        public Nullable<int> SessionId { get; set; }
        public int AttCount { get; set; }
        public Nullable<System.DateTime> AttFirst { get; set; }
        public Nullable<System.DateTime> AttLast { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Enrollment Enrollment { get; set; }
        public virtual Group Group { get; set; }
        public virtual Exam Exam { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamAnswer> ExamAnswer { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamSession> ExamSession { get; set; }
    }
}
