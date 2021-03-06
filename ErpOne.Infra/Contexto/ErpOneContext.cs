﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ErpOne.Domain.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ErpOne.Infra.Contexto
{
    public class ErpOneContext : DbContext

    {
        public ErpOneContext()
            : base("ErpOne")
        {

        }

        public DbSet<Administrador> Administrador { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Anunciante> Anunciante { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<Fotos> Fotos { get; set; }
        public DbSet<Historico> Historico { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("Varchar"));
        }
    }
}
