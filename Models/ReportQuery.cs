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
    
    public partial class ReportQuery
    {
        public int ReportId { get; set; }
        public int QueryId { get; set; }
        public byte Context { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string QuerySql { get; set; }
        public Nullable<int> LEUserId { get; set; }
        public Nullable<System.DateTime> LEDate { get; set; }
    }
}
