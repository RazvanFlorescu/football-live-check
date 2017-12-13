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
    }
}