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
    
    public partial class Unit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Unit()
        {
            this.Announce = new HashSet<Announce>();
            this.Course = new HashSet<Course>();
            this.SyncItem = new HashSet<SyncItem>();
            this.UnitManager = new HashSet<UnitManager>();
        }
    
        public int CompanyId { get; set; }
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<byte> EducationType { get; set; }
        public bool Enable { get; set; }
        public Nullable<long> BaseKey { get; set; }
        public System.Guid UnitKey { get; set; }
        public string UnitCode { get; set; }
        public Nullable<int> UnitLevel { get; set; }
        public string UnitNode { get; set; }
    
        public virtual Company Company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Announce> Announce { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Course { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SyncItem> SyncItem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnitManager> UnitManager { get; set; }
        public virtual UnitStats UnitStats { get; set; }
    }
}