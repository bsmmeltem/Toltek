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
    
    public partial class UnitStats
    {
        public int CompanyId { get; set; }
        public int UnitId { get; set; }
        public int UserCount { get; set; }
        public int CourseCount { get; set; }
        public int TicketCount { get; set; }
        public int UserTotal { get; set; }
        public int CourseTotal { get; set; }
        public int TicketTotal { get; set; }
        public int GroupNew { get; set; }
        public int GroupCount { get; set; }
        public int GroupCompleted { get; set; }
        public int GroupCanceled { get; set; }
        public int GroupTotal { get; set; }
        public int RequestCount { get; set; }
        public int RequestTotal { get; set; }
        public int ContentCount { get; set; }
        public int ContentTotal { get; set; }
        public int ActivityCount { get; set; }
        public int ActivityTotal { get; set; }
        public int EnrollmentNew { get; set; }
        public int EnrollmentCount { get; set; }
        public int EnrollmentCanceled { get; set; }
        public int EnrollmentCompleted { get; set; }
        public int EnrollmentFailed { get; set; }
        public int EnrollmentTotal { get; set; }
        public decimal EnrollmentChanged { get; set; }
        public int ExamCount { get; set; }
        public decimal ExamChange { get; set; }
        public int ExamTotal { get; set; }
        public int VClassCount { get; set; }
        public decimal VClassChange { get; set; }
        public int VClassTotal { get; set; }
    
        public virtual Unit Unit { get; set; }
    }
}
