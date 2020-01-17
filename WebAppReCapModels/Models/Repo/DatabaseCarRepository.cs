using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppReCapModels.Models
{
    public class DatabaseCarRepository :ICarRepository
    {
        readonly ExDbContext _exDbContext;

        public DatabaseCarRepository(ExDbContext exDbContext)
        {
            _exDbContext = exDbContext;
        }

        public List<Car> All()
        {
            return _exDbContext.Cars.ToList();
        }

        public Car Create(Car car)
        {
            _exDbContext.Cars.Add(car);

            _exDbContext.SaveChanges();//Don´t forget this!

            return car;
        }

        public Car Find(int id)
        {
            return _exDbContext.Cars.SingleOrDefault(car => car.Id == id);
        }

        public bool Remove(Car car)
        {
            var result =_exDbContext.Cars.Remove(car);

            _exDbContext.SaveChanges();

            return true;
        }

        public bool Update(Car car)
        {
            Car carOrginal = Find(car.Id);

            if (carOrginal == null)
            {
                return false;
            }

            carOrginal = car;

            _exDbContext.SaveChanges();

            return true;

        }
    }
}
