﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Session9_DataAccess.DataAccess;

namespace Session9_DataAccess.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("Session9_DataAccess.Models.Course", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(4)
                        .HasColumnType("TEXT");

                    b.Property<int>("ECTS")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsElective")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProgrammeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Semester")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProgrammeId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Session9_DataAccess.Models.Programme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("HeadOfDepartment")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Programmes");
                });

            modelBuilder.Entity("Session9_DataAccess.Models.Course", b =>
                {
                    b.HasOne("Session9_DataAccess.Models.Programme", null)
                        .WithMany("Courses")
                        .HasForeignKey("ProgrammeId");
                });

            modelBuilder.Entity("Session9_DataAccess.Models.Programme", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
