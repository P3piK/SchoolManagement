﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolManagement.Persistance;

namespace SchoolManagement.Persistance.Migrations
{
    [DbContext(typeof(SmContext))]
    partial class SmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SchoolManagement.Domain.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodeGenerationDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EditDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserFK")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserFK");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("SchoolManagement.Domain.Entities.CourseGrade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseFK")
                        .HasColumnType("int");

                    b.Property<DateTime>("EditDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Grade")
                        .HasColumnType("float");

                    b.Property<int?>("UserFK")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseFK");

                    b.HasIndex("UserFK");

                    b.ToTable("CourseGrades");
                });

            modelBuilder.Entity("SchoolManagement.Domain.Entities.CourseGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseFK")
                        .HasColumnType("int");

                    b.Property<DateTime>("EditDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserFK")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseFK");

                    b.HasIndex("UserFK");

                    b.ToTable("CourseGroups");
                });

            modelBuilder.Entity("SchoolManagement.Domain.Entities.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseFK")
                        .HasColumnType("int");

                    b.Property<DateTime>("EditDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseFK");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("SchoolManagement.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EditDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusCode")
                        .HasColumnType("int");

                    b.Property<int>("UserTypeCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SchoolManagement.Domain.Entities.Course", b =>
                {
                    b.HasOne("SchoolManagement.Domain.Entities.User", "Tutor")
                        .WithMany()
                        .HasForeignKey("UserFK");
                });

            modelBuilder.Entity("SchoolManagement.Domain.Entities.CourseGrade", b =>
                {
                    b.HasOne("SchoolManagement.Domain.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseFK");

                    b.HasOne("SchoolManagement.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserFK");
                });

            modelBuilder.Entity("SchoolManagement.Domain.Entities.CourseGroup", b =>
                {
                    b.HasOne("SchoolManagement.Domain.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseFK");

                    b.HasOne("SchoolManagement.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserFK");
                });

            modelBuilder.Entity("SchoolManagement.Domain.Entities.Lesson", b =>
                {
                    b.HasOne("SchoolManagement.Domain.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseFK");
                });
#pragma warning restore 612, 618
        }
    }
}
