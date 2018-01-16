using System;
using System.Collections.Generic;
using System.Text;
using FootballLiveCheck.Domain.Entities;
using FootballLiveCheck.Domain.Interfaces;

namespace FootballLiveCheck.Domain
{
    public class EntityComparer<T>:IEntityComparer<T> 
        where T:ApiEntity
        
    {
        public  bool AreEquals(T t)
        {
            return false;
        }
    }
}
