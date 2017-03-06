using System.Data.Entity;
using Core.DataAccess.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Core.DataAccess
{
    public class DataContext<TUser, TRole> : IdentityDbContext<TUser, TRole, int, AspNetUserLogin, AspNetUserRole, AspNetUserClaim>
        where TUser : AspNetUser
        where TRole : AspNetRole
    {
        protected DataContext(string nameOrConnectionString)
           : base(nameOrConnectionString)
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AspNetUserRole>().ToTable("UserRole");
            modelBuilder.Entity<AspNetUserLogin>().ToTable("UserLogin");
            modelBuilder.Entity<AspNetUserClaim>().ToTable("UserClaim");
        }
    }
}