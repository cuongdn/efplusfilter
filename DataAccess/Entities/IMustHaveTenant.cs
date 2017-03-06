namespace DataAccess.Entities
{
    public interface IMustHaveTenant
    {
        int TenantId { get; set; }
    }
}