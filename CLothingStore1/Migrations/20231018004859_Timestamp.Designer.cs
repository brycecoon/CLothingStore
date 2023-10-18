﻿// <auto-generated />
using System;
using CLothingStore1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CLothingStore1.Migrations
{
    [DbContext(typeof(ClothingManagerDBContext))]
    [Migration("20231018004859_Timestamp")]
    partial class Timestamp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CLothingStore1.Data.Models.Clothing", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("DepartmentId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<bool>("isTrending")
                        .HasColumnType("bit");

                    b.Property<string>("size")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Clothings");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DepartmentId = 1,
                            isTrending = true,
                            size = "large",
                            type = "shirt"
                        },
                        new
                        {
                            ID = 2,
                            DepartmentId = 4,
                            isTrending = false,
                            size = "Medium",
                            type = "Pants"
                        },
                        new
                        {
                            ID = 3,
                            DepartmentId = 3,
                            isTrending = false,
                            size = "10",
                            type = "Shoes"
                        },
                        new
                        {
                            ID = 4,
                            DepartmentId = 5,
                            isTrending = true,
                            size = "large",
                            type = "Shorts"
                        },
                        new
                        {
                            ID = 5,
                            DepartmentId = 4,
                            isTrending = true,
                            size = "small",
                            type = "skirt"
                        },
                        new
                        {
                            ID = 6,
                            DepartmentId = 2,
                            isTrending = false,
                            size = "xLarge",
                            type = "shirt"
                        },
                        new
                        {
                            ID = 7,
                            DepartmentId = 1,
                            isTrending = false,
                            size = "large",
                            type = "shirt"
                        },
                        new
                        {
                            ID = 8,
                            DepartmentId = 5,
                            isTrending = true,
                            size = "small",
                            type = "pants"
                        });
                });

            modelBuilder.Entity("CLothingStore1.Data.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            name = "Men"
                        },
                        new
                        {
                            Id = 2,
                            name = "Women"
                        },
                        new
                        {
                            Id = 3,
                            name = "Boys"
                        },
                        new
                        {
                            Id = 4,
                            name = "Girls"
                        },
                        new
                        {
                            Id = 5,
                            name = "Babies"
                        });
                });

            modelBuilder.Entity("CLothingStore1.Data.Models.Clothing", b =>
                {
                    b.HasOne("CLothingStore1.Data.Models.Department", "Department")
                        .WithMany("Clothings")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("CLothingStore1.Data.Models.Department", b =>
                {
                    b.Navigation("Clothings");
                });
#pragma warning restore 612, 618
        }
    }
}
