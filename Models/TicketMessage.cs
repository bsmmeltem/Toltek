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
    
    public partial class TicketMessage
    {
        public int TicketId { get; set; }
        public int UserId { get; set; }
        public int MessageId { get; set; }
        public System.DateTime Date { get; set; }
        public string Body { get; set; }
        public bool Read { get; set; }
    
        public virtual Ticket Ticket { get; set; }
        public virtual User User { get; set; }
    }
}
