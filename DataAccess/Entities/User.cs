using Core.DataAccess.Identity;

namespace DataAccess.Entities
{
    public class User : AspNetUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TenantId { get; set; }
    }
}