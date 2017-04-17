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
    
    public partial class CourseStats
    {
        public int CompanyId { get; set; }
        public int UnitId { get; set; }
        public int CourseId { get; set; }
        public int GroupCount { get; set; }
        public int GroupNew { get; set; }
        public int GroupCompleted { get; set; }
        public int GroupCanceled { get; set; }
        public int GroupTotal { get; set; }
        public int TeacherCount { get; set; }
        public int TeacherTotal { get; set; }
        public int ContentCount { get; set; }
        public int ContentTotal { get; set; }
        public int AssignmentCount { get; set; }
        public int AssignmentTotal { get; set; }
        public int ExamCount { get; set; }
        public int ExamTotal { get; set; }
        public int VClassCount { get; set; }
        public int VClassTotal { get; set; }
        public int EnrollPercent { get; set; }
        public int TicketCount { get; set; }
        public int TicketTotal { get; set; }
        public int RequestCount { get; set; }
        public int RequestTotal { get; set; }
        public int EnrollmentNew { get; set; }
        public int EnrollmentCount { get; set; }
        public int EnrollmentCanceled { get; set; }
        public int EnrollmentCompleted { get; set; }
        public int EnrollmentFailed { get; set; }
        public int EnrollmentTotal { get; set; }
        public decimal EnrollmentChanged { get; set; }
    
        public virtual Course Course { get; set; }
    }
}
