//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdvCSharp.EntityFrame
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mask
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mask()
        {
            this.Properties = new HashSet<Property>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string EditMask { get; set; }
        public string MaskType { get; set; }
        public Nullable<bool> Custom { get; set; }
        public string Sample { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Property> Properties { get; set; }
    }
}
