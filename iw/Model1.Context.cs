﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iw
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BLM376_DB_IIEntities : DbContext
    {
        public BLM376_DB_IIEntities()
            : base("name=BLM376_DB_IIEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<bus> buses { get; set; }
        public virtual DbSet<busDriverPassenger> busDriverPassengers { get; set; }
        public virtual DbSet<busLine> busLines { get; set; }
        public virtual DbSet<busStop> busStops { get; set; }
        public virtual DbSet<parklar> parklars { get; set; }
        public virtual DbSet<person> people { get; set; }
        public virtual DbSet<people111> people111 { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
