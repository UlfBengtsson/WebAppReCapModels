using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppReCapModels.Models
{
    public interface ICakeService
    {
        Cake Find(int id);
        Cake Create(CakeViewModel cake);
        bool Remove(int id);
        Cake Update(Cake cake);
        List<Cake> All();
    }
}
