﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KutuphaneEntities : DbContext
    {
        public KutuphaneEntities()
            : base("name=KutuphaneEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Kitap> Kitap { get; set; }
        public virtual DbSet<KitapOgrenci> KitapOgrenci { get; set; }
        public virtual DbSet<KitapTuru> KitapTuru { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Ogrenci> Ogrenci { get; set; }
        public virtual DbSet<YayinEvi> YayinEvi { get; set; }
        public virtual DbSet<Yazar> Yazar { get; set; }
    }
}