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
    
    public partial class ContentTitles
    {
        public int ContentId { get; set; }
        public int TitleId { get; set; }
        public int CUId { get; set; }
        public System.DateTime CDate { get; set; }
    
        public virtual Title Title { get; set; }
    }
}
