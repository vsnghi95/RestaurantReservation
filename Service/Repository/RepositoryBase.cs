using Microsoft.EntityFrameworkCore;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Repository
{
    public class RepositoryBase<T> where T : class
    {
        restaurant2Context context;
        DbSet<T> set;
        public RepositoryBase()
        {
            context = new restaurant2Context();

            set = context.Set<T>();
        }

        public List<T> GetAll()
        {
            return set.ToList();
        }

        public void Create(T entity)
        {
            set.Add(entity);
            context.SaveChanges();
        }

        public bool Delete(T entity)
        {
            set.Remove(entity);
            context.SaveChanges();
            return true;
        }
        public void Update(T entity)
        {
            var tracker = context.Attach(entity);
            tracker.State = EntityState.Modified;
            context.SaveChanges();

        }
    }
}
