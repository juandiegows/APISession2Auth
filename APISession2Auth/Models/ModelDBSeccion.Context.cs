﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APISession2Auth.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Session2WSTowersEntities : DbContext
    {
        public Session2WSTowersEntities()
            : base("name=Session2WSTowersEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<campeonatos> campeonatos { get; set; }
        public virtual DbSet<estadios> estadios { get; set; }
        public virtual DbSet<historicos> historicos { get; set; }
        public virtual DbSet<jogadores> jogadores { get; set; }
        public virtual DbSet<jogos> jogos { get; set; }
        public virtual DbSet<participacoes> participacoes { get; set; }
        public virtual DbSet<patrocinadores> patrocinadores { get; set; }
        public virtual DbSet<patrocinios> patrocinios { get; set; }
        public virtual DbSet<posicoes> posicoes { get; set; }
        public virtual DbSet<times> times { get; set; }
    }
}
