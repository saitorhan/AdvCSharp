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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.EmailAlertQueus = new HashSet<EmailAlertQueu>();
            this.EventNotifications = new HashSet<EventNotification>();
            this.FileAuditEvents = new HashSet<FileAuditEvent>();
            this.FileEmailAlertEvents = new HashSet<FileEmailAlertEvent>();
            this.FileEmailAlertSettings = new HashSet<FileEmailAlertSetting>();
            this.Files = new HashSet<File>();
            this.Files1 = new HashSet<File>();
            this.Files2 = new HashSet<File>();
            this.FileVersions = new HashSet<FileVersion>();
            this.FileVersions1 = new HashSet<FileVersion>();
            this.FolderAuditEvents = new HashSet<FolderAuditEvent>();
            this.FolderEmailAlertEvents = new HashSet<FolderEmailAlertEvent>();
            this.FolderEmailAlertSettings = new HashSet<FolderEmailAlertSetting>();
            this.FolderStructures = new HashSet<FolderStructure>();
            this.FolderStructures1 = new HashSet<FolderStructure>();
            this.ShareLinks = new HashSet<ShareLink>();
            this.ShareLinks1 = new HashSet<ShareLink>();
            this.TaskNotes = new HashSet<TaskNote>();
            this.TaskRoutings = new HashSet<TaskRouting>();
            this.TaskRoutings1 = new HashSet<TaskRouting>();
            this.UserLogMasters = new HashSet<UserLogMaster>();
            this.Groups = new HashSet<Group>();
        }
    
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Desc { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> LastPasswordChange { get; set; }
        public string Email { get; set; }
        public bool DelFlag { get; set; }
        public Nullable<bool> Login { get; set; }
        public string ComputerName { get; set; }
        public string IpAddress { get; set; }
        public Nullable<System.DateTime> LoginTime { get; set; }
        public Nullable<int> DeleteBy { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
        public bool Active { get; set; }
        public Nullable<byte> InvalidLoginAttempt { get; set; }
        public Nullable<System.DateTime> BlockedDate { get; set; }
        public int Authentication { get; set; }
        public int FileRights { get; set; }
        public int SystemRights { get; set; }
        public int FolderCabinetRights { get; set; }
        public byte[] WebUserSetting { get; set; }
        public string Sid { get; set; }
        public string UserSettingXml { get; set; }
        public bool ReadOnlyUser { get; set; }
        public Nullable<bool> AllowWebAccess { get; set; }
        public Nullable<bool> GeneralNotification { get; set; }
        public Nullable<bool> GeneralEmailAlert { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmailAlertQueu> EmailAlertQueus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventNotification> EventNotifications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FileAuditEvent> FileAuditEvents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FileEmailAlertEvent> FileEmailAlertEvents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FileEmailAlertSetting> FileEmailAlertSettings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<File> Files { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<File> Files1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<File> Files2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FileVersion> FileVersions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FileVersion> FileVersions1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FolderAuditEvent> FolderAuditEvents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FolderEmailAlertEvent> FolderEmailAlertEvents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FolderEmailAlertSetting> FolderEmailAlertSettings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FolderStructure> FolderStructures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FolderStructure> FolderStructures1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShareLink> ShareLinks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShareLink> ShareLinks1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskNote> TaskNotes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskRouting> TaskRoutings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskRouting> TaskRoutings1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserLogMaster> UserLogMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Group> Groups { get; set; }
    }
}
