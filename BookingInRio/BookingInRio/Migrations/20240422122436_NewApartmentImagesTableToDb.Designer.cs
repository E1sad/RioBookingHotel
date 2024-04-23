﻿// <auto-generated />
using System;
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
    [Migration("20240422122436_NewApartmentImagesTableToDb")]
    partial class NewApartmentImagesTableToDb
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
                            ApartmentThumbnailImagePath = "/assets/media/apartment-3.jpg",
                            BedCounts = 2,
                            Description = "Our Penthouse Suites offer breathtaking views of the city skyline.",
                            Name = "Penthouse",
                            PersonLimitSize = 2,
                            PriceOfRoom = 1250.0,
                            SizeOfRoomInSqrMeter = 220f
                        });
                });

            modelBuilder.Entity("BookingInRio.Models.ApartmentImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.ToTable("ApartmentImages");
                });

            modelBuilder.Entity("BookingInRio.Models.DatesApartmentReserved", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApartId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("date");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("ApartId");

                    b.ToTable("DatesApartmentsReserved");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApartId = 1,
                            EndTime = new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            ApartId = 3,
                            EndTime = new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            ApartId = 2,
                            EndTime = new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("BookingInRio.Models.DetailedApartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AboutApartmentId")
                        .HasColumnType("int");

                    b.Property<string>("DetailedDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonLimitSize")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AboutApartmentId")
                        .IsUnique();

                    b.ToTable("DetailedApartmentInfos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AboutApartmentId = 1,
                            DetailedDescription = "Affordable luxury. Our Junior Suites are the perfect option if you’re looking for a little extra luxury. With an open 65.5 square meter floor plan, the Junior Suites offer the extra space you need to spread out and enjoy the breathtaking views of the city skyline",
                            PersonLimitSize = 2
                        },
                        new
                        {
                            Id = 2,
                            AboutApartmentId = 3,
                            DetailedDescription = "Affordable luxury. Our Penthouse are the perfect option if you’re looking for a little extra luxury. With an open 220 square foot floor plan, the Junior Suites offer the extra space you need to spread out and enjoy the breathtaking views of the city skyline",
                            PersonLimitSize = 2
                        },
                        new
                        {
                            Id = 3,
                            AboutApartmentId = 2,
                            DetailedDescription = "Our King Suites represent affordable luxury, making them an excellent choice for those desiring a touch of extravagance. These suites provide a spacious 120.3 square meter layout that allows guests to relax comfortably while admiring stunning city skyline views.",
                            PersonLimitSize = 6
                        });
                });

            modelBuilder.Entity("BookingInRio.Models.EmailList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("SubscribersEmails");
                });

            modelBuilder.Entity("BookingInRio.Models.ApartmentImage", b =>
                {
                    b.HasOne("BookingInRio.Models.AboutApartment", "Apartment")
                        .WithMany()
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Apartment");
                });

            modelBuilder.Entity("BookingInRio.Models.DatesApartmentReserved", b =>
                {
                    b.HasOne("BookingInRio.Models.AboutApartment", "Apartment")
                        .WithMany("ReservedTimes")
                        .HasForeignKey("ApartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Apartment");
                });

            modelBuilder.Entity("BookingInRio.Models.DetailedApartment", b =>
                {
                    b.HasOne("BookingInRio.Models.AboutApartment", "AboutApartment")
                        .WithOne("DetailedInformationApartment")
                        .HasForeignKey("BookingInRio.Models.DetailedApartment", "AboutApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AboutApartment");
                });

            modelBuilder.Entity("BookingInRio.Models.AboutApartment", b =>
                {
                    b.Navigation("DetailedInformationApartment")
                        .IsRequired();

                    b.Navigation("ReservedTimes");
                });
#pragma warning restore 612, 618
        }
    }
}
