using TrustedRide.Domain.Models;
using TrustedRide.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrustedRide.Infrastructure.Implementations
{
    public class InMemoryCarRepository : ICarRepository
    {
        private readonly IBrandRepository _brandRepository = new InMemoryBrandRepository();

        public IEnumerable<Car> GetAllCars()
        { 
           
            return new List<Car>
            {
                new Car { CarId = 1, Name = "Bugatti Veyron 16.4", Price=80.55M, ShortDescription="Mid-engine sports super car.", Brand=_brandRepository.GetAllBrands().ToList()[0], IsAvailable=true, Speed=407, IsInPromotion=true,  LongDescription="The original version has a top speed of 407 km/h (253 mph). It was named Car of the Decade and best car award (2000–2009) by the BBC television programme Top Gear. The standard Bugatti Veyron also won Top Gear's Best Car Driven All Year award in 2005.", PictureUrl="/images/cars/bugatti_veyron.jpg", ThumbnailPictureUrl="/images/cars/bugatti_veyron.jpg" },
                new Car { CarId = 2, Name = "Ferrari F8 Tributo", Price=70.55M, ShortDescription="Mid-engine sports super car.", Brand=_brandRepository.GetAllBrands().ToList()[1], IsAvailable=true, Speed=340, IsInPromotion=true, LongDescription="The F8 Tributo uses the same engine from the 488 Pista, a 3.9 L twin-turbocharged V8 engine, making it the most powerful conventional V8 powered Ferrari produced to date. Specific intake plenums and manifolds with optimised fluid-dynamics improve the combustion efficiency of the engine, thanks to the reduction of the temperature of the air in the cylinder, which also helps boost power.", PictureUrl="/images/cars/ferrari_f8_tributo.jpg", ThumbnailPictureUrl="/images/cars/ferrari_f8_tributo.jpg" },
                new Car { CarId = 3, Name = "Ferrari 458", Price=65.55M, ShortDescription="Mid-engine sports super car.", Brand=_brandRepository.GetAllBrands().ToList()[1], IsAvailable=false, Speed=340, IsInPromotion=true,  LongDescription="In Ferrari's first official announcement of the car, the 458 was described as the successor to the F430 but arising from an entirely new design, incorporating technologies developed from the company's experience in Formula One. The body computer system was developed by Magneti Marelli.", PictureUrl="/images/cars/ferrari_458.jpg", ThumbnailPictureUrl="/images/cars/ferrari_458.jpg" },
                new Car { CarId = 4, Name = "Aston Martin Vanquish", Price=60.55M, ShortDescription="Grand tourer.", Brand=_brandRepository.GetAllBrands().ToList()[2], IsAvailable=true, Speed=306, IsInPromotion=true,  LongDescription="The second-generation 'Vanquish' (the 'V12' part of the name was dropped for this generation of cars) started life as the Project AM310 Concept and was unveiled at the 2012 Concorso d'Eleganza at Villa d'Este held on the shores of Lake Como, Italy. The concept car was based on the fourth generation of the VH platform.", PictureUrl="/images/cars/aston_martin_vanquish.jpg", ThumbnailPictureUrl="/images/cars/aston_martin_vanquish.jpg" }
            };
}
        public IEnumerable<Car> GetAllAvailableCars()
            => GetAllCars().Where(c => c.IsAvailable == true);

        public Car GetCarById(int carId)
            => GetAllCars().FirstOrDefault(c => c.CarId == carId);
    }
}
