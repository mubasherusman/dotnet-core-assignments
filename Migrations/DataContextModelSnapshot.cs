﻿// <auto-generated />
using System;
using DotNetAssignment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotNetAssignment.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("DotNetAssignment.Models.BankAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(60);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("DotNetAssignment.Models.DebitCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BankAccountId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CardName")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Pan")
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.HasIndex("BankAccountId");

                    b.ToTable("DebitCards");
                });

            modelBuilder.Entity("DotNetAssignment.Models.DebitCard", b =>
                {
                    b.HasOne("DotNetAssignment.Models.BankAccount", "BankAccount")
                        .WithMany("DebitCards")
                        .HasForeignKey("BankAccountId");
                });
#pragma warning restore 612, 618
        }
    }
}
