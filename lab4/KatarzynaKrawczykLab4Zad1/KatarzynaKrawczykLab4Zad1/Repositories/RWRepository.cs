using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KatarzynaKrawczykLab4Zad1.Models;

namespace KatarzynaKrawczykLab4Zad1
{
    class RWRepository : IRWRepository<T> where T : Entity
    {
        private readonly Models.AppContext ctx;

        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int T)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
