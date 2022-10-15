﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NeoSoftHRMS.Persistence;

#nullable disable

namespace NeoSoftHRMS.Persistence.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    [Migration("20221014121222_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.AccessGroup", b =>
                {
                    b.Property<int>("AccessGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccessGroupId"), 1L, 1);

                    b.Property<string>("AccessGroupName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("AccessGroupId");

                    b.ToTable("AccessGroupTbl");
                });

            modelBuilder.Entity("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.Branch", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BranchId"), 1L, 1);

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BranchId");

                    b.ToTable("BranchTbl");
                });

            modelBuilder.Entity("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"), 1L, 1);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("StateId");

                    b.ToTable("CityTbl");
                });

            modelBuilder.Entity("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"), 1L, 1);

                    b.Property<int>("CountryCode")
                        .HasColumnType("int");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CountryId");

                    b.ToTable("CountryTbl");
                });

            modelBuilder.Entity("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.Designation", b =>
                {
                    b.Property<int>("DesignationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DesignationId"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DesignationName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DesignationId");

                    b.ToTable("DesignationTbl");
                });

            modelBuilder.Entity("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.Division", b =>
                {
                    b.Property<int>("DivisionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DivisionId"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DivisionName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DivisionId");

                    b.ToTable("DivisionTbl");
                });

            modelBuilder.Entity("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.EmployeeType", b =>
                {
                    b.Property<int>("EmployeeTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeTypeId"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeTypeName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeTypeId");

                    b.ToTable("EmployeeTypeTbl");
                });

            modelBuilder.Entity("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenderId"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GenderName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("GenderId");

                    b.ToTable("GenderTbl");
                });

            modelBuilder.Entity("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.HeadDesignation", b =>
                {
                    b.Property<int>("HeadDesignationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HeadDesignationId"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HeadDesignationName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("HeadDesignationId");

                    b.ToTable("HeadDesignationTbl");
                });

            modelBuilder.Entity("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"), 1L, 1);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<int?>("ModiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("LocationId");

                    b.HasIndex("CityId");

                    b.ToTable("LocationTbl");
                });

            modelBuilder.Entity("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.SeniorHead", b =>
                {
                    b.Property<int>("SeniorHeadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SeniorHeadId"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HeadDesignationId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SeniorHeadName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.HasKey("SeniorHeadId");

                    b.HasIndex("HeadDesignationId");

                    b.ToTable("SeniorHeadTbl");
                });

            modelBuilder.Entity("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.Shift", b =>
                {
                    b.Property<int>("ShiftId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShiftId"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShiftName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.HasKey("ShiftId");

                    b.ToTable("ShiftTbl");
                });

            modelBuilder.Entity("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StateId"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.HasKey("StateId");

                    b.HasIndex("CountryId");

                    b.ToTable("StateTbl");
                });

            modelBuilder.Entity("NeoSoftHRMS.Persistence.Model.EmployeeModel.AddEmployee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"), 1L, 1);

                    b.Property<int>("AccessGroupId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(250)");

                    b.Property<string>("BccEmail")
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("CcEmail")
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("DesignationId")
                        .HasColumnType("int");

                    b.Property<int>("DivisionId")
                        .HasColumnType("int");

                    b.Property<string>("DutyHour")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(8)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("EmployeeCode")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeTypeId")
                        .HasColumnType("int");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<int>("HeadDesignationId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("IndianExtNo")
                        .HasColumnType("NVARCHAR(5)");

                    b.Property<string>("IndianLandLine")
                        .HasColumnType("NVARCHAR(15)");

                    b.Property<string>("IndianMobile")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LeftCompany")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LeftDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<bool>("LoginStatus")
                        .HasColumnType("bit");

                    b.Property<string>("PanNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(32)");

                    b.Property<string>("Pincode")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(6)");

                    b.Property<int>("SeniorHeadId")
                        .HasColumnType("int");

                    b.Property<int>("ShiftId")
                        .HasColumnType("int");

                    b.Property<string>("Signature")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("SkypeId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(15)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<string>("USLandLine")
                        .HasColumnType("NVARCHAR(15)");

                    b.Property<string>("USMobile")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(30)");

                    b.HasKey("EmployeeID");

                    b.HasIndex("AccessGroupId");

                    b.HasIndex("BranchId");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("DesignationId");

                    b.HasIndex("DivisionId");

                    b.HasIndex("EmployeeTypeId");

                    b.HasIndex("GenderId");

                    b.HasIndex("HeadDesignationId");

                    b.HasIndex("LocationId");

                    b.HasIndex("SeniorHeadId");

                    b.HasIndex("ShiftId");

                    b.HasIndex("StateId");

                    b.ToTable("AddEmployeeTbl");
                });

            modelBuilder.Entity("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.City", b =>
                {
                    b.HasOne("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.Location", b =>
                {
                    b.HasOne("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.SeniorHead", b =>
                {
                    b.HasOne("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.HeadDesignation", "HeadDesignation")
                        .WithMany()
                        .HasForeignKey("HeadDesignationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HeadDesignation");
                });

            modelBuilder.Entity("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.State", b =>
                {
                    b.HasOne("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("NeoSoftHRMS.Persistence.Model.EmployeeModel.AddEmployee", b =>
                {
                    b.HasOne("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.AccessGroup", "AccessGroup")
                        .WithMany()
                        .HasForeignKey("AccessGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.Designation", "Designation")
                        .WithMany()
                        .HasForeignKey("DesignationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.EmployeeType", "EmployeeType")
                        .WithMany()
                        .HasForeignKey("EmployeeTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.HeadDesignation", "HeadDesignation")
                        .WithMany()
                        .HasForeignKey("HeadDesignationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.SeniorHead", "SeniorHead")
                        .WithMany()
                        .HasForeignKey("SeniorHeadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.Shift", "Shift")
                        .WithMany()
                        .HasForeignKey("ShiftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NeoSoftHRMS.Persistence.Model.EmployeeMasterModel.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccessGroup");

                    b.Navigation("Branch");

                    b.Navigation("City");

                    b.Navigation("Country");

                    b.Navigation("Designation");

                    b.Navigation("Division");

                    b.Navigation("EmployeeType");

                    b.Navigation("Gender");

                    b.Navigation("HeadDesignation");

                    b.Navigation("Location");

                    b.Navigation("SeniorHead");

                    b.Navigation("Shift");

                    b.Navigation("State");
                });
#pragma warning restore 612, 618
        }
    }
}
