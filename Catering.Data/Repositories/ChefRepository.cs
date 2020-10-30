using Catering.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.Data.Repositories
{
    public class ChefRepository
    {
        private readonly CateringContext _ctx;

        public ChefRepository()
        {
            _ctx = new CateringContext();
        }
        public Chef Create(Chef model)
        {

            _ctx.Chefs.Add(model);

            _ctx.SaveChanges();

            return model;
        }

        public Chef GetById(int id)
        {
            return _ctx.Chefs.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Chef> GetAll()
        {
            return _ctx.Chefs.ToList();
        }

        public Chef Update(Chef model)
        {
            var entity = _ctx.Chefs.FirstOrDefault(x => x.Id == model.Id);

            entity.FullName = model.FullName;
            entity.ChefType = model.ChefType;

            _ctx.SaveChanges();

            return model;
        }

        public bool Delete(int id)
        {
            try
            {
                var entity = _ctx.Chefs.FirstOrDefault(x => x.Id == id);

                _ctx.Chefs.Remove(entity);

                _ctx.SaveChanges();

                return true;
            }
            catch { return false; }
        }
    }
}
