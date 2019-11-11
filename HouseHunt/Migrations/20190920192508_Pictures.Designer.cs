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
    [Migration("20190920192508_Pictures")]
    partial class Pictures
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

            modelBuilder.Entity("HouseHunt.Models.Picture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HouseId");

                    b.Property<string>("URL");

                    b.HasKey("Id");

                    b.HasIndex("HouseId");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("HouseHunt.Models.Picture", b =>
                {
                    b.HasOne("HouseHunt.Models.House", "House")
                        .WithMany("Pictures")
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}