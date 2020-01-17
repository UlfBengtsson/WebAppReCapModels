using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppReCapModels.Models
{
    public class CarService : ICarService
    {
        ICarRepository _carRepo;

        public CarService(ICarRepository carRepo)//Dependency Injection
        {
            _carRepo = carRepo;
        }

        public List<Car> All()
        {
            return _carRepo.All();
        }

        public Car Create(string brand, string modelName, DateTime year)
        {
            if (string.IsNullOrWhiteSpace(brand)
                || string.IsNullOrWhiteSpace(modelName)
                || year == null
                )
            {
                return null;
            }

            Car car = new Car() { Brand = brand, ModelName = modelName, Year = year };

            return _carRepo.Create(car);
        }

        public Car Find(int id)
        {
            return _carRepo.Find(id);
        }

        public bool Remove(int id)
        {
            Car car = Find(id);

            if (car != null)
            {
                return _carRepo.Remove(car);
            }

            return false;
        }

        public bool Update(Car car)
        {
            if (car == null)
            {
                return false;
            }

            Car currentCar = Find(car.Id);

            if (currentCar == null)
            {
                return false;
            }

            currentCar.Brand = car.Brand;
            currentCar.ModelName = car.ModelName;
            currentCar.Year = car.Year;

            _carRepo.Update(currentCar);

            return true;
        }
    }
}
