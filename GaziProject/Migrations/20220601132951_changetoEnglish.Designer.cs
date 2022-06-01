﻿// <auto-generated />
using System;
using GaziProject.GaziProjectDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GaziProject.Migrations
{
    [DbContext(typeof(GaziProjectContext))]
    [Migration("20220601132951_changetoEnglish")]
    partial class changetoEnglish
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GaziProject.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DepartmentCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("GaziProject.Models.Lecture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Credit")
                        .HasColumnType("int");

                    b.Property<string>("LectureCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LectureName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("GaziProject.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AddedTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("Average")
                        .HasColumnType("float");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("StudentLastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("GaziProject.Models.StudentLecture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("FinalNote")
                        .HasColumnType("float");

                    b.Property<int>("HowManyTimes")
                        .HasColumnType("int");

                    b.Property<int>("LectureId")
                        .HasColumnType("int");

                    b.Property<double>("MidTermNote")
                        .HasColumnType("float");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LectureId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentLectures");
                });

            modelBuilder.Entity("GaziProject.Models.Student", b =>
                {
                    b.HasOne("GaziProject.Models.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("GaziProject.Models.StudentLecture", b =>
                {
                    b.HasOne("GaziProject.Models.Lecture", "Lecture")
                        .WithMany("StudentLectures")
                        .HasForeignKey("LectureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GaziProject.Models.Student", "Student")
                        .WithMany("StudentLectures")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lecture");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("GaziProject.Models.Department", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("GaziProject.Models.Lecture", b =>
                {
                    b.Navigation("StudentLectures");
                });

            modelBuilder.Entity("GaziProject.Models.Student", b =>
                {
                    b.Navigation("StudentLectures");
                });
#pragma warning restore 612, 618
        }
    }
}
