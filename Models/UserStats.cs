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
    
    public partial class UserStats
    {
        public int UserId { get; set; }
        public int TeacherCount { get; set; }
        public int TeacherView { get; set; }
        public int EnrollCount { get; set; }
        public int TicketCount { get; set; }
        public decimal PaymentTotal { get; set; }
        public string Roles { get; set; }
    
        public virtual User User { get; set; }
    }
}
