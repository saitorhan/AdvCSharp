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
    
    public partial class FileEmailAlertEvent
    {
        public int Id { get; set; }
        public int FileId { get; set; }
        public string FilePath { get; set; }
        public int UserId { get; set; }
        public System.DateTime EventTime { get; set; }
        public Nullable<int> Event { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> Access { get; set; }
    
        public virtual File File { get; set; }
        public virtual User User { get; set; }
    }
}
