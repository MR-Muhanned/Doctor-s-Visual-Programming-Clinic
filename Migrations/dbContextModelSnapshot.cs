﻿// <auto-generated />
using System;
using DR.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DR.Migrations
{
    [DbContext(typeof(dbContext))]
    partial class dbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DR.model.Diag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Notes1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Receiving")
                        .HasColumnType("int");

                    b.Property<string>("TheNameOfTheDisease")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("diagnosis");
                });

            modelBuilder.Entity("DR.model.Prescription1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Drug1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Drug2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Drug3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Drug4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Drug5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberOfDoses1")
                        .HasColumnType("int");

                    b.Property<int?>("NumberOfDoses2")
                        .HasColumnType("int");

                    b.Property<int?>("NumberOfDoses3")
                        .HasColumnType("int");

                    b.Property<int?>("NumberOfDoses4")
                        .HasColumnType("int");

                    b.Property<int?>("NumberOfDoses5")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("prescriptions");
                });

            modelBuilder.Entity("DR.model.PrescriptionDDD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DiagnosisId")
                        .HasColumnType("int");

                    b.Property<int?>("IdDiagnosis")
                        .HasColumnType("int");

                    b.Property<int?>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<int>("PrescriptionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DiagnosisId");

                    b.HasIndex("PrescriptionId");

                    b.ToTable("prescriptionDDDs");
                });

            modelBuilder.Entity("DR.model.Receiving1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("ChronicDiseases")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateSession")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSick")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfInspection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhereToLive")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Receivings");
                });

            modelBuilder.Entity("DR.model.login", b =>
                {
                    b.Property<string>("username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("username");

                    b.ToTable("login");
                });

            modelBuilder.Entity("DR.model.PrescriptionDDD", b =>
                {
                    b.HasOne("DR.model.Diag", "Diagnosis")
                        .WithMany()
                        .HasForeignKey("DiagnosisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DR.model.Prescription1", "Prescription")
                        .WithMany()
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diagnosis");

                    b.Navigation("Prescription");
                });
#pragma warning restore 612, 618
        }
    }
}
