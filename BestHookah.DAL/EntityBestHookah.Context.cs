﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BestHookah.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BestHookahEntities : DbContext
    {
        public BestHookahEntities()
            : base("name=BestHookahEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BlogArticles> BlogArticles { get; set; }
        public virtual DbSet<Branches> Branches { get; set; }
        public virtual DbSet<Gallery> Gallery { get; set; }
        public virtual DbSet<MenuPoints> MenuPoints { get; set; }
        public virtual DbSet<MenuSections> MenuSections { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<Offers> Offers { get; set; }
        public virtual DbSet<Reserves> Reserves { get; set; }
        public virtual DbSet<Reviews> Reviews { get; set; }
    }
}
