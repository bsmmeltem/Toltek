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
    
    public partial class Invoice
    {
        public int CompanyId { get; set; }
        public int InvoiceId { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public string InvoiceTerm { get; set; }
        public decimal Amount { get; set; }
        public bool Paid { get; set; }
        public bool Canceled { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
