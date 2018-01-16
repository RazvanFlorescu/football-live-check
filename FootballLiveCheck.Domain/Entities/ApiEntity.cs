using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using FootballLiveCheck.Domain.Interfaces;

namespace FootballLiveCheck.Domain.Entities
{
    public abstract class ApiEntity : EntityComparer<ApiEntity>
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