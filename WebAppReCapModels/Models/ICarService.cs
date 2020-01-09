using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppReCapModels.Models
{
    interface ICarService
    {
        Car Create(string brand, string modelName);
        bool Remove(int id);
        Car Find(int id);
        List<Car> All();
        bool Update(Car car);
    }
}
