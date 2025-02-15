﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mission8_covey.Models;

namespace mission8_covey.Migrations
{
    [DbContext(typeof(TaskContext))]
    [Migration("20230222235310_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("mission8_covey.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Home"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "School"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Work"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Church"
                        });
                });

            modelBuilder.Entity("mission8_covey.Models.TaskResponse", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Task")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("completed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("dueDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("quadrant")
                        .HasColumnType("INTEGER");

                    b.HasKey("TaskId");

                    b.HasIndex("CategoryID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            TaskId = 1,
                            CategoryID = 1,
                            Task = "Buy Food",
                            completed = false,
                            dueDate = new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            quadrant = 2
                        });
                });

            modelBuilder.Entity("mission8_covey.Models.TaskResponse", b =>
                {
                    b.HasOne("mission8_covey.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
