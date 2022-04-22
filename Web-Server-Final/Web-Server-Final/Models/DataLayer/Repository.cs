using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Web_Server_Final.Models
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected WebServerFinalContext context { get; set; }

        private DbSet<T> dbset { get; set; }

        public Repository(WebServerFinalContext ctx)
        {
            context = ctx;
            dbset = context.Set<T>();
        }

        public virtual IEnumerable<T> List(QueryOptions<T> options)
        {
            IQueryable<T> query = dbset;
            foreach(string include in options.GetIncludes())
            {
                query = query.Include(include);
            }
            if (options.HasOrderBy)
            {
                query = query.OrderBy(options.OrderBy);
            }
            return query.ToList();
        }
    }
}
