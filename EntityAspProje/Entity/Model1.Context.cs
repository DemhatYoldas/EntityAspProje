﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityAspProje.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ASPDBEntities : DbContext
    {
        public ASPDBEntities()
            : base("name=ASPDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tbl_Kategori> Tbl_Kategori { get; set; }
        public virtual DbSet<Tbl_Musteri> Tbl_Musteri { get; set; }
        public virtual DbSet<Tbl_Personel> Tbl_Personel { get; set; }
        public virtual DbSet<Tbl_Satis> Tbl_Satis { get; set; }
        public virtual DbSet<Tbl_Urun> Tbl_Urun { get; set; }
    }
}
