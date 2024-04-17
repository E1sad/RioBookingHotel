﻿// <auto-generated />
using BookingInRio.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookingInRio.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240417102633_AddThumbnailImagePathToAboutApartmentDb")]
    partial class AddThumbnailImagePathToAboutApartmentDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookingInRio.Models.AboutApartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApartmentThumbnailImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BedCounts")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonLimitSize")
                        .HasColumnType("int");

                    b.Property<double>("PriceOfRoom")
                        .HasColumnType("float");

                    b.Property<float>("SizeOfRoomInSqrMeter")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("AboutApartments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApartmentThumbnailImagePath = "/assets/media/apartment-1.jpg",
                            BedCounts = 2,
                            Description = "Our Junior Suites offer breathtaking views of the city skyline.",
                            Name = "Junior Suite",
                            PersonLimitSize = 2,
                            PriceOfRoom = 250.0,
                            SizeOfRoomInSqrMeter = 65.5f
                        },
                        new
                        {
                            Id = 2,
                            ApartmentThumbnailImagePath = "/assets/media/apartment-2.jpg",
                            BedCounts = 4,
                            Description = "Our King Suites offer breathtaking views of the city skyline.",
                            Name = "King Suite",
                            PersonLimitSize = 6,
                            PriceOfRoom = 500.0,
                            SizeOfRoomInSqrMeter = 120.3f
                        },
                        new
                        {
                            Id = 3,
                            ApartmentThumbnailImagePath = "/assets/media/apartment-2.jpg",
                            BedCounts = 2,
                            Description = "Our Penthouse Suites offer breathtaking views of the city skyline.",
                            Name = "Penthouse",
                            PersonLimitSize = 2,
                            PriceOfRoom = 1250.0,
                            SizeOfRoomInSqrMeter = 220f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
