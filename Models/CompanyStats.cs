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
    
    public partial class CompanyStats
    {
        public int CompanyId { get; set; }
        public int UnitCount { get; set; }
        public int UnitTotal { get; set; }
        public decimal UnitChange { get; set; }
        public int CourseCount { get; set; }
        public int CourseTotal { get; set; }
        public decimal CourseChange { get; set; }
        public int GroupCount { get; set; }
        public int GroupNew { get; set; }
        public int GroupCompleted { get; set; }
        public int GroupCanceled { get; set; }
        public int GroupTotal { get; set; }
        public decimal GroupChange { get; set; }
        public int EnrollmentNew { get; set; }
        public int EnrollmentCount { get; set; }
        public int EnrollmentCanceled { get; set; }
        public int EnrollmentCompleted { get; set; }
        public int EnrollmentFailed { get; set; }
        public int EnrollmentTotal { get; set; }
        public decimal EnrollmentChange { get; set; }
        public int TeacherCount { get; set; }
        public int TeacherTotal { get; set; }
        public decimal TeacherChange { get; set; }
        public int ContentCount { get; set; }
        public int ContentTotal { get; set; }
        public int ContentChange { get; set; }
        public int ActivityCount { get; set; }
        public int ActivityTotal { get; set; }
        public decimal ActivityChange { get; set; }
        public int ExamCount { get; set; }
        public decimal ExamChange { get; set; }
        public int ExamTotal { get; set; }
        public int AssignmentCount { get; set; }
        public decimal AssignmentChange { get; set; }
        public int VClassCount { get; set; }
        public int VClassTotal { get; set; }
        public decimal VClassChange { get; set; }
        public int UserCount { get; set; }
        public int UserTotal { get; set; }
        public decimal UserChange { get; set; }
        public int RequestCount { get; set; }
        public int RequestTotal { get; set; }
        public decimal RequestChange { get; set; }
        public int AnnounceCount { get; set; }
        public int AnnounceTotal { get; set; }
        public decimal AnnounceChange { get; set; }
        public int TicketCount { get; set; }
        public int TicketTotal { get; set; }
        public decimal TicketChange { get; set; }
        public decimal Profit { get; set; }
        public Nullable<decimal> ProfitTotal { get; set; }
        public decimal ProfitChange { get; set; }
        public decimal Sales { get; set; }
        public decimal SalesTotal { get; set; }
        public decimal SalesChange { get; set; }
        public decimal Payment { get; set; }
        public decimal PaymentTotal { get; set; }
        public decimal PaymentChange { get; set; }
        public int Graduate { get; set; }
        public int Hosts { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
