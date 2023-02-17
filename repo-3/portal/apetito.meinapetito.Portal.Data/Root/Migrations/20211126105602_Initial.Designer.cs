﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apetito.meinapetito.Portal.Data.Root;

#nullable disable

namespace apetito.meinapetito.Portal.Data.Root.Migrations
{
    [DbContext(typeof(PortalDbContext))]
    [Migration("20211126105602_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("SQL_Latin1_General_CP1_CS_AS")
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("apetito.meinapetito.Portal.Data.Root.User.CustomerNumberOfUserData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CustomerNumber")
                        .HasColumnType("int");

                    b.Property<string>("LanguageCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId", "CustomerNumber")
                        .IsUnique();

                    b.ToTable("CustomerNumbersOfUsers");
                });

            modelBuilder.Entity("apetito.meinapetito.Portal.Data.Root.User.SortimentOfCustomerNumberData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CustomerNumber")
                        .HasColumnType("int");

                    b.Property<string>("SortimentCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerNumber", "SortimentCode")
                        .IsUnique();

                    b.ToTable("SortimentsOfCustomerNumbers");
                });

            modelBuilder.Entity("apetito.meinapetito.Portal.Data.Root.User.UserData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AspNetUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("B2CUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("B2CUserId")
                        .IsUnique();

                    b.HasIndex("UserEmail")
                        .IsUnique();

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}