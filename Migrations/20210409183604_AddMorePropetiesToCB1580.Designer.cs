﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmallStructuresTakeOffs.Models;

namespace SmallStructuresTakeOffs.Migrations
{
    [DbContext(typeof(EFCoreDBcontext))]
    [Migration("20210409183604_AddMorePropetiesToCB1580")]
    partial class AddMorePropetiesToCB1580
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
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("C1580Reb4FandI")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("C1580Reb4Purch")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("C1580CBId");

                    b.ToTable("C1580CBs");
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
#pragma warning restore 612, 618
        }
    }
}
