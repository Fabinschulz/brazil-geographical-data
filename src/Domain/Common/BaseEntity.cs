﻿namespace BrazilGeographicalData.src.Domain.Common
{
    public class BaseEntity
    {
        public Guid Id { get; private set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset? UpdatedAt { get; set; } = null;
        public DateTimeOffset? DeletedAt { get; set; } = null;
        public bool IsDeleted { get; internal set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
