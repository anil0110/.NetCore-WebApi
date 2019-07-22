using ArticleManagement.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleManagement.Context
{
    public class ArticleContext:DbContext
    {
        public ArticleContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<Article> Articles { get; set; }
    }
}
