using be_asa_shared_contracts.DTO;
using be_asa_shared_contracts.Interfaces;
using be_asa_shared_contracts.Utils;

namespace be_asa_shared_infrastructure.Integrations
{
    public class GlobalTimeContext : IGlobalTimeContext
    {
        private long _offsetTicks = 0;

        public void SetDatabaseUtc(DateTimeOffset dbTime)
        {
            var offset = dbTime - DateTimeOffset.UtcNow;
            Interlocked.Exchange(ref _offsetTicks, offset.Ticks);
        }

        public DateTimeOffset UtcNow
        {
            get
            {
                var ticks = Interlocked.Read(ref _offsetTicks);
                return DateTimeOffset.UtcNow.AddTicks(ticks);
            }
        }

        public TimeSpan CurrentOffset
        {
            get
            {
                var ticks = Interlocked.Read(ref _offsetTicks);
                return TimeSpan.FromTicks(ticks);
            }
        }
    }
}
