using System.Data.Entity;
using System.Linq;
using Z.EntityFramework.Plus;

namespace Core.DataAccess.Repositories
{
    public class ReadOnlyRepository<T> where T : class
    {
        protected virtual DbSet<T> DbSet { get; }

        public ReadOnlyRepository(DbContext context)
        {
            DbSet = context.Set<T>();
        }

        public virtual IQueryable<T> Queryable()
        {
            return DbSet;
        }

        public IQueryable<T> AsNoFilter()
        {
            return DbSet.AsNoFilter();
        }
    }
}