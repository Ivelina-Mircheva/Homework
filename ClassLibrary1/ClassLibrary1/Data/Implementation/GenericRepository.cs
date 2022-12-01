using ClassLibrary1.Abstract;
using ClassLibrary1.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Data.Implementation
{
    class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly PetsContext _context;
        private readonly DbSet<T> DbSet;

        public GenericRepository()
        {
            this._context = new PetsContext();
            this.DbSet = this._context.Set<T>();
        }
        public List<T> All()
        {
            return DbSet.ToList();
        }
        public T GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        public void Create(T entity)
        {
            DbSet.Add(entity);
            //_context.SaveChanges();
        }

        public void Update(Guid id, T entity)
        {
            DbSet.Attach(entity);
            //_context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(Guid id)
        {
            T find = DbSet.Find(id);
            DbSet.Remove(find);
            //_context.SaveChanges();
        }
    }
}
