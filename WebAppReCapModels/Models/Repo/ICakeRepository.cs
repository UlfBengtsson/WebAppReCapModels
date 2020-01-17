using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppReCapModels.Models
{
    public interface ICakeRepository
    {
        Cake Find(int id);
        Cake Create(Cake cake);
        bool Remove(Cake cake);
        Cake Update(Cake cake);
        List<Cake> All();
    }
}
