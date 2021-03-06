﻿// <auto-generated />
using System;
using HouseHunt.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HouseHunt.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190920185834_FloorPlan")]
    partial class FloorPlan
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HouseHunt.Models.House", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("FloorPlan");

                    b.Property<string>("ImageThumbnailUrl");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("LongDescription");

                    b.Property<int>("Price");

                    b.Property<string>("RightMoveUrl");

                    b.Property<string>("ShortDescription");

                    b.Property<bool>("Sold");

                    b.Property<DateTime>("WhenSeen");

                    b.HasKey("Id");

                    b.ToTable("Houses");
                });
#pragma warning restore 612, 618
        }
    }
}
