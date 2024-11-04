using Carbook.Domain.Entities;
using System;
using System.Linq;

namespace CarBook.Application.interfaces.CarInterfaces
{
    public interface ICarRepository
    {
        List<Car> GetCarsListWithBrands();
        List<Car> GetLast5CarsWithBrands();
        int GetCarCount();
    }
}
