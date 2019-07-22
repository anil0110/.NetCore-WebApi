using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticleManagement.Context;
using Microsoft.EntityFrameworkCore;

namespace ArticleManagement.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ArticleContext dbContext;
        public Repository(ArticleContext dbContext)
        {
            this.dbContext = dbContext;
            this.Table = dbContext.Set<T>();
        }
        public DbSet<T> Table { get; set; }

        public bool Add(T entity)
        {
            Table.Add(entity);
            return Save();
        }

        public bool Update(T entity)
        {
            Table.Update(entity);
            return Save();
        }

        public bool Delete(T entity)
        {
            Table.Remove(entity);
            return Save();
        }

        public IQueryable<T> All()
        {
            return Table;
        }

        public T GetById(long id)
        {
            return Table.Find(id);
        }

        private bool Save()
        {
            try
            {
                dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    
    }
}
