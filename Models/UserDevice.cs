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
    
    public partial class UserDevice
    {
        public int RegId { get; set; }
        public int UserId { get; set; }
        public int Device { get; set; }
        public string DeviceKey { get; set; }
        public System.DateTime RegDate { get; set; }
        public int Version { get; set; }
        public bool Enable { get; set; }
        public System.DateTime FirstDate { get; set; }
    
        public virtual User User { get; set; }
    }
}
