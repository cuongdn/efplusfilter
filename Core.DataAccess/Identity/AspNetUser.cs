using System.ComponentModel.DataAnnotations.Schema;
using Core.DataAccess.Infrastructure;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Core.DataAccess.Identity
{
    public abstract class AspNetUser : IdentityUser<int, AspNetUserLogin, AspNetUserRole, AspNetUserClaim>, IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}