namespace be_asa_shared_contracts.Interfaces
{
    public interface IGlobalTimeContext
    {
        void SetDatabaseUtc(DateTimeOffset dbTime);
        DateTimeOffset UtcNow { get; }
        TimeSpan CurrentOffset { get; }
    }
}
