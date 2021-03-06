﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScoreService.Repository.sql;

namespace ScoreService.Repository.sql.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201110133349_init1")]
    partial class init1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ScoreService.Service.Models.BuildingScore", b =>
                {
                    b.Property<Guid>("FacilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MyPrSiteNameoperty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SiteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ZoneId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FacilityId");

                    b.ToTable("BuildingScores");
                });
#pragma warning restore 612, 618
        }
    }
}
