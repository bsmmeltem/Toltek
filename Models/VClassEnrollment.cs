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
    
    public partial class VClassEnrollment
    {
        public int VClassId { get; set; }
        public int UserId { get; set; }
        public Nullable<System.DateTime> AttFirst { get; set; }
        public Nullable<System.DateTime> AttLast { get; set; }
        public int LiveCount { get; set; }
        public int ReplayCount { get; set; }
        public string EnrollKey { get; set; }
    
        public virtual User User { get; set; }
    }
}
