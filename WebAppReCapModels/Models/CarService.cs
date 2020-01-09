using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppReCapModels.Models
{
    public class CarService : ICarService
    {
        private static int idCounter = 0;
        private static List<Car> cars = new List<Car>();

        public List<Car> All()
        {
            return cars;
        }

        public Car Create(string brand, string modelName)
        {
            if (string.IsNullOrWhiteSpace(brand) || string.IsNullOrWhiteSpace(modelName))
            {
                return null;
            }

            Car car = new Car() { Id = ++idCounter, Brand = brand, ModelName = modelName };
            cars.Add(car);

            return car;
        }

        public Car Find(int id)
        {
            return cars.SingleOrDefault(car => car.Id == id);
        }

        public bool Remove(int id)
        {
            Car car = Find(id);

            if (car != null)
            {
                return cars.Remove(car);
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

            return true;
        }
    }
}
