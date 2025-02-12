﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmallStructuresTakeOffs;
using SmallStructuresTakeOffs.Models;

namespace SmallStructuresTakeOffs.Models
{
    public class EFCoreDBcontext : DbContext
    {
        public EFCoreDBcontext(DbContextOptions<EFCoreDBcontext> opts)
            : base(opts) { }

        public DbSet<CatchBasin> CatchBasins { get; set; }
        public DbSet<CBc1580> CBc1580s { get; set; }
        public DbSet<SD630Headwall> SD630Headwalls { get; set; }
        public DbSet<SmallStructure> SmallStructures { get; set; }
        public DbSet<C1580CB> C1580CBs { get; set; }
        public DbSet<P1569_1M> P1569_1Ms { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<RebarRequest> RebarRequests { get; set; }
        public DbSet<RebarWasting> RebarWastings { get; set; }
        public DbSet<RebarToPurchase> RebarToPurchase { get; set; }
        //public DbSet<RebarLengths> RebarLengths { get; set; }
        //public DbSet<Rebar> Rebars { get; set; }
        //public DbSet<RebarNomination> RebarNominations { get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CBc1580>(ar => ar.Property(p => p.CBHeight).HasColumnType("decimal(18,2)"));
            modelBuilder.Entity<C1580CB>(ar => ar.Property(p => p.C1580CBHeight).HasColumnType("decimal(18,2)"));
        }
    }
}
//namespace DataApp.Models
//{
//    public class EFDatabaseContext : DbContext
//    {

//        public EFDatabaseContext(DbContextOptions<EFDatabaseContext> opts)
//            : base(opts) { }

//        public DbSet<Product> Products { get; set; }
//        public DbSet<Supplier> Suppliers { get; set; }
//    }
//}
