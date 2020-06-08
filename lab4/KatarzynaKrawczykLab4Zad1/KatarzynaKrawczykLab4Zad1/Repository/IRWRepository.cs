using KatarzynaKrawczykLab4Zad1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatarzynaKrawczykLab4Zad1.Repository
{
    interface IRWRepository<T> where T : Entity
    {
        List<T> GetAll();
        T GetById(int id);

        void Delete(T entity);
        void Update(T entity);
        void Create(T entity);
    }
}
