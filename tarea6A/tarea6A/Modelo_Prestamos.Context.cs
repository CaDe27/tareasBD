﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tarea6A
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PréstamosEntities : DbContext
    {
        public PréstamosEntities()
            : base("name=PréstamosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Avalan> Avalan { get; set; }
        public virtual DbSet<Avales> Avales { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<Pagos> Pagos { get; set; }
        public virtual DbSet<Préstamos> Préstamos { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Trabajan> Trabajan { get; set; }
    }
}
