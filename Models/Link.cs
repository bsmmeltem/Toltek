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
    
    public partial class Link
    {
        public int GroupId { get; set; }
        public int ProviderId { get; set; }
        public int LinkId { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public Nullable<int> Width { get; set; }
        public Nullable<int> Heigth { get; set; }
        public byte Publish { get; set; }
        public bool Deleted { get; set; }
        public bool Tracking { get; set; }
        public int WStart { get; set; }
        public Nullable<int> WEnd { get; set; }
        public int CUId { get; set; }
        public string CUName { get; set; }
        public System.DateTime CDate { get; set; }
        public int UUId { get; set; }
        public System.DateTime UDate { get; set; }
    }
}
