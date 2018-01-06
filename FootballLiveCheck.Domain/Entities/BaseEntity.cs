using System;

namespace FootballLiveCheck.Domain.Entities
{
    public abstract class BaseEntity
    {
        
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        
        public Guid Id { get; private set; }
        public int ApiId { get; private set; }
    }
}