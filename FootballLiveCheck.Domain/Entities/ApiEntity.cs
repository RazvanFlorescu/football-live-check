using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace FootballLiveCheck.Domain.Entities
{
    public abstract class ApiEntity
    {
        protected ApiEntity()
        {
            
        }
        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; protected set; }

        public void SetId(int id)
        {
            Id = id;
        }
    }
}