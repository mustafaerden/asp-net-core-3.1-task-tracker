using DataAccess.Concrete.EntityFrameworkCore.Contexts;
using DataAccess.Interfaces;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<T> : IGenericDal<T> where T : class, ITable, new()
    {
        // context.Tasks aslinda sununla ayni: context.Set<Task>()

        public void Create(T table)
        {
            using var context = new DataContext();
            context.Set<T>().Add(table);
            context.SaveChanges();
        }

        public void Delete(T table)
        {
            using var context = new DataContext();
            context.Set<T>().Remove(table);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var context = new DataContext();
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var context = new DataContext();
            return context.Set<T>().Find(id);
        }

        public void Update(T table)
        {
            using var context = new DataContext();
            context.Set<T>().Update(table);
            context.SaveChanges();
        }
    }
}
