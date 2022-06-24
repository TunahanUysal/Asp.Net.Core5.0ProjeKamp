using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class


    {
        public void Delete(T entity)
        {
            using var context = new Context();
            context.Remove(entity);
            context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> method)
        {
            using var context = new Context();
            return context.Set<T>().SingleOrDefault(method);
        }

        public List<T> GetAll(T entity)
        {
            using var context = new Context();
            return context.Set<T>().ToList();

        }

        public T GetById(int id)
        {
            using var context = new Context();
            return context.Set<T>().Find(id);
        }

        public List<T> GetByQuery(Expression<Func<T, bool>> method)
        {
            using var context = new Context();
            return context.Set<T>().Where(method).ToList();
        }

        public void Insert(T entity)
        {
            using var context = new Context();
            context.Add(entity);
            context.SaveChanges();

        }

        public void Update(T entity)
        {
            using var context = new Context();
            context.Update(entity);
            context.SaveChanges();
        }
    }
   
}
