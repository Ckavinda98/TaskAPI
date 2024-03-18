﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskApi.DataAccess;

#nullable disable

namespace TaskApi.DataAccess.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    [Migration("20240316030617_AddingDataAnnotation")]
    partial class AddingDataAnnotation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TaskAPI.Models.Aurthor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Aurthors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressNo = "45",
                            City = "Colombo",
                            FullName = "Malith Fernandol",
                            Street = "Flower Road"
                        },
                        new
                        {
                            Id = 2,
                            AddressNo = "10",
                            City = "Kaluthara",
                            FullName = "Kevin Aravinda",
                            Street = "Smaagi Road"
                        },
                        new
                        {
                            Id = 3,
                            AddressNo = "67",
                            City = "Gampaha",
                            FullName = "Dilina Supun",
                            Street = "Fifth lane"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AurthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("Deu")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("AurthorId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AurthorId = 1,
                            Created = new DateTime(2024, 3, 16, 8, 36, 16, 668, DateTimeKind.Local).AddTicks(260),
                            Description = "Test",
                            Deu = new DateTime(2024, 3, 21, 8, 36, 16, 668, DateTimeKind.Local).AddTicks(276),
                            Status = 0,
                            Title = "Example 1 - DB"
                        },
                        new
                        {
                            Id = 2,
                            AurthorId = 3,
                            Created = new DateTime(2024, 3, 16, 8, 36, 16, 668, DateTimeKind.Local).AddTicks(287),
                            Description = "Test",
                            Deu = new DateTime(2024, 3, 21, 8, 36, 16, 668, DateTimeKind.Local).AddTicks(289),
                            Status = 0,
                            Title = "Example 2 - DB"
                        },
                        new
                        {
                            Id = 3,
                            AurthorId = 2,
                            Created = new DateTime(2024, 3, 16, 8, 36, 16, 668, DateTimeKind.Local).AddTicks(292),
                            Description = "Test",
                            Deu = new DateTime(2024, 3, 21, 8, 36, 16, 668, DateTimeKind.Local).AddTicks(294),
                            Status = 0,
                            Title = "Example 3 - DB"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.HasOne("TaskAPI.Models.Aurthor", "Aurthor")
                        .WithMany("Todos")
                        .HasForeignKey("AurthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aurthor");
                });

            modelBuilder.Entity("TaskAPI.Models.Aurthor", b =>
                {
                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}