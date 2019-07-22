using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ArticleManagement.Repository
{

    public interface IRepository<T> where T : class
    {
        DbSet<T> Table { get; }
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        IQueryable<T> All();
        T GetById(long id);
    }
}
