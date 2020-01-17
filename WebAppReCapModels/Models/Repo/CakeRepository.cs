using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppReCapModels.Models
{
    public class CakeRepository : ICakeRepository
    {
        ExDbContext _exDbContext;

        public CakeRepository(ExDbContext exDbContext)
        {
            _exDbContext = exDbContext;
        }

        public List<Cake> All()
        {
            return _exDbContext.Cakes.ToList();
        }

        public Cake Create(Cake cake)
        {
            _exDbContext.Cakes.Add(cake);

            _exDbContext.SaveChanges();

            return cake;
        }

        public Cake Find(int id)
        {
            return _exDbContext.Cakes.SingleOrDefault(cake => cake.Id == id);
        }

        public bool Remove(Cake cake)
        {
            var result = _exDbContext.Cakes.Remove(cake);

            _exDbContext.SaveChanges();

            return true;
        }

        public Cake Update(Cake cake)
        {
            Cake original = Find(cake.Id);

            original.Name = cake.Name;
            original.Price = cake.Price;
            original.Servings = cake.Servings;
            original.NutsFree = cake.NutsFree;
            original.GlutenFree = cake.GlutenFree;
            original.LactoseFree = cake.LactoseFree;

            _exDbContext.SaveChanges();

            return original;
        }
    }
}
