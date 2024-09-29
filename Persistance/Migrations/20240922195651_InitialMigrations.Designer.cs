﻿// <auto-generated />
using System;
using CardsDataIntegration.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CardsDataIntegration.Persistance.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240922195651_InitialMigrations")]
    partial class InitialMigrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CardsDataIntegration.Domains.Client", b =>
                {
                    b.Property<string>("CardCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Bonus")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenderId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneMobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Pincode")
                        .HasColumnType("int");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Turnover")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CardCode");

                    b.ToTable("Clients");
                });
#pragma warning restore 612, 618
        }
    }
}
