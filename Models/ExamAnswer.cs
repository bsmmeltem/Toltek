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
    
    public partial class ExamAnswer
    {
        public int ExamId { get; set; }
        public int UserId { get; set; }
        public int EnrollmentId { get; set; }
        public int SessionId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public Nullable<System.DateTime> AnswerDate { get; set; }
        public string AnswerText { get; set; }
        public Nullable<int> Answer { get; set; }
        public string AnswerIP { get; set; }
        public bool IsRight { get; set; }
        public System.DateTime CDate { get; set; }
        public int CUId { get; set; }
    
        public virtual Exam Exam { get; set; }
        public virtual ExamEnrollment ExamEnrollment { get; set; }
        public virtual ExamQuestion ExamQuestion { get; set; }
        public virtual ExamSession ExamSession { get; set; }
        public virtual User User { get; set; }
    }
}
