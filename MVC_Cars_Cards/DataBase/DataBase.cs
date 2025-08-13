using MVC_Cars_Cards.Entities;
using System.Collections.Generic;

namespace MVC_Cars_Cards.DataBase
{
    public class DataBase
    {
        public List<Car> Cars = new List<Car>
        {
            new Car
            {
                Id = Guid.NewGuid(),
                Company = "Toyota",
                Model = "Camry",
                Year = 2020,
                Mileage = 35000,
                Price = 24500m,
                WasInAccident = false
            },
            new Car
            {
                Id = Guid.NewGuid(),
                Company = "Honda",
                Model = "Civic",
                Year = 2018,
                Mileage = 45000,
                Price = 18500m,
                WasInAccident = true
            },
            new Car
            {
                Id = Guid.NewGuid(),
                Company = "Ford",
                Model = "F-150",
                Year = 2019,
                Mileage = 28000,
                Price = 32500m,
                WasInAccident = false
            },
            new Car
            {
                Id = Guid.NewGuid(),
                Company = "BMW",
                Model = "X5",
                Year = 2021,
                Mileage = 15000,
                Price = 48500m,
                WasInAccident = false
            },
            new Car
            {
                Id = Guid.NewGuid(),
                Company = "Tesla",
                Model = "Model 3",
                Year = 2022,
                Mileage = 8000,
                Price = 42500m,
                WasInAccident = false
            },
            new Car
            {
                Id = Guid.NewGuid(),
                Company = "Chevrolet",
                Model = "Malibu",
                Year = 2017,
                Mileage = 68000,
                Price = 14500m,
                WasInAccident = true
            },
            new Car
            {
                Id = Guid.NewGuid(),
                Company = "Audi",
                Model = "A4",
                Year = 2020,
                Mileage = 22000,
                Price = 34500m,
                WasInAccident = false
            },
            new Car
            {
                Id = Guid.NewGuid(),
                Company = "Hyundai",
                Model = "Tucson",
                Year = 2021,
                Mileage = 18000,
                Price = 26500m,
                WasInAccident = false
            },
            new Car
            {
                Id = Guid.NewGuid(),
                Company = "Mercedes-Benz",
                Model = "C-Class",
                Year = 2019,
                Mileage = 32000,
                Price = 38500m,
                WasInAccident = true
            },
            new Car
            {
                Id = Guid.NewGuid(),
                Company = "Nissan",
                Model = "Rogue",
                Year = 2018,
                Mileage = 52000,
                Price = 19500m,
                WasInAccident = false
            }
        };
    }
}