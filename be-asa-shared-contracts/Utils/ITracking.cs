namespace be_asa_shared_contracts.Utils
{
    public interface ITracking
    {
        string CreatedBy { get; set; }
        string LastUpdatedBy { get; set; }
        string? DeletedBy { get; set; }

        DateTimeOffset CreatedTime { get; set; }
        DateTimeOffset LastUpdatedTime { get; set; }
        DateTimeOffset? DeletedTime { get; set; }

        bool IsDeleted { get; set; }
    }
}
