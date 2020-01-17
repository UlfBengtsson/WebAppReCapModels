using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppReCapModels.Models
{
    public interface ICarService
    {
        Car Create(string brand, string modelName, DateTime year);
        bool Remove(int id);
        Car Find(int id);
        List<Car> All();
        bool Update(Car car);
    }
}
