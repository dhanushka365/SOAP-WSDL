﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using REST_Practise.Data;

#nullable disable

namespace SOAP_WSDL.Migrations
{
    [DbContext(typeof(ERPContext))]
    [Migration("20230912184011_initial1")]
    partial class initial1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SOAP_WSDL.Models.DepartmentModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ba27bab6-555a-46b5-872f-85b2034f976c"),
                            DepartmentName = "Engineering"
                        },
                        new
                        {
                            Id = new Guid("4eff9ad5-04e8-489e-aa03-afe954b749fd"),
                            DepartmentName = "Quality Assuarance"
                        },
                        new
                        {
                            Id = new Guid("e00154e2-275e-4adc-87dc-1bbc47496807"),
                            DepartmentName = "Human Resource"
                        },
                        new
                        {
                            Id = new Guid("e02e5a30-af23-4e3e-818f-d3fc2ef6119f"),
                            DepartmentName = "Support"
                        },
                        new
                        {
                            Id = new Guid("e9b98f77-73b4-4a8d-a7dc-ffb2323521e1"),
                            DepartmentName = "Managed Services"
                        });
                });

            modelBuilder.Entity("SOAP_WSDL.Models.EmployeeModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BOD")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DepartmentModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentModelId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("SOAP_WSDL.Models.ProfileModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeModelId");

                    b.HasIndex("RoleModelId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("SOAP_WSDL.Models.RoleModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4083a078-471c-4735-9621-f143eacfeb1e"),
                            ConcurrencyStamp = "",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("ba9d7e41-2eaf-4fd4-b72f-ec16cae6a552"),
                            ConcurrencyStamp = "",
                            Name = "user",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("SOAP_WSDL.Models.SalaryModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("BasicSalary")
                        .HasColumnType("float");

                    b.Property<double>("Bonus")
                        .HasColumnType("float");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeModelId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeModelId");

                    b.ToTable("Salarys");
                });

            modelBuilder.Entity("SOAP_WSDL.Models.EmployeeModel", b =>
                {
                    b.HasOne("SOAP_WSDL.Models.DepartmentModel", "DepartmentModel")
                        .WithMany()
                        .HasForeignKey("DepartmentModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DepartmentModel");
                });

            modelBuilder.Entity("SOAP_WSDL.Models.ProfileModel", b =>
                {
                    b.HasOne("SOAP_WSDL.Models.EmployeeModel", "EmployeeModel")
                        .WithMany()
                        .HasForeignKey("EmployeeModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SOAP_WSDL.Models.RoleModel", "RoleModel")
                        .WithMany()
                        .HasForeignKey("RoleModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeModel");

                    b.Navigation("RoleModel");
                });

            modelBuilder.Entity("SOAP_WSDL.Models.SalaryModel", b =>
                {
                    b.HasOne("SOAP_WSDL.Models.EmployeeModel", "EmployeeModel")
                        .WithMany()
                        .HasForeignKey("EmployeeModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeModel");
                });
#pragma warning restore 612, 618
        }
    }
}
