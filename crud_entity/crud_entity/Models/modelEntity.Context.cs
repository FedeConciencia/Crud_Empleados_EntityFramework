﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace crud_entity.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class crudEntity : DbContext
    {
        public crudEntity()
            : base("name=crudEntity")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cargo> cargo { get; set; }
        public virtual DbSet<cargoEmpleado> cargoEmpleado { get; set; }
        public virtual DbSet<empleado> empleado { get; set; }
        public virtual DbSet<empresa> empresa { get; set; }
    }
}
