using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Core.DataAccess;
using DataAccess.Entities;
using Z.EntityFramework.Plus;

namespace DataAccess
{
    public class EfContext : DataContext<User, Role>
    {
        public IDbSet<Tenant> Tenants { get; set; }

        static EfContext()
        {
            Database.SetInitializer<EfContext>(null);
        }

        public EfContext()
            : this("DefaultConnection")
        {
        }

        public EfContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            this.Filter<IMustHaveTenant>(q => q.Where(x => x.TenantId == 1));
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}