﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentARide.Infrastructure;

namespace RentARide.Infrastructure.Migrations
{
    [DbContext(typeof(TrustedRideDbContext))]
    [Migration("20200813063441_InitialDbSeed")]
    partial class InitialDbSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RentARide.Domain.Models.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            BrandId = 1,
                            Description = "Integrity, compliance and diversity",
                            Name = "Bugatti"
                        },
                        new
                        {
                            BrandId = 2,
                            Description = "Italian excellence the rest of the world can only dream of",
                            Name = "Ferrari"
                        },
                        new
                        {
                            BrandId = 3,
                            Description = "Iconic Luxury British Sports Cars",
                            Name = "Aston Martin"
                        },
                        new
                        {
                            BrandId = 4,
                            Description = "Go Further",
                            Name = "Ford"
                        },
                        new
                        {
                            BrandId = 5,
                            Description = "Find New Roads",
                            Name = "Chevrolet"
                        });
                });

            modelBuilder.Entity("RentARide.Domain.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsInPromotion")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ProductionYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<string>("ThumbnailPictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarId");

                    b.HasIndex("BrandId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            CarId = 1,
                            BrandId = 1,
                            IsAvailable = true,
                            IsInPromotion = true,
                            LongDescription = "The original version has a top speed of 407 km/h (253 mph). It was named Car of the Decade and best car award (2000–2009) by the BBC television programme Top Gear. The standard Bugatti Veyron also won Top Gear's Best Car Driven All Year award in 2005.",
                            Name = "Bugatti Veyron 16.4",
                            PictureUrl = "/images/cars/bugatti_veyron.jpg",
                            Price = 80.55m,
                            ProductionYear = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ShortDescription = "Mid-engine sports super car.",
                            Speed = 407,
                            ThumbnailPictureUrl = "/images/cars/bugatti_veyron.jpg"
                        },
                        new
                        {
                            CarId = 2,
                            BrandId = 2,
                            IsAvailable = true,
                            IsInPromotion = true,
                            LongDescription = "The F8 Tributo uses the same engine from the 488 Pista, a 3.9 L twin-turbocharged V8 engine, making it the most powerful conventional V8 powered Ferrari produced to date. Specific intake plenums and manifolds with optimised fluid-dynamics improve the combustion efficiency of the engine, thanks to the reduction of the temperature of the air in the cylinder, which also helps boost power.",
                            Name = "Ferrari F8 Tributo",
                            PictureUrl = "/images/cars/ferrari_f8_tributo.jpg",
                            Price = 70.55m,
                            ProductionYear = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ShortDescription = "Mid-engine sports super car.",
                            Speed = 340,
                            ThumbnailPictureUrl = "/images/cars/ferrari_f8_tributo.jpg"
                        },
                        new
                        {
                            CarId = 3,
                            BrandId = 2,
                            IsAvailable = false,
                            IsInPromotion = true,
                            LongDescription = "In Ferrari's first official announcement of the car, the 458 was described as the successor to the F430 but arising from an entirely new design, incorporating technologies developed from the company's experience in Formula One. The body computer system was developed by Magneti Marelli.",
                            Name = "Ferrari 458",
                            PictureUrl = "/images/cars/ferrari_458.jpg",
                            Price = 65.55m,
                            ProductionYear = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ShortDescription = "Mid-engine sports super car.",
                            Speed = 340,
                            ThumbnailPictureUrl = "/images/cars/ferrari_458.jpg"
                        },
                        new
                        {
                            CarId = 4,
                            BrandId = 3,
                            IsAvailable = true,
                            IsInPromotion = true,
                            LongDescription = "The second-generation 'Vanquish' (the 'V12' part of the name was dropped for this generation of cars) started life as the Project AM310 Concept and was unveiled at the 2012 Concorso d'Eleganza at Villa d'Este held on the shores of Lake Como, Italy. The concept car was based on the fourth generation of the VH platform.",
                            Name = "Aston Martin Vanquish",
                            PictureUrl = "/images/cars/aston_martin_vanquish.jpg",
                            Price = 60.55m,
                            ProductionYear = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ShortDescription = "Grand tourer",
                            Speed = 306,
                            ThumbnailPictureUrl = "/images/cars/aston_martin_vanquish.jpg"
                        },
                        new
                        {
                            CarId = 5,
                            BrandId = 4,
                            IsAvailable = true,
                            IsInPromotion = false,
                            LongDescription = "In continuous production since 1964, the Mustang is currently the longest-produced Ford car nameplate. Currently in its sixth generation, it is the fifth-best selling Ford car nameplate. The namesake of the 'pony car' automobile segment, the Mustang was developed as a highly styled line of sporty coupes and convertibles derived from existing model lines, initially distinguished by 'long hood, short deck' proportions.",
                            Name = "Ford Mustang GT 2018",
                            PictureUrl = "/images/cars/ford_mustang_gt.jpg",
                            Price = 64.70m,
                            ProductionYear = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ShortDescription = "Muscle car",
                            Speed = 250,
                            ThumbnailPictureUrl = "/images/cars/ford_mustang_gt.jpg"
                        },
                        new
                        {
                            CarId = 6,
                            BrandId = 5,
                            IsAvailable = true,
                            IsInPromotion = false,
                            LongDescription = "A mid-size American automobile manufactured by Chevrolet, classified as a pony car. Competing model to the Ford Mustang.",
                            Name = "Chevrolet Camaro SS",
                            PictureUrl = "/images/cars/chevrolet-camaro-ss.jpg",
                            Price = 62.50m,
                            ProductionYear = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ShortDescription = "Pony car",
                            Speed = 250,
                            ThumbnailPictureUrl = "/images/cars/chevrolet-camaro-ss.jpg"
                        });
                });

            modelBuilder.Entity("RentARide.Domain.Models.Car", b =>
                {
                    b.HasOne("RentARide.Domain.Models.Brand", "Brand")
                        .WithMany("Cars")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
