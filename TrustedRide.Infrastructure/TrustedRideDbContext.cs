using Microsoft.EntityFrameworkCore;
using TrustedRide.Domain.Models;

namespace TrustedRide.Infrastructure
{
    public class TrustedRideDbContext : DbContext
    {
        public TrustedRideDbContext(DbContextOptions<TrustedRideDbContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<DealerCartItem> DealerCartItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // brands
            modelBuilder.Entity<Brand>().HasData(new Brand { BrandId = 1, Name = "Bugatti", Description = "Integrity, compliance and diversity" });
            modelBuilder.Entity<Brand>().HasData(new Brand { BrandId = 2, Name = "Ferrari", Description = "Italian excellence the rest of the world can only dream of" });
            modelBuilder.Entity<Brand>().HasData(new Brand { BrandId = 3, Name = "Aston Martin", Description = "Iconic Luxury British Sports Cars" });
            modelBuilder.Entity<Brand>().HasData(new Brand { BrandId = 4, Name = "Ford", Description = "Go Further" });
            modelBuilder.Entity<Brand>().HasData(new Brand { BrandId = 5, Name = "Chevrolet", Description = "Find New Roads" });

            //cars
            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 1,
                Name = "Bugatti Veyron 16.4",
                Price = 80.55M,
                ShortDescription = "Mid-engine sports super car.",
                BrandId = 1,
                IsAvailable = true,
                Speed = 407,
                IsInPromotion = true,
                LongDescription = "The original version has a top speed of 407 km/h (253 mph). It was named Car of the Decade and best car award (2000–2009) by the BBC television programme Top Gear. The standard Bugatti Veyron also won Top Gear's Best Car Driven All Year award in 2005.",
                PictureUrl = "/images/cars/bugatti_veyron.jpg",
                ThumbnailPictureUrl = "/images/cars/bugatti_veyron.jpg",
            });

            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 2,
                Name = "Ferrari F8 Tributo",
                Price = 70.55M,
                ShortDescription = "Mid-engine sports super car.",
                BrandId = 2,
                IsAvailable = true,
                Speed = 340,
                IsInPromotion = true,
                LongDescription = "The F8 Tributo uses the same engine from the 488 Pista, a 3.9 L twin-turbocharged V8 engine, making it the most powerful conventional V8 powered Ferrari produced to date. Specific intake plenums and manifolds with optimised fluid-dynamics improve the combustion efficiency of the engine, thanks to the reduction of the temperature of the air in the cylinder, which also helps boost power.",
                PictureUrl = "/images/cars/ferrari_f8_tributo.jpg",
                ThumbnailPictureUrl = "/images/cars/ferrari_f8_tributo.jpg"
            });

            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 3,
                Name = "Ferrari 458",
                Price = 65.55M,
                ShortDescription = "Mid-engine sports super car.",
                BrandId = 2,
                IsAvailable = false,
                Speed = 340,
                IsInPromotion = true,
                LongDescription = "In Ferrari's first official announcement of the car, the 458 was described as the successor to the F430 but arising from an entirely new design, incorporating technologies developed from the company's experience in Formula One. The body computer system was developed by Magneti Marelli.",
                PictureUrl = "/images/cars/ferrari_458.jpg",
                ThumbnailPictureUrl = "/images/cars/ferrari_458.jpg"
            });

            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 4,
                Name = "Aston Martin Vanquish",
                Price = 60.55M,
                ShortDescription = "Grand tourer",
                BrandId = 3,
                IsAvailable = true,
                Speed = 306,
                IsInPromotion = true,
                LongDescription = "The second-generation 'Vanquish' (the 'V12' part of the name was dropped for this generation of cars) started life as the Project AM310 Concept and was unveiled at the 2012 Concorso d'Eleganza at Villa d'Este held on the shores of Lake Como, Italy. The concept car was based on the fourth generation of the VH platform.",
                PictureUrl = "/images/cars/aston_martin_vanquish.jpg",
                ThumbnailPictureUrl = "/images/cars/aston_martin_vanquish.jpg"
            });

            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 5,
                Name = "Ford Mustang GT 2018",
                Price = 64.70M,
                ShortDescription = "Muscle car",
                BrandId = 4,
                IsAvailable = true,
                Speed = 250,
                IsInPromotion = false,
                LongDescription = "In continuous production since 1964, the Mustang is currently the longest-produced Ford car nameplate. Currently in its sixth generation, it is the fifth-best selling Ford car nameplate. The namesake of the 'pony car' automobile segment, the Mustang was developed as a highly styled line of sporty coupes and convertibles derived from existing model lines, initially distinguished by 'long hood, short deck' proportions.",
                PictureUrl = "/images/cars/ford_mustang_gt.jpg",
                ThumbnailPictureUrl = "/images/cars/ford_mustang_gt.jpg"
            });

            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 6,
                Name = "Chevrolet Camaro SS",
                Price = 62.50M,
                ShortDescription = "Pony car",
                BrandId = 5,
                IsAvailable = true,
                Speed = 250,
                IsInPromotion = false,
                LongDescription = "A mid-size American automobile manufactured by Chevrolet, classified as a pony car. Competing model to the Ford Mustang.",
                PictureUrl = "/images/cars/chevrolet-camaro-ss.jpg",
                ThumbnailPictureUrl = "/images/cars/chevrolet-camaro-ss.jpg"
            });
        }
    }
}