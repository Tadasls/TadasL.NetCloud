using CarApi.Models.Dto;
using CarApi.Models;

namespace CarApi.Services
{
    public interface ICarAdapter
    {
        GetCarResult Bind(Car car);
        Car Bind(PostCarRequest car);
        Car Bind(PutCarRequest car);
    }
}