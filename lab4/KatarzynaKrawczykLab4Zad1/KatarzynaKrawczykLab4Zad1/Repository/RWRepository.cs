using KatarzynaKrawczykLab4Zad1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatarzynaKrawczykLab4Zad1.Repository
{
    public class RWRepository<T> : IRWRepository<T> where T : Entity
    {
        private readonly Models.AppContext ctx;

        public RWRepository(Models.AppContext ctx)
        {
            this.ctx = ctx;
        }
        public void Create(T entity) //dodaje do tabeli zadany obiekt
        {
            ctx.Set<T>().Add(entity);
            ctx.SaveChanges();
        }

        public void Delete(T entity) //usuwa z tabeli zadany obiekt
        {
            ctx.Set<T>().Remove(entity);
            ctx.SaveChanges();
        }

        public List<T> GetAll() //pobiera wszystkie obiekty z tabeli i tworzy z nich listę 
        {
            return ctx.Set<T>().ToList();
        }

        public T GetById(int id) //zwraca obiekt o danym id 
        {
            return ctx.Set<T>().Find(id);
        }

        public void Update(T entity) //nadpisuje dane w danym obiekcie 
        {
            ctx.Set<T>().Attach(entity);
            ctx.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}
