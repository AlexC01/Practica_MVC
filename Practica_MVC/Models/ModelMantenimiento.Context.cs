﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practica_MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MANTENIMIENTOEntities : DbContext
    {
        public MANTENIMIENTOEntities()
            : base("name=MANTENIMIENTOEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Equipo> Equipo { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<Tipo_Equipo> Tipo_Equipo { get; set; }
    }
}
