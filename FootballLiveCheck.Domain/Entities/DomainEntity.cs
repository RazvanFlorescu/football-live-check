using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballLiveCheck.Domain.Entities
{
    public abstract class DomainEntity
    {
        
        protected DomainEntity()
        {
            Id = Guid.NewGuid();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
    }
}