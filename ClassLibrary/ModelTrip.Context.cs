﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBTripToMyDreamEntities : DbContext
    {
        public DBTripToMyDreamEntities()
            : base("name=DBTripToMyDreamEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CLIENT> CLIENTS { get; set; }
        public virtual DbSet<COMPANY> COMPANies { get; set; }
        public virtual DbSet<DESTINATION> DESTINATIONs { get; set; }
        public virtual DbSet<FILIAL> FILIALs { get; set; }
        public virtual DbSet<MANAGER> MANAGERS { get; set; }
        public virtual DbSet<ORDER> ORDERS { get; set; }
        public virtual DbSet<OWNER> OWNERS { get; set; }
    }
}
