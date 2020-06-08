using KatarzynaKrawczykLab4Zad1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatarzynaKrawczykLab4Zad1
{
    interface IRWRepository<T> where T : Entity
    {
        IList<T> GetAll();
        T GetById(int T);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity)
    }
}
