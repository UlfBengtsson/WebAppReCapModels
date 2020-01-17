using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppReCapModels.Models
{
    public class MockCarRepository : ICarRepository
    {
        private static int idCounter = 0;
        private static List<Car> cars = new List<Car>();

        public List<Car> All()
        {
            return cars;
        }

        public Car Create(Car car)
        {
            car.Id = ++idCounter;

            cars.Add(car);

            return car;
        }

        public Car Find(int id)
        {
            return cars.SingleOrDefault(car => car.Id == id);
        }

        public bool Remove(Car car)
        {
            return cars.Remove(car);
        }

        public bool Update(Car car)
        {
            Car carOrginal = Find(car.Id);

            if (carOrginal == null)
            {
                return false;
            }

            carOrginal = car;

            return true;

        }
    }
}
