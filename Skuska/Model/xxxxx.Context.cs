﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Skuska.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cvicenie> cvicenie { get; set; }
        public virtual DbSet<faktura> faktura { get; set; }
        public virtual DbSet<inventar> inventar { get; set; }
        public virtual DbSet<mesacny_vykaz> mesacny_vykaz { get; set; }
        public virtual DbSet<osoba> osoba { get; set; }
        public virtual DbSet<permanentka> permanentka { get; set; }
        public virtual DbSet<podujatie> podujatie { get; set; }
        public virtual DbSet<sablona> sablona { get; set; }
        public virtual DbSet<zakaznik> zakaznik { get; set; }
        public virtual DbSet<zmluva> zmluva { get; set; }
    }
}
