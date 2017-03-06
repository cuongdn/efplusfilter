using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Core.DataAccess.Identity
{
    public abstract class AspNetRoleStore<TRole> : RoleStore<TRole, int, AspNetUserRole>
        where TRole : AspNetRole, new()
    {
        protected AspNetRoleStore(DbContext context) : base(context)
        {
        }
    }
}