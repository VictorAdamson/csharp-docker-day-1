﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using exercise.wwwapi.Data;

#nullable disable

namespace exercise.wwwapi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("exercise.wwwapi.DataModels.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("StartDate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("start_date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A Boolean fullstack course about .NET",
                            StartDate = "08/01-24",
                            Title = ".NET"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A Boolean course about Java",
                            StartDate = "08/01-24",
                            Title = "Java"
                        });
                });

            modelBuilder.Entity("exercise.wwwapi.DataModels.Join_student_course", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("integer")
                        .HasColumnName("student_id");

                    b.Property<int>("CourseId")
                        .HasColumnType("integer")
                        .HasColumnName("course_id");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("Students_Courses");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            CourseId = 1
                        },
                        new
                        {
                            StudentId = 2,
                            CourseId = 1
                        },
                        new
                        {
                            StudentId = 3,
                            CourseId = 2
                        },
                        new
                        {
                            StudentId = 3,
                            CourseId = 1
                        });
                });

            modelBuilder.Entity("exercise.wwwapi.DataModels.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AvgGrade")
                        .HasColumnType("integer")
                        .HasColumnName("avg_grade");

                    b.Property<string>("DoB")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("dob");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.HasKey("Id");

                    b.ToTable("students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvgGrade = 2,
                            DoB = "03/02-00",
                            FirstName = "Victor",
                            LastName = "Adamson"
                        },
                        new
                        {
                            Id = 2,
                            AvgGrade = 1,
                            DoB = "14/11-95",
                            FirstName = "Person",
                            LastName = "Human"
                        },
                        new
                        {
                            Id = 3,
                            AvgGrade = 4,
                            DoB = "22/06-98",
                            FirstName = "Beep",
                            LastName = "NaN"
                        });
                });

            modelBuilder.Entity("exercise.wwwapi.DataModels.Join_student_course", b =>
                {
                    b.HasOne("exercise.wwwapi.DataModels.Course", "Course")
                        .WithMany("Students")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("exercise.wwwapi.DataModels.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("exercise.wwwapi.DataModels.Course", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("exercise.wwwapi.DataModels.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
