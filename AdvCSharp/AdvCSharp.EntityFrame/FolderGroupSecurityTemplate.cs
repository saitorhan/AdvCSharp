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
    
    public partial class FolderGroupSecurityTemplate
    {
        public int Id { get; set; }
        public int FolderStructureId { get; set; }
        public int GroupId { get; set; }
        public int Right { get; set; }
    
        public virtual FolderStructure FolderStructure { get; set; }
        public virtual Group Group { get; set; }
    }
}
