﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using krv7.Data;

#nullable disable

namespace kr_v7.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241119205348_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("krv7.Models.Cage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ChickenId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ChickenId")
                        .IsUnique();

                    b.HasIndex("EmployeeId");

                    b.ToTable("Cages");
                });

            modelBuilder.Entity("krv7.Models.Chicken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CageId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EggsPerMonth")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Chickens");
                });

            modelBuilder.Entity("krv7.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Salary")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("krv7.Models.Cage", b =>
                {
                    b.HasOne("krv7.Models.Chicken", "Chicken")
                        .WithOne("Cage")
                        .HasForeignKey("krv7.Models.Cage", "ChickenId");

                    b.HasOne("krv7.Models.Employee", "Employee")
                        .WithMany("Cages")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chicken");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("krv7.Models.Chicken", b =>
                {
                    b.Navigation("Cage");
                });

            modelBuilder.Entity("krv7.Models.Employee", b =>
                {
                    b.Navigation("Cages");
                });
#pragma warning restore 612, 618
        }
    }
}
