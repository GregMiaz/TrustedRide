using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentARide.Infrastructure.Migrations
{
    public partial class InitialDbSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Integrity, compliance and diversity", "Bugatti" },
                    { 2, "Italian excellence the rest of the world can only dream of", "Ferrari" },
                    { 3, "Iconic Luxury British Sports Cars", "Aston Martin" },
                    { 4, "Go Further", "Ford" },
                    { 5, "Find New Roads", "Chevrolet" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "BrandId", "IsAvailable", "IsInPromotion", "LongDescription", "Name", "PictureUrl", "Price", "ProductionYear", "ShortDescription", "Speed", "ThumbnailPictureUrl" },
                values: new object[,]
                {
                    { 1, 1, true, true, "The original version has a top speed of 407 km/h (253 mph). It was named Car of the Decade and best car award (2000–2009) by the BBC television programme Top Gear. The standard Bugatti Veyron also won Top Gear's Best Car Driven All Year award in 2005.", "Bugatti Veyron 16.4", "/images/cars/bugatti_veyron.jpg", 80.55m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mid-engine sports super car.", 407, "/images/cars/bugatti_veyron.jpg" },
                    { 2, 2, true, true, "The F8 Tributo uses the same engine from the 488 Pista, a 3.9 L twin-turbocharged V8 engine, making it the most powerful conventional V8 powered Ferrari produced to date. Specific intake plenums and manifolds with optimised fluid-dynamics improve the combustion efficiency of the engine, thanks to the reduction of the temperature of the air in the cylinder, which also helps boost power.", "Ferrari F8 Tributo", "/images/cars/ferrari_f8_tributo.jpg", 70.55m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mid-engine sports super car.", 340, "/images/cars/ferrari_f8_tributo.jpg" },
                    { 3, 2, false, true, "In Ferrari's first official announcement of the car, the 458 was described as the successor to the F430 but arising from an entirely new design, incorporating technologies developed from the company's experience in Formula One. The body computer system was developed by Magneti Marelli.", "Ferrari 458", "/images/cars/ferrari_458.jpg", 65.55m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mid-engine sports super car.", 340, "/images/cars/ferrari_458.jpg" },
                    { 4, 3, true, true, "The second-generation 'Vanquish' (the 'V12' part of the name was dropped for this generation of cars) started life as the Project AM310 Concept and was unveiled at the 2012 Concorso d'Eleganza at Villa d'Este held on the shores of Lake Como, Italy. The concept car was based on the fourth generation of the VH platform.", "Aston Martin Vanquish", "/images/cars/aston_martin_vanquish.jpg", 60.55m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grand tourer", 306, "/images/cars/aston_martin_vanquish.jpg" },
                    { 5, 4, true, false, "In continuous production since 1964, the Mustang is currently the longest-produced Ford car nameplate. Currently in its sixth generation, it is the fifth-best selling Ford car nameplate. The namesake of the 'pony car' automobile segment, the Mustang was developed as a highly styled line of sporty coupes and convertibles derived from existing model lines, initially distinguished by 'long hood, short deck' proportions.", "Ford Mustang GT 2018", "/images/cars/ford_mustang_gt.jpg", 64.70m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Muscle car", 250, "/images/cars/ford_mustang_gt.jpg" },
                    { 6, 5, true, false, "A mid-size American automobile manufactured by Chevrolet, classified as a pony car. Competing model to the Ford Mustang.", "Chevrolet Camaro SS", "/images/cars/chevrolet-camaro-ss.jpg", 62.50m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pony car", 250, "/images/cars/chevrolet-camaro-ss.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 5);
        }
    }
}
