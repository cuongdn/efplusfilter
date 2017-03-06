using System;

namespace DataAccess.Entities
{
    public class Tenant 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? OwnerId { get; set; }
    }
}
