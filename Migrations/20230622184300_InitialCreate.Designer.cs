﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapi;

#nullable disable

namespace WEBAPI.Migrations
{
    [DbContext(typeof(EmployeesContext))]
    [Migration("20230622184300_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.5.23280.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("webapi.Models.tblArea", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid>("costcenterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("costcenterId");

                    b.ToTable("Area", (string)null);
                });

            modelBuilder.Entity("webapi.Models.tblCostCenter", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("CentrCostos", (string)null);
                });

            modelBuilder.Entity("webapi.Models.tblEmployee", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<Guid>("areaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("identification")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<Guid>("professionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("user")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("id");

                    b.HasIndex("areaId");

                    b.HasIndex("professionId");

                    b.ToTable("Empelados", (string)null);
                });

            modelBuilder.Entity("webapi.Models.tblProfession", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("Prefesion", (string)null);
                });

            modelBuilder.Entity("webapi.Models.tblArea", b =>
                {
                    b.HasOne("webapi.Models.tblCostCenter", "costcenter")
                        .WithMany("area")
                        .HasForeignKey("costcenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("costcenter");
                });

            modelBuilder.Entity("webapi.Models.tblEmployee", b =>
                {
                    b.HasOne("webapi.Models.tblArea", "area")
                        .WithMany("employee")
                        .HasForeignKey("areaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webapi.Models.tblProfession", "profession")
                        .WithMany("employee")
                        .HasForeignKey("professionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("area");

                    b.Navigation("profession");
                });

            modelBuilder.Entity("webapi.Models.tblArea", b =>
                {
                    b.Navigation("employee");
                });

            modelBuilder.Entity("webapi.Models.tblCostCenter", b =>
                {
                    b.Navigation("area");
                });

            modelBuilder.Entity("webapi.Models.tblProfession", b =>
                {
                    b.Navigation("employee");
                });
#pragma warning restore 612, 618
        }
    }
}