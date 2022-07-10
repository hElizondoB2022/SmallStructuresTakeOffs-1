﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmallStructuresTakeOffs.Models;

namespace SmallStructuresTakeOffs.Migrations
{
    [DbContext(typeof(EFCoreDBcontext))]
    [Migration("20220710231255_RevisedFKinCatchBasin")]
    partial class RevisedFKinCatchBasin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SmallStructuresTakeOffs.Models.C1580CB", b =>
                {
                    b.Property<int>("C1580CBId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("C1580CBCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C1580CBDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("C1580CBHeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("C1580Reb4FandI")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("C1580Reb4Purch")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("C1580CBId");

                    b.ToTable("C1580CBs");
                });

            modelBuilder.Entity("SmallStructuresTakeOffs.Models.CatchBasin", b =>
                {
                    b.Property<int>("CatchBasinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CBBaseThickness")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CBCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CBHeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CBLength")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CBRebFandI")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CBRebPurch")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CBSqRingL")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CBVertBars")
                        .HasColumnType("int");

                    b.Property<decimal>("CBWallThickness")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CBWidth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ProjectId")
                        .HasColumnType("bigint");

                    b.HasKey("CatchBasinId");

                    b.HasIndex("ProjectId");

                    b.ToTable("CatchBasins");

                    b.HasDiscriminator<string>("Discriminator").HasValue("CatchBasin");
                });

            modelBuilder.Entity("SmallStructuresTakeOffs.Models.P1569_1M", b =>
                {
                    b.Property<int>("P1569_1MId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("P1569_1MCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P1569_1MDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Reb3FandI")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Reb3Purch")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Reb4FandI")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Reb4Purch")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("P1569_1MId");

                    b.ToTable("P1569_1Ms");
                });

            modelBuilder.Entity("SmallStructuresTakeOffs.Models.Project", b =>
                {
                    b.Property<long>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProjectCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("SmallStructuresTakeOffs.Models.RebarToPurchase", b =>
                {
                    b.Property<int>("RebarToPurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("RebarNomLengths")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RebarRequest")
                        .HasColumnType("int");

                    b.Property<int>("RebarToPurchaseNomination")
                        .HasColumnType("int");

                    b.Property<int>("RebarToPurchaseQuantity")
                        .HasColumnType("int");

                    b.HasKey("RebarToPurchaseId");

                    b.ToTable("RebarToPurchase");
                });

            modelBuilder.Entity("SmallStructuresTakeOffs.Models.RebarWasting", b =>
                {
                    b.Property<int>("RebarWastingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsItAvailable")
                        .HasColumnType("bit");

                    b.Property<int?>("RebarRequestId")
                        .HasColumnType("int");

                    b.Property<decimal>("RebarWastingLength")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RebarWastingNomination")
                        .HasColumnType("int");

                    b.Property<int>("RebarWastingQuantity")
                        .HasColumnType("int");

                    b.Property<int>("RebarWastingReqNo")
                        .HasColumnType("int");

                    b.Property<int>("ReqNo")
                        .HasColumnType("int");

                    b.HasKey("RebarWastingId");

                    b.HasIndex("RebarRequestId");

                    b.ToTable("RebarWastings");
                });

            modelBuilder.Entity("SmallStructuresTakeOffs.Models.SD630Headwall", b =>
                {
                    b.Property<int>("SD630HeadwallId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HWCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PipeNo")
                        .HasColumnType("int");

                    b.Property<decimal>("RebNo4Purch")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RebNo4Req")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SD630Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SD630_A")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SD630_B")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SD630_C")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SD630_D")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SD630_E")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SD630_F")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SD630_G")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SD630_I_D")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SD630_L")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ThisHeadwall")
                        .HasColumnType("int");

                    b.HasKey("SD630HeadwallId");

                    b.ToTable("SD630Headwalls");
                });

            modelBuilder.Entity("SmallStructuresTakeOffs.Models.SmallStructure", b =>
                {
                    b.Property<int>("SmStId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HWcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThisStructure")
                        .HasColumnType("int");

                    b.HasKey("SmStId");

                    b.ToTable("SmallStructures");
                });

            modelBuilder.Entity("SmallStructuresTakeOffs.RebarRequest", b =>
                {
                    b.Property<int>("RebarRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ProjectId")
                        .HasColumnType("bigint");

                    b.Property<string>("RebReqDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RebReqProjId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("RebarRequestLength")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RebarRequestNomination")
                        .HasColumnType("int");

                    b.Property<int>("RebarRequestQty")
                        .HasColumnType("int");

                    b.Property<string>("Structure")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RebarRequestId");

                    b.HasIndex("ProjectId");

                    b.ToTable("RebarRequests");
                });

            modelBuilder.Entity("SmallStructuresTakeOffs.Models.CBc1580", b =>
                {
                    b.HasBaseType("SmallStructuresTakeOffs.Models.CatchBasin");

                    b.HasDiscriminator().HasValue("CBc1580");
                });

            modelBuilder.Entity("SmallStructuresTakeOffs.Models.CatchBasin", b =>
                {
                    b.HasOne("SmallStructuresTakeOffs.Models.Project", "Project")
                        .WithMany("CatchBasins")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("SmallStructuresTakeOffs.Models.RebarWasting", b =>
                {
                    b.HasOne("SmallStructuresTakeOffs.RebarRequest", "RebarRequest")
                        .WithMany("RebarWastings")
                        .HasForeignKey("RebarRequestId");

                    b.Navigation("RebarRequest");
                });

            modelBuilder.Entity("SmallStructuresTakeOffs.RebarRequest", b =>
                {
                    b.HasOne("SmallStructuresTakeOffs.Models.Project", null)
                        .WithMany("RebarRequests")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("SmallStructuresTakeOffs.Models.Project", b =>
                {
                    b.Navigation("CatchBasins");

                    b.Navigation("RebarRequests");
                });

            modelBuilder.Entity("SmallStructuresTakeOffs.RebarRequest", b =>
                {
                    b.Navigation("RebarWastings");
                });
#pragma warning restore 612, 618
        }
    }
}
