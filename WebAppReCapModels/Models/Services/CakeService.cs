using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppReCapModels.Models
{
    public class CakeService : ICakeService
    {
        ICakeRepository _cakeRepository;

        public CakeService(ICakeRepository cakeRepository)
        {
            _cakeRepository = cakeRepository;
        }

        public List<Cake> All()
        {
            return _cakeRepository.All();
        }

        public Cake Create(CakeViewModel cake)
        {
            Cake realCake = new Cake()
            {
                Name = cake.Name,
                Price = cake.Price,
                Servings = cake.Servings,
                GlutenFree = cake.GlutenFree,
                LactoseFree = cake.LactoseFree,
                NutsFree = cake.NutsFree
            };

            return _cakeRepository.Create(realCake);
        }

        public Cake Find(int id)
        {
            return _cakeRepository.Find(id);
        }

        public bool Remove(int id)
        {
            Cake cake = Find(id);

            if (cake == null)
            {
                return false;
            }

            return _cakeRepository.Remove(cake);
        }

        public Cake Update(Cake cake)
        {
            return _cakeRepository.Update(cake);
        }
    }
}
