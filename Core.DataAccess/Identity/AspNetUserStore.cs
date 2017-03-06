using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Core.DataAccess.Identity
{
    public abstract class AspNetUserStore<TUser, TRole> : UserStore<TUser, TRole, int, AspNetUserLogin, AspNetUserRole, AspNetUserClaim>
        where TUser : AspNetUser
        where TRole : AspNetRole
    {
        protected AspNetUserStore(DbContext context) : base(context)
        {
        }
    }
}