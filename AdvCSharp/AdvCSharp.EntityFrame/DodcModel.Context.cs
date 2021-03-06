﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DocsEntities : DbContext
    {
        public DocsEntities()
            : base("name=DocsEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AuditTemplate> AuditTemplates { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<DocsType> DocsTypes { get; set; }
        public virtual DbSet<DocTemplate> DocTemplates { get; set; }
        public virtual DbSet<EmailAlertQueu> EmailAlertQueus { get; set; }
        public virtual DbSet<EmailTemplateParameter> EmailTemplateParameters { get; set; }
        public virtual DbSet<EventNotification> EventNotifications { get; set; }
        public virtual DbSet<ExtensionViewer> ExtensionViewers { get; set; }
        public virtual DbSet<Faq> Faqs { get; set; }
        public virtual DbSet<FileAuditEvent> FileAuditEvents { get; set; }
        public virtual DbSet<FileEmailAlertEvent> FileEmailAlertEvents { get; set; }
        public virtual DbSet<FileEmailAlertSetting> FileEmailAlertSettings { get; set; }
        public virtual DbSet<FileProperty> FileProperties { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<FileVersionData> FileVersionDatas { get; set; }
        public virtual DbSet<FileVersion> FileVersions { get; set; }
        public virtual DbSet<Flag> Flags { get; set; }
        public virtual DbSet<FolderAuditEvent> FolderAuditEvents { get; set; }
        public virtual DbSet<FolderEmailAlertEvent> FolderEmailAlertEvents { get; set; }
        public virtual DbSet<FolderEmailAlertSetting> FolderEmailAlertSettings { get; set; }
        public virtual DbSet<FolderGroupSecurityTemplate> FolderGroupSecurityTemplates { get; set; }
        public virtual DbSet<FolderProperty> FolderProperties { get; set; }
        public virtual DbSet<FolderStructure> FolderStructures { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Icon> Icons { get; set; }
        public virtual DbSet<Mask> Masks { get; set; }
        public virtual DbSet<MessageTemplate> MessageTemplates { get; set; }
        public virtual DbSet<ProfileProperty> ProfileProperties { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<PropertyValue> PropertyValues { get; set; }
        public virtual DbSet<PublicFileAuditEvent> PublicFileAuditEvents { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Sequence> Sequences { get; set; }
        public virtual DbSet<ServerSetting> ServerSettings { get; set; }
        public virtual DbSet<ShareLink> ShareLinks { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaskDocument> TaskDocuments { get; set; }
        public virtual DbSet<TaskNote> TaskNotes { get; set; }
        public virtual DbSet<TaskRouting> TaskRoutings { get; set; }
        public virtual DbSet<TaskStatue> TaskStatues { get; set; }
        public virtual DbSet<TempFilesOnUpload> TempFilesOnUploads { get; set; }
        public virtual DbSet<UserLogMaster> UserLogMasters { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
