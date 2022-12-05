using CarApi.Models;
using CarApi.Models.Dto;
using Microsoft.AspNetCore.Components.Routing;

namespace CarApi.Services
{
    public class CarAdapter : ICarAdapter
    {
        public GetCarResult Bind(Car car)
        {
            return new GetCarResult
            {
                Id = car.Id,
                Mark = car.Mark,
                Model = car.Model,
                Year = car.Year.ToString("yyyy-MM-dd"),
                PlateNumber = car.PlateNumber ?? "neregistruota",
                GearBox = car.GearBox.ToString(),
                Fuel = car.Fuel.ToString()
            };
        }
    }
}

