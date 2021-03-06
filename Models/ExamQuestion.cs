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
    
    public partial class ExamQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExamQuestion()
        {
            this.ExamAnswer = new HashSet<ExamAnswer>();
            this.ExamQuestionTitles = new HashSet<ExamQuestionTitles>();
        }
    
        public int QuestionId { get; set; }
        public int ExamId { get; set; }
        public int QNo { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public int AnswerRight { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string Answer5 { get; set; }
        public bool Deleted { get; set; }
        public bool Canceled { get; set; }
        public int CUId { get; set; }
        public System.DateTime CDate { get; set; }
        public string CUName { get; set; }
        public Nullable<int> UUId { get; set; }
        public Nullable<System.DateTime> UDate { get; set; }
        public string UUName { get; set; }
        public Nullable<int> CancelUId { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
    
        public virtual Exam Exam { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamAnswer> ExamAnswer { get; set; }
        public virtual ExamQuestionStats ExamQuestionStats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamQuestionTitles> ExamQuestionTitles { get; set; }
    }
}
