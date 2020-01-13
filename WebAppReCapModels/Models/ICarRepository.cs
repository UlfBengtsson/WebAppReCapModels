using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppReCapModels.Models
{
    public interface ICarRepository
    {
        Car Create(Car car);
        bool Remove(Car car);
        Car Find(int id);
        List<Car> All();
        bool Update(Car car);
    }
}
