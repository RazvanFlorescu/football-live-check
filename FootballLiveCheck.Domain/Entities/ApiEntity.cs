using System.ComponentModel.DataAnnotations.Schema;

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