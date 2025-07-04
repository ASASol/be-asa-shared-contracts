﻿namespace be_asa_shared_contracts.Utils
{
    public abstract class BaseEntity
    {
        public string CreatedBy { get; set; }
        public string LastUpdatedBy { get; set; }
        public string? DeletedBy { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public DateTimeOffset LastUpdatedTime { get; set; }
        public DateTimeOffset? DeletedTime { get; set; }

        public bool IsDeleted { get; set; }

        protected BaseEntity()
        {
            CreatedTime = LastUpdatedTime = CoreHelper.SystemTimeNow;
        }
    }
}
