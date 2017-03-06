using System.ComponentModel.DataAnnotations.Schema;
using Core.DataAccess.Infrastructure;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Core.DataAccess.Identity
{
    public abstract class AspNetRole : IdentityRole<int, AspNetUserRole>, IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}