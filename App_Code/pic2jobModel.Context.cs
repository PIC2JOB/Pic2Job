﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class pic2jobEntities : DbContext
{
    public pic2jobEntities()
        : base("name=pic2jobEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<ciudades> ciudades { get; set; }
    public virtual DbSet<imagenes> imagenes { get; set; }
    public virtual DbSet<usuarios> usuarios { get; set; }
}
