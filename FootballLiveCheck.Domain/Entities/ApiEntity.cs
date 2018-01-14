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
       
        [Key]
        public int DbId { get; protected set; }

        public void SetId(int id)
        {
            DbId = id;
        }
    }
}